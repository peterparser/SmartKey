using NUnit.Framework;
using SmartKey.Blacklist;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ImpostazioneTrasferimento;
using SmartKey.Log.ControllerLog;
using SmartKey.Log.ModelLog;
using SmartKey.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller.TestController
{
    [TestFixture]
    class LogControllerTest
    {
        private IGestoreBlacklist listController;
        private IGestoreImpostazione impostazioneController;
        private IObserver logController;
        private void Init()
        {
            listController = new BlackListController();
            impostazioneController = new ImpostazioneTrasferimentoController();
            logController = new LogController(new HomeLog());
            //Registro gli eventi
            listController.ToLog += logController.Update;
            impostazioneController.ToLog += logController.Update;

        }

        [TestCase]
        public void TestLogImpostazione()
        {
            //Test che controlla che l'evento scatenato da add impostazione aggiunga una entry di tipo EntryImpostazione
            impostazioneController.AddImpostazione(new ImpostazioneTrasferimento.ImpostazioneTrasferimento("mydir", "yourdir"));
            Assert.That(logController.Entries[logController.Entries.Count - 1 ] is EntryImpostazione);
        }

        [TestCase]
        public void TestLogBlackList()
        {
            //Test che controlla che l'evento scatenato da aggiungiutente aggiunga una entry di tipo EntryBlacklist
            listController.AggiungiUtente("you");
            Assert.That(logController.Entries[logController.Entries.Count - 1] is EntryBlacklist);
        }

        
        
    }
}
