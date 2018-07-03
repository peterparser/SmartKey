using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ModelGestione;
using SmartKey.ModelGestione.Filesystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller
{
    public class GestoreSincronizzazioneController : IGestoreSincronizzazione
    {
        public event EventHandler<ActionCompletedEvent> ToLog;
        private IGestoreBlacklist _blacklistController;

        public GestoreSincronizzazioneController(IGestoreBlacklist blacklistController)
        {
            _blacklistController = blacklistController;
        }
        private static string GetChecksumBuffered(Stream stream)
        {
            using (var bufferedStream = new BufferedStream(stream, 1024 * 32))
            {
                var sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(bufferedStream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

        //bisogna trovare un modo di mantenere il path destinazione
        private string _pathDestinazione;
        public void Sincronizza(IList<ImpostazioneTrasferimento.ImpostazioneTrasferimento> impostazioni)
        {
           foreach(ImpostazioneTrasferimento.ImpostazioneTrasferimento impostazione in impostazioni)
            {
                _pathDestinazione = impostazione.CartellaDestinazione;
                impostazione.CartellaSorgente.Accept(this);
            }
        }

        public void Visit(Cartella cartella)
        {
            if(cartella.Children.Count > 0)
            {
                //Creo la stringa del path da ricreare
                string dirname = new DirectoryInfo(cartella.Path).Name;
                string dirToSync = String.Join("\\", _pathDestinazione, dirname);
                //Creo la cartella richiesta se non esiste
                if (!Directory.Exists(dirToSync))
                {
                    Directory.CreateDirectory(dirToSync);
                }
                //Memorizzo il vecchio path per quando ho finito di ispezionare i figli
                string oldPath = _pathDestinazione;
                //Il nuovo path è quello di questa cartella
                _pathDestinazione = dirToSync;
                //Entro e sincronizzo le sottocartelle usando il nuovo path
                foreach (FilesystemElement element in cartella.Children)
                {
                    element.Accept(this);
                }
                //Ripristino il path vecchio =>(..)
                _pathDestinazione = oldPath;
            }
        }

        public void Visit(FileWrapper file)
        {
            FileInfo source = new FileInfo(file.Path);
            String fileDstPath = String.Join("\\", _pathDestinazione, source.Name);

            //Trovo l'autore del file
            string author = File.GetAccessControl(file.Path).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
            if (!author.Equals(Utente.GetNomeUtente()))
            {
                if (!_blacklistController.IsBlackListed(author))
                {
                    //Dobbiamo richiedere la risposta all'utente
                    bool riconosciuto = true;
                    if (riconosciuto)
                    {
                        //Se esiste Confronto gli hash se sono diversi sincronizzo
                        if (File.Exists(fileDstPath))
                        {
                            var sourceStream = new FileStream(file.Path, FileMode.Open, FileAccess.Read);
                            String srcSum = GetChecksumBuffered(sourceStream);
                            var dstStream = new FileStream(fileDstPath, FileMode.Open, FileAccess.Read);
                            String dstSum = GetChecksumBuffered(dstStream);

                            //Se gli hash non sono uguali
                            if (!srcSum.Equals(dstSum))
                            {
                                File.Copy(file.Path, fileDstPath);
                            }
                        }
                        //Copio diretto
                        else
                        {
                            File.Copy(file.Path, fileDstPath);
                        }
                    }
                    else
                    {
                        _blacklistController.AggiungiUtente(author);
                        //Elimino il file
                        File.Delete(file.Path);
                    }
                }
            }
            //Il file è del proprietario non c'è bisogno di chiamare la blacklist
            else
            {
                if (File.Exists(fileDstPath))
                {
                    var sourceStream = new FileStream(file.Path, FileMode.Open, FileAccess.Read);
                    String srcSum = GetChecksumBuffered(sourceStream);
                    var dstStream = new FileStream(fileDstPath, FileMode.Open, FileAccess.Read);
                    String dstSum = GetChecksumBuffered(dstStream);

                    //Se gli hash non sono uguali
                    if (!srcSum.Equals(dstSum))
                    {
                        File.Copy(file.Path, fileDstPath);
                    }
                }
                //Copio diretto
                else
                {
                    File.Copy(file.Path, fileDstPath);
                }
            }
        }
    }
}
