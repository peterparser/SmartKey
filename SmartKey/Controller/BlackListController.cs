using SmartKey.ModelGestione;
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
                //TODO EVENTO INSERITO
            }
            else
            {
                // TODO EVENTO NON INSERITO
            }
        }

        public bool IsBlackListed(string utente)
        {
            throw new NotImplementedException();
        }

        public void RimuoviUtente(string utente)
        {
            if (_blacklist.EliminaUtenteCattivo(utente))
            {
                //TODO EVENTO RIMOSSO
            }
            else
            {
                //TODO EVENTO NON RIMOSSSOO
            }
        }

        public void SetBlackList(ISet<string> blacklist)
        {
            _blacklist.SetUtenti = blacklist;
        }
    }
}
