using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.ModelGestione.Filesystem;

namespace SmartKey.ModelGestione
{
    class ChiaveUSB : IDispositivo
    {
        private DriveInfo _dispositivo;

        public ChiaveUSB(string _nome)
        {
            _dispositivo = new DriveInfo(_nome);
        }

        //Forse conviene restituire una stringa
        //Dato che dobbiamo solo visualizzare il path
        public Cartella OttieniCartellaPrivata()
        {

            foreach(DirectoryInfo dirInfo in _dispositivo.RootDirectory.GetDirectories())
            {
                Directory.GetDirectories(dirInfo.Name);
                if (dirInfo.Name.Equals((Utente.GetNomeUtente())))
                {
                   
                }
            }
            Directory.CreateDirectory(_dispositivo.RootDirectory.ToString() + Utente.GetNomeUtente());
            return new Cartella(Utente.GetNomeUtente());
        }

        public Cartella OttieniCartellaPubblica()
        {
            throw new NotImplementedException();
        }

        public string OttieniNomeDispositivo()
        {
            return _dispositivo.VolumeLabel;
        }
    }
}
