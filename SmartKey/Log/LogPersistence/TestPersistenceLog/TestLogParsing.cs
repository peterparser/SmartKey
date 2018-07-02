using NUnit.Framework;
using SmartKey.Blacklist;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ImpostazioneTrasferimento;
using SmartKey.Log.ControllerLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.ModelLog.TestLog
{
    [TestFixture]
    class TestLogParsing
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
        public void TestParsingImpostazione()
        {
            ((IGestoreImpostazione)impostazioneController).AddImpostazione(
               new ImpostazioneTrasferimento.ImpostazioneTrasferimento("mydir", "yourDir"));
            //Prendo la entry che ho appena scritto
            Entry scritta = logController.Entries[0];
            if(scritta is EntryImpostazione)
            {
                EntryImpostazione  impostazioneEntry = (EntryImpostazione)scritta;
                Assert.IsTrue(impostazioneEntry.Destinatario.Equals("yourDir"));
                Assert.IsTrue(impostazioneEntry.Sorgente.Equals("mydir"));
            }
        }

    }
}
