using NUnit.Framework;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller.TestController
{
    [TestFixture]
    class TestImpostazioniController
    {
        [TestCase]
        public void TestLogInvocationAddImpostazione()
        {
            LogController log = new LogController();
            IGestoreImpostazione cont = new ImpostazioneTrasferimentoController();
            //Aggancio l'evento
            cont.ToLog += log.UpdateLog;
            cont.AddImpostazione(new ImpostazioneTrasferimento("sorgente", "destinazione"));
            //Se l'invocazione è andata a buon fine e l'evento ha fatto il suo lavoro
            //Dovrebbe essere presente una riga sul file di log
            Assert.AreEqual(log.Entries.ElementAt(0).Operazione, "aggiunta");
        }

        [TestCase]
        public void TestLogInvocationRemImpostazione()
        {
            LogController log = new LogController();
            IGestoreImpostazione cont = new ImpostazioneTrasferimentoController();
            //Aggancio l'evento
            cont.ToLog += log.UpdateLog;
            ImpostazioneTrasferimento imp = new ImpostazioneTrasferimento("sorgente", "destinazione");
            cont.AddImpostazione(imp);
            //Se l'invocazione è andata a buon fine il contatore è aumentato
            //Controllo che la rimozione avvenga con successo
            Assert.IsTrue(cont.RemoveImpostazione(imp));
            //Controllo che nel log sia presente la rimozione quindi che l'evento abbia lavorato
            Assert.AreEqual(log.Entries.ElementAt(1).Operazione, "rimossa");
        }
    }
}
