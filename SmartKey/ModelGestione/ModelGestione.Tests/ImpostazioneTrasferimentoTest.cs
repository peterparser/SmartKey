using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.ModelGestione.Tests
{
    [TestFixture]
    class ImpostazioneTrasferimentoTest
    {
        [TestCase]
        public void TestSetter()
        {
           
        }

        [TestCase]
        public void TestGetter()
        {
            ImpostazioneTrasferimento impostazione = new ImpostazioneTrasferimento("myDir", "yourDir");
            Assert.AreEqual(impostazione.CartellaSorgente, "myDir");
            Assert.AreEqual(impostazione.CartellaDestinazione, "yourDir");
        }

        [TestCase]
        public void TestVerso()
        {
            Assert.True(false);
        }
    }
}
