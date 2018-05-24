using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace SmartKey.ModelGestione.Tests
{
    [TestFixture]
    class UtenteTest
    {
        //Test per verificare la correttezza del pattern Singleton
        [TestCase]
        public void TestSingleton()
        {
            Utente me = Utente.GetUtente();
            Utente you = Utente.GetUtente();
            Assert.AreSame(me, you);
        }

        [TestCase]
        public void TestNomeUtente()
        {
            Utente me = Utente.GetUtente();
            Assert.AreEqual(me.NomeUtente, WindowsIdentity.GetCurrent().User.ToString());
        } 
        
        [TestCase]
        public void TestNomeHost()
        {
            Utente me = Utente.GetUtente();
            Assert.AreEqual(me.NomeHost, WindowsIdentity.GetCurrent().Name.ToString());
        }
    }
}
