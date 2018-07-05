using SmartKey.Controller.Controller.Interfaces;
using SmartKey.DataPersistence;
using SmartKey.ImpostazioneTrasferimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller
{
    public class InitControllers
    {
        private Dictionary<string, IDataPersistence> _persisters;

        public InitControllers()
        {
            _persisters = new Dictionary<string, IDataPersistence>
            {
                { "impostazioni", new XMLImpostazioniPersistence()},
                { "blacklist", new XMLBlacklistPersistence() }
            };
        }
        public void Init(IGestoreBlacklist blacklist, IGestoreImpostazione impostazioni)
        {
            InitBlacklist(blacklist);
            InitImpostazioni(impostazioni);
        }

        private void InitBlacklist(IGestoreBlacklist blacklist)
        {
            ISet<String> blacklisted = (ISet<String>) GetPersister("blacklist").Carica();
            blacklist.SetBlackList(blacklisted);
            blacklist.Persist += GetPersister("blacklist").Salva;
        }

        private void InitImpostazioni(IGestoreImpostazione impostazioni)
        {
            ISet <ImpostazioneTrasferimento.ImpostazioneTrasferimento > imps =
                (ISet<ImpostazioneTrasferimento.ImpostazioneTrasferimento>)GetPersister("impostazioni").Carica();
            impostazioni.SetImpostazioni(imps);
            impostazioni.Persist += GetPersister("impostazioni").Salva;
        }

        private IDataPersistence GetPersister(string name)
        {
            _persisters.TryGetValue(name, out IDataPersistence toOut);
            return toOut;
        }

    }
}
