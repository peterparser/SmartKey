using NUnit.Framework;
using SmartKey.ModelGestione.Filesystem.Filesystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.Filesystem.Filesystem.Tests
{
    [TestFixture]
    class CartellaTest
    {
        //Questa stringa effettua il test sugli input
        //Se passata al costruttore, dovrebbe lanciare eccezione
        private readonly string _veryLongPath = "aaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaaaaa";


        //Test del costruttore dell'oggetto cartella
        [TestCase]
        public void TestCartellaConstructor()
        {
            Cartella c = new Cartella("ABC");
            Assert.AreNotEqual(c, null);
            Assert.AreEqual(c.Path, "ABC"); 
        }
        //Test che controlla che se il path supera 260 caratteri viene lanciata eccezione
        [TestCase]
        public void TestCartellaPathLength()
        {
            Cartella c = new Cartella("ABC");
            Assert.Throws<PathNotValidException>(() => c.Path = _veryLongPath);
            
        }

        //Test che controlla che la funzione removechild funzioni correttamente
        //e rimuova l'elemento specificato dalla lista
        [TestCase]
        public void TestCartellaRemoveChild()
        {
            Cartella home = new Cartella("ABC");
            Cartella subHome = new Cartella("KDE");
            home.AddChild(subHome);
            FilesystemElement toTest = home.GetChild("KDE");
            Assert.AreSame(subHome, toTest);
            home.RemoveChild(toTest);
            toTest = home.GetChild("KDE");
            Assert.That(toTest == null);
        }

        //Test che controlla che venga aggiunto l'elemento specificato alla
        //Lista di figli di quella cartella.
        [TestCase]
        public void TestCartellaAddChild()
        {
            Cartella home = new Cartella("ABC");
            Cartella subHome = new Cartella("KDE");
            home.AddChild(subHome);
            FilesystemElement toTest = home.GetChild("KDE");
            Assert.AreSame(subHome, toTest);
        }
    }
}
