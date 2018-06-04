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
       
        [TestCase]
        public void TestReadXMLBlacklist()
        {
            XMLDataPersistence bPers = new XMLBlacklistPersistence(PATH);
            IGestoreBlacklist bcontr = new BlackListController();
            ISet<String> mySet = (ISet<String>)bPers.Carica(Utente.GetUtente());
            Assert.IsTrue(mySet.Contains("Al Capone"));
            Assert.IsTrue(mySet.Contains("Anonymous"));
            Assert.IsTrue(mySet.Contains("NotMyself"));
            Assert.IsFalse(mySet.Contains("Miciomao"));
        }
    }
}
