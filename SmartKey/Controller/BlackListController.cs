using SmartKey.ModelGestione;
using SmartKey.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller
{
    class BlackListController : IGestoreBlacklist
    {
        public event EventHandler<ActionCompletedEvent> ToLog;
        private Blacklist _blacklist;
        
        public BlackListController()
        {
            _blacklist = Blacklist.Instance;
        }
        public void AggiungiUtente(string utente)
        {
            if (_blacklist.AggiungiUtenteCattivo(utente))
            {
                if (ToLog != null)
                {
                    //Creazione del parametro da passare quando scateno l'evento
                    ActionCompletedEvent args = new ActionCompletedEvent
                    {
                        ToEntry = EntryFactory.GetEntry(this, "aggiunto", utente)
                    };
                    //scateno gli handler registrati all'evento
                    foreach (EventHandler<ActionCompletedEvent> completed in ToLog.GetInvocationList())
                    {
                        completed(this, args);
                    }
                }
            }
            else
            {
                if (ToLog != null)
                {
                    //Creazione del parametro da passare quando scateno l'evento
                    ActionCompletedEvent args = new ActionCompletedEvent
                    {
                        ToEntry = EntryFactory.GetEntry(this, "non aggiunto", utente)
                    };
                    //scateno gli handler registrati all'evento
                    foreach (EventHandler<ActionCompletedEvent> completed in ToLog.GetInvocationList())
                    {
                        completed(this, args);
                    }
                }
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
                if (ToLog != null)
                {
                    //Creazione del parametro da passare quando scateno l'evento
                    ActionCompletedEvent args = new ActionCompletedEvent
                    {
                        ToEntry = EntryFactory.GetEntry(this, "rimosso", utente)
                    };
                    //scateno gli handler registrati all'evento
                    foreach (EventHandler<ActionCompletedEvent> completed in ToLog.GetInvocationList())
                    {
                        completed(this, args);
                    }
                }
            }
            else
            {
                if (ToLog != null)
                {
                    //Creazione del parametro da passare quando scateno l'evento
                    ActionCompletedEvent args = new ActionCompletedEvent
                    {
                        ToEntry = EntryFactory.GetEntry(this, "non rimosso", utente)
                    };
                    //scateno gli handler registrati all'evento
                    foreach (EventHandler<ActionCompletedEvent> completed in ToLog.GetInvocationList())
                    {
                        completed(this, args);
                    }
                }
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
