using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione
{
    class Blacklist
    {
        private ISet<string> _blacklist;

        public Blacklist()
        {
            _blacklist = new HashSet<string>();
        }

        public Blacklist(ISet<string> blacklist)
        {
            this._blacklist = blacklist;
        }

        public bool AggiungiUtenteCattivo(string nomeUtente)
        {
            return _blacklist.Add(nomeUtente);
        }
        
        public bool EliminaUtenteCattivo(string nomeUtente)
        {
            return _blacklist.Remove(nomeUtente);
        }

        public bool IsInBlacklist(string nomeUtente)
        {
            return _blacklist.Contains(nomeUtente);
        }
    }
}
