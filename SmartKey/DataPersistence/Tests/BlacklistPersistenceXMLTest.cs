using NUnit.Framework;
using SmartKey.Blacklist;
using SmartKey.Controller;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.DataPersistence
{
    [TestFixture]
    class BlacklistPersistenceXMLTest
    {
        private const string PATH = @"C:\Users\massi\Desktop\blacklist.xml";
        [TestCase(Category = "BlacklistPersistence")]
        public void TestReadWriteXMLBlacklist()
        {
            //Crea correttamente le entry, precaricando la blacklist non inserisce duplicati
            XMLDataPersistence bpers = new XMLBlacklistPersistence(PATH);
            IGestoreBlacklist bcontr = new BlackListController();
            try
            {
                ISet<String> black = (ISet<string>)bpers.Carica();
                bcontr.SetBlackList(black);
            }
            catch (PersistenceException e)
            {

            }
            finally
            {
                ((IPersistActions)bcontr).Persist += bpers.Salva;
                bcontr.AggiungiUtente("AlCapone");
                bcontr.AggiungiUtente("Anonymous");
                bcontr.AggiungiUtente("NotMySelf");
                bcontr.RimuoviUtente("AlCapone");
                //Teoricamente il file dovrebbe esistere, lo leggo e testo che abbia effettivamente le entry giuste
                bcontr.SetBlackList((ISet<string>)bpers.Carica());
                Assert.IsTrue(bcontr.IsBlackListed("Anonymous"));
                Assert.IsTrue(bcontr.IsBlackListed("NotMySelf"));
                Assert.IsFalse(bcontr.IsBlackListed("AlCapone"));
            }
        }
    }
}
