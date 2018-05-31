using NUnit.Framework;
using SmartKey.ModelGestione.Filesystem.Filesystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.ModelGestione;

namespace SmartKey.ModelGestione.ModelGestione.Tests
{
    [TestFixture]
    class ImpostazioneTrasferimentoTest
    {

        [TestCase]
        public void TestThrowNullConstructor()
        {
            Assert.Throws<PathNotValidException>(() => new ImpostazioneTrasferimento("", null));
            Assert.Throws<PathNotValidException>(() => new ImpostazioneTrasferimento(null, ""));
            Assert.Throws<PathNotValidException>(() => new ImpostazioneTrasferimento(null, null));
        }
        [TestCase]
        public void TestThrowLengthConstructor()
        {
            //TODO
        }
        [TestCase]
        public void TestThrowNullSetter()
        {
            // TODO
        }
        [TestCase]
        public void TestThrowLengthSetter()
        {
            //TODO
        }
        [TestCase]
        public void TestSetter()
        {
            ImpostazioneTrasferimento impostazione = new ImpostazioneTrasferimento("myDir", "yourDir");
            impostazione.CartellaDestinazione = "CambiamentoDestinazione";
            impostazione.CartellaSorgente = "CambiamentoSorgente";
            Assert.AreEqual(impostazione.CartellaDestinazione, "CambiamentoDestinazione");
            Assert.AreEqual(impostazione.CartellaSorgente, "CambiamentoSorgente");
        }

        [TestCase]
        public void TestGetter()
        {
            ImpostazioneTrasferimento impostazione = new ImpostazioneTrasferimento("myDir", "yourDir");
            Assert.AreEqual(impostazione.CartellaSorgente, "myDir");
            Assert.AreEqual(impostazione.CartellaDestinazione, "yourDir");
        }

       
    }
}
