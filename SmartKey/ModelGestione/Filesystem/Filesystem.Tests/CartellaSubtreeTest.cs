using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.Filesystem.Filesystem.Tests
{
    [TestFixture]
    public class CartellaSubtreeTest
    {

        //Usato per fare il debug del costruttore, ricrea tutto a meraviglia
        [TestCase]
        public void TestPopolamento()
        {
            Cartella  dir = new Cartella(@"C:\Users\massi\Desktop\prova");
            Console.WriteLine(dir);
        }
    }
}
