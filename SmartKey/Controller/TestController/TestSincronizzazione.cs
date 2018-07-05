using NUnit.Framework;
using SmartKey.Blacklist;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.Log.ControllerLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller.TestController
{
    [TestFixture]
    class TestSincronizzazione
    {
        private IGestoreSincronizzazione sincroController;
        private IList<ImpostazioneTrasferimento.ImpostazioneTrasferimento> impostazioni;
        private IObserver gestoreLog;
        private void Init()
        {
            gestoreLog = new LogController(new HomeLog());
            sincroController = new GestoreSincronizzazioneController(new BlackListController(new HomeBlacklist()));
            sincroController.ToLog += gestoreLog.Update;
            impostazioni = new List<ImpostazioneTrasferimento.ImpostazioneTrasferimento>();
            impostazioni.Add(new ImpostazioneTrasferimento.ImpostazioneTrasferimento(@"C:\Users\massi\Desktop\prova", @"C:\Users\massi\Desktop\sincronizzato"));

        }
        [TestCase]
        public void TestDirCreation()
        {
            Init();
            sincroController.Sincronizza(impostazioni);
            //Verificare se esistono i file copiati
            //Va codificato, però il metodo funziona
        }
    }
}
