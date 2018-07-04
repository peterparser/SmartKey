using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartKey.Controller;
using SmartKey.DataPersistence;
using SmartKey.Log.ModelLog;

namespace SmartKey.ImpostazioneTrasferimento
{
    public class ImpostazioneTrasferimentoController : IGestoreImpostazione
    {
        ISet<ImpostazioneTrasferimento> _impostazioni;
        public event EventHandler<ActionCompletedEvent> ToLog;
        public event EventHandler<PersistEvent> Persist;
        private HomeImpostazioni _impostazioniView;
        public ImpostazioneTrasferimentoController()
        {
            _impostazioni = new HashSet<ImpostazioneTrasferimento>();
        }
        public ImpostazioneTrasferimentoController(HomeImpostazioni view)
        {
            _impostazioni = new HashSet<ImpostazioneTrasferimento>();
            _impostazioniView = view;
            _impostazioniView.AggiungiImpostazioneButton.Click += AddImpostazioneHandler;
        }

        private void AddImpostazioneHandler(object sender, EventArgs args)
        {
            String sorgente = null;
            String destinazione = null;
            //Mostrare le due dialog
            using(var sorgenteDialog = new FolderBrowserDialog())
            {
                sorgenteDialog.Description = "Seleziona la cartella da sincronizzare";
                DialogResult sorgenteResult = sorgenteDialog.ShowDialog();
                if(sorgenteResult == DialogResult.OK && !string.IsNullOrWhiteSpace(sorgenteDialog.SelectedPath))
                {
                    sorgente = sorgenteDialog.SelectedPath;
                }
            }
            using(var destinazioneDialog = new FolderBrowserDialog())
            {
                destinazioneDialog.Description = "Seleziona la cartella di destinazione";
                DialogResult destinazioneResult = destinazioneDialog.ShowDialog();
                if (destinazioneResult == DialogResult.OK && !string.IsNullOrWhiteSpace(destinazioneDialog.SelectedPath))
                {
                    destinazione = destinazioneDialog.SelectedPath;
                }
            }
            if (sorgente != null && destinazione != null)
            {
                bool toAdd = AddImpostazione(new ImpostazioneTrasferimento(sorgente, destinazione));
                if (toAdd)
                {
                    _impostazioniView.DataGridImpostazioni.Rows.Add(sorgente, destinazione);
                }
            }
        }

        public bool AddImpostazione(ImpostazioneTrasferimento impostazione)
        {


            bool toOut = _impostazioni.Add(impostazione);
            //Il log cambia a seconda dell'esito
            if (toOut)
            {
                //Creazione del parametro da passare quando scateno l'evento
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.CreateEntry(this, "aggiunta", sorgente:impostazione.CartellaSorgente.Path,
                    destinazione:impostazione.CartellaDestinazione)
                };
                PersistEvent toPersist = new PersistEvent
                {
                    ToPersist = impostazione,
                    Action = "aggiungi"
                };
                //scateno gli handler registrati all'evento
                ToLog?.Invoke(this, args);
                Persist?.Invoke(this, toPersist);
            }
            else
            {
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.CreateEntry(this, "nonaggiunta", impostazione.CartellaSorgente.Path,
                   impostazione.CartellaDestinazione)
                };
                ToLog?.Invoke(this, args);
            }
            return toOut;
        }

        ISet<ImpostazioneTrasferimento> IGestoreImpostazione.ElencoImpostazioni()
        {
            return _impostazioni;
        }

        bool IGestoreImpostazione.RemoveImpostazione(ImpostazioneTrasferimento impostazione)
        {
            bool toOut = _impostazioni.Remove(impostazione);
            if (toOut)
            {
            
                //Creazione dei parametri da passare agli handler dell'evento
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.CreateEntry(this, "rimossa", impostazione.CartellaSorgente.Path,
                                                            impostazione.CartellaDestinazione)
                };
                PersistEvent toPersist = new PersistEvent
                {
                    Action = "rimuovi",
                    ToPersist = impostazione
                };

                //Scateno l'evento
                ToLog?.Invoke(this, args);
                Persist?.Invoke(this, toPersist);
            }
            else
            {
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.CreateEntry(this, "nonrimossa", impostazione.CartellaSorgente.Path,
                                                        impostazione.CartellaDestinazione)
                };
                ToLog?.Invoke(this, args);
            }
            return toOut;
        }

        void IGestoreImpostazione.SetImpostazioni(ISet<ImpostazioneTrasferimento> impostazioni)
        {
            _impostazioni = impostazioni;
        }

    }
}
