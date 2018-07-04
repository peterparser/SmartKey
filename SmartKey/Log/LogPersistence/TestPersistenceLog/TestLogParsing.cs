using NUnit.Framework;
using SmartKey.Blacklist;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ImpostazioneTrasferimento;
using SmartKey.Log.ControllerLog;
using SmartKey.Log.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.LogPersistence.TestPersistenceLog
{
    [TestFixture]
    class TestLogParsing
    {
        private IController impostazioneController;
        private IObserver logController;
        private IController blacklistController;

        private void Init()
        {
            blacklistController = new BlackListController(new HomeBlacklist());
            impostazioneController = new ImpostazioneTrasferimentoController();
            logController = new LogController(new HomeLog());
            impostazioneController.ToLog += logController.Update;
            blacklistController.ToLog += logController.Update;

        }

        //Testata e funzionante
        [TestCase]
        public void TestParsingImpostazione()
        {
            Init();      
            //Prendo la entry che ho appena scritto
            Entry scritta = logController.Entries[0];
            if(scritta is EntryImpostazione)
            {
                EntryImpostazione  impostazioneEntry = (EntryImpostazione)scritta;
                Assert.IsTrue(impostazioneEntry.Destinatario.Equals("yourDir"));
                Assert.IsTrue(impostazioneEntry.Sorgente.Equals("mydir"));
            }
        }

        [TestCase]
        public void TestParsingBlacklist()
        {
            Init();
            Entry scritta = logController.Entries[0];
            if(scritta is EntryBlacklist)
            {

            }
        }
    }
}
