using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione
{
    public sealed class Blacklist
    {
        private ISet<string> _blacklist;
        //Serve per un implementazione thread safe di un singleton
        private static readonly object padlock = new object();
        private static Blacklist _instance;

        private Blacklist()
        {
            _blacklist = new HashSet<string>();
        }

        public static Blacklist Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Blacklist();
                    }
                    return _instance;
                }
            }
        }
        //Serve per settare al vol
        public ISet<String> SetUtenti
        {
            set
            {
                _blacklist = value;
            }
            get
            {
                return _blacklist;
            }
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
