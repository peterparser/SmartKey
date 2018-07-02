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
        [TestCase]
        public void TestNomeHost()
        {
            string me = Utente.GetUtente();
            Assert.AreEqual(me, WindowsIdentity.GetCurrent().Name.ToString());
        }
    }
}
