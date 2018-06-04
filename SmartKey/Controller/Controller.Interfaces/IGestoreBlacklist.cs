using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller
{
    interface IGestoreBlacklist : IController
    {
        void SetBlackList(ISet<string> blacklist);
        void AggiungiUtente(string utente);
        void RimuoviUtente(string utente);
        bool IsBlackListed(string utente);
        ISet<String> GetUtentiInBlackList();

    }
}
