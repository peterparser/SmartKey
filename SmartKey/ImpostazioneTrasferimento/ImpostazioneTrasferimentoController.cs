using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.DataPersistence;
using SmartKey.ModelGestione;
using SmartKey.ModelLog;

namespace SmartKey.Controller
{
    public class ImpostazioneTrasferimentoController : IGestoreImpostazione
    {
        ISet<ImpostazioneTrasferimento> _impostazioni;
        public event EventHandler<ActionCompletedEvent> ToLog;
        public event EventHandler<PersistEvent> Persist;

        public ImpostazioneTrasferimentoController()
        {
            _impostazioni = new HashSet<ImpostazioneTrasferimento>();
        }

        void IGestoreImpostazione.AddImpostazione(ImpostazioneTrasferimento impostazione)
        {
            //Il log cambia a seconda dell'esito
            if (_impostazioni.Add(impostazione))
            {
                //Creazione del parametro da passare quando scateno l'evento
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.GetEntry(this, "aggiunta", impostazione.CartellaSorgente.Path,
                    impostazione.CartellaDestinazione.Path)
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
                    ToEntry = EntryFactory.GetEntry(this, "nonaggiunta", impostazione.CartellaSorgente.Path,
                   impostazione.CartellaDestinazione.Path)
                };
                ToLog?.Invoke(this, args);
            }
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
                    ToEntry = EntryFactory.GetEntry(this, "rimossa", impostazione.CartellaSorgente.Path,
                                                            impostazione.CartellaDestinazione.Path)
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
                    ToEntry = EntryFactory.GetEntry(this, "nonrimossa", impostazione.CartellaSorgente.Path,
                                                        impostazione.CartellaDestinazione.Path)
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
