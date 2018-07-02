using NUnit.Framework;
using SmartKey.Blacklist;
using SmartKey.Controller.Controller.Interfaces;
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
        private void Init()
        {
            
            sincroController = new GestoreSincronizzazioneController(new BlackListController());
            impostazioni = new List<ImpostazioneTrasferimento.ImpostazioneTrasferimento>();
            impostazioni.Add(new ImpostazioneTrasferimento.ImpostazioneTrasferimento(@"C:\Users\massi\Desktop\prova", @"C:\Users\massi\Desktop\sincronizzato"));

        }
        [TestCase]
        public void TestDirCreation()
        {
            Init();
            sincroController.Sincronizza(impostazioni);
        }
    }
}
