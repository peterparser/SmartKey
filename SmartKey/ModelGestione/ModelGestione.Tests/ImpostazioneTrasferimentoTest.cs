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
        private readonly string _veryLongElement = "aaaaaaaaaaaaaaaaaaaaa" +
          "aaaaaaaaaaaaaaaaaaaaaaaaaa" +
          "aaaaaaaaaaaaaaaaaaaaaaaaaaa" +
          "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
          "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
          "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
          "aaaaaaaaaaaaaaaaaaaaaaaaaa" +
          "aaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
          "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
          "aaaaaaaaaaaaaaaaaaaaaaa";

        [TestCase]
        public void TestImpostazioneThrowNullConstructor()
        {
            Assert.Throws<PathNotValidException>(() => new ImpostazioneTrasferimento("", null));
            Assert.Throws<PathNotValidException>(() => new ImpostazioneTrasferimento(null, ""));
            Assert.Throws<PathNotValidException>(() => new ImpostazioneTrasferimento(null, null));
        }
        [TestCase]
        public void TestImpostazioneThrowLengthConstructor()
        {
            Assert.Throws<PathNotValidException>(() => new ImpostazioneTrasferimento(_veryLongElement, ""));
            Assert.Throws<PathNotValidException>(() => new ImpostazioneTrasferimento("", _veryLongElement));
            Assert.Throws<PathNotValidException>(() => new ImpostazioneTrasferimento(_veryLongElement, _veryLongElement));
        }
        [TestCase]
        public void TestImpostazioneThrowNullSetter()
        {
            ImpostazioneTrasferimento impostazione = new ImpostazioneTrasferimento("folderS", "folderD");
            Assert.Throws<PathNotValidException>(() => impostazione.CartellaDestinazione = null);
            Assert.Throws<PathNotValidException>(() => impostazione.CartellaSorgente = null);
        }
        [TestCase]
        public void TestImpostazioneThrowLengthSetter()
        {
            ImpostazioneTrasferimento impostazione = new ImpostazioneTrasferimento("folderS", "folderD");
            Assert.Throws<PathNotValidException>(() => impostazione.CartellaDestinazione = _veryLongElement);
            Assert.Throws<PathNotValidException>(() => impostazione.CartellaSorgente = _veryLongElement);
        }
        [TestCase]
        public void TestImpostazioneSetter()
        {
            ImpostazioneTrasferimento impostazione = new ImpostazioneTrasferimento("myDir", "yourDir");
            impostazione.CartellaDestinazione = "CambiamentoDestinazione";
            impostazione.CartellaSorgente = "CambiamentoSorgente";
            Assert.AreEqual(impostazione.CartellaDestinazione, "CambiamentoDestinazione");
            Assert.AreEqual(impostazione.CartellaSorgente, "CambiamentoSorgente");
        }

        [TestCase]
        public void TestImpostazioneGetter()
        {
            ImpostazioneTrasferimento impostazione = new ImpostazioneTrasferimento("myDir", "yourDir");
            Assert.AreEqual(impostazione.CartellaSorgente, "myDir");
            Assert.AreEqual(impostazione.CartellaDestinazione, "yourDir");
        }

       
    }
}
