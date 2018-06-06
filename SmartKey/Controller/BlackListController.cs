using SmartKey.Controller.Controller.Interfaces;
using SmartKey.DataPersistence;
using SmartKey.ModelGestione;
using SmartKey.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller
{
    class BlackListController : IGestoreBlacklist,IPersistActions
    {
        public event EventHandler<ActionCompletedEvent> ToLog;
        public event EventHandler<PersistEvent> Persist;

        private Blacklist _blacklist;
        
        public BlackListController()
        {
            _blacklist = Blacklist.Instance;
        }
        public void AggiungiUtente(string utente)
        {
            if (_blacklist.AggiungiUtenteCattivo(utente))
            {
                //Creazione del parametro da passare quando scateno l'evento
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.GetEntry(this, "aggiunto", utente)
                };
                PersistEvent toPersist = new PersistEvent
                {
                    Action = "aggiungi",
                    ToPersist = utente
                };
                //scateno gli handler registrati all'evento
                ToLog?.Invoke(this, args);
                Persist?.Invoke(this, toPersist);
            }
            else
            {
                //Creazione del parametro da passare quando scateno l'evento
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.GetEntry(this, "non aggiunto", utente)
                };
                //scateno gli handler registrati all'evento
                    ToLog?.Invoke(this, args);
            }
        }

        public bool IsBlackListed(string utente)
        {
            return _blacklist.IsInBlacklist(utente);
        }

        public void RimuoviUtente(string utente)
        {
            if (_blacklist.EliminaUtenteCattivo(utente))
            {
                //Creazione del parametro da passare quando scateno l'evento
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.GetEntry(this, "rimosso", utente)
                };
                //scateno gli handler registrati all'evento
                PersistEvent toPersist = new PersistEvent
                {
                    Action = "rimuovi",
                    ToPersist = utente
                };
                //scateno gli handler registrati all'evento
                ToLog?.Invoke(this, args);
                Persist?.Invoke(this, toPersist);
            }
            else
            {
                //Creazione del parametro da passare quando scateno l'evento
                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.GetEntry(this, "non rimosso", utente)
                };
                //scateno gli handler registrati all'evento
                ToLog?.Invoke(this, args);
            }
        }
        public void SetBlackList(ISet<string> blacklist)
        {
            _blacklist.SetUtenti = blacklist;
        }
        public ISet<String> GetUtentiInBlackList()
        {
            return _blacklist.SetUtenti;
        }
    }
}
