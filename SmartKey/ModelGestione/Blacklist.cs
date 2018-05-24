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

        public bool AggiungiUtenteCattivo(string nomeUtente)
        {
            return false;
        }
        
        public bool EliminaUtenteCattivo(string nomeUtente)
        {
            return false;
        }

        public bool IsInBlacklist(string nomeUtente)
        {
            return blacklist.Contains(nomeUtente);
        }
    }
}
