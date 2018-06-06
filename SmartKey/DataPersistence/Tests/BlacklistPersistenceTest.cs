using NUnit.Framework;
using SmartKey.Controller;
using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.DataPersistence
{
    [TestFixture]
    class BlacklistPersistenceTest
    {
        private const string PATH = @"C:\Users\massi\Desktop\blacklist.xml";
        [TestCase(Category ="BlacklistPersistence")]
        public void TestWriteXMLBlacklist()
        {
            XMLDataPersistence bpers = new XMLBlacklistPersistence(PATH);
            IGestoreBlacklist bcontr = new BlackListController();
            bcontr.AggiungiUtente("AlCapone");
            bcontr.AggiungiUtente("Anonymous");
            bcontr.AggiungiUtente("NotMySelf");
            bpers.Salva(bcontr.GetUtentiInBlackList());

        }

        [TestCase(Category = "BlacklistPersistence")]
        public void TestReadXMLBlacklist()
        {
            XMLDataPersistence bPers = new XMLBlacklistPersistence(PATH);
            IGestoreBlacklist bcontr = new BlackListController();
            ISet<String> mySet = (ISet<String>)bPers.Carica(Utente.GetUtente());
            Assert.IsTrue(mySet.Contains("AlCapone"));
            Assert.IsTrue(mySet.Contains("Anonymous"));
            Assert.IsTrue(mySet.Contains("NotMySelf"));
            Assert.IsFalse(mySet.Contains("Miciomao"));
        }

        [TestCase(Category = "BlacklistPersistence")]
        public void TestModifyXMLBlacklist()
        {
            XMLDataPersistence bPers = new XMLBlacklistPersistence(PATH);
            IGestoreBlacklist bcontr = new BlackListController();
            ISet<String> mySet = (ISet<String>)bPers.Carica(Utente.GetUtente());
            bcontr.SetBlackList(mySet);
            bcontr.AggiungiUtente("MIAO");
            bPers.Salva(bcontr.GetUtentiInBlackList());
            mySet = (ISet<String>)bPers.Carica(Utente.GetUtente());
            Assert.IsTrue(mySet.Contains("MIAO"));
        }
    }
}
