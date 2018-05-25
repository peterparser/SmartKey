using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione
{
    class Blacklist
    {
        private ISet<string> blacklist;

        public Blacklist()
        {
            blacklist = new HashSet<string>();
        }

        public Blacklist(ISet<string> blacklist)
        {
            this.blacklist = blacklist;
        }

        public bool AggiungiUtenteCattivo(string nomeUtente)
        {
            return blacklist.Add(nomeUtente);
        }
        
        public bool EliminaUtenteCattivo(string nomeUtente)
        {
            return blacklist.Remove(nomeUtente);
        }

        public bool IsInBlacklist(string nomeUtente)
        {
            return blacklist.Contains(nomeUtente);
        }
    }
}
