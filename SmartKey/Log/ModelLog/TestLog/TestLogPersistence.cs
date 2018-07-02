using NUnit.Framework;
using SmartKey.Blacklist;
using SmartKey.Controller;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ImpostazioneTrasferimento;
using SmartKey.Log.ControllerLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.TestLog
{
    [TestFixture]
    class TestLogPersistence
    {
        private IController impostazioneController;
        private IObserver logController;
        private IController blacklistController;

        private void Init()
        {
            blacklistController = new BlackListController();
            impostazioneController = new ImpostazioneTrasferimentoController();
            logController = new LogController();
            impostazioneController.ToLog += logController.UpdateLog;
            blacklistController.ToLog += logController.UpdateLog;

        }

        [TestCase]
        public void TestScritturaImpostazione()
        {
            Init();
            ((IGestoreImpostazione)impostazioneController).AddImpostazione(new ImpostazioneTrasferimento.ImpostazioneTrasferimento("mydir", "yourDir"));
        }

        [TestCase]
        public void TestScritturaBlacklist()
        {
            Init();
            ((IGestoreBlacklist)blacklistController).AggiungiUtente("riccardo");
        }
    }
}
