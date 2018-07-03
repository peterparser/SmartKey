using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.Blacklist;

namespace SmartKey.ModelGestione.ModelGestione.Tests
{
    [TestFixture]
    class BlacklistTest
    {
        [TestCase]
        public void TestAggiungiBlacklist()
        {
            Blacklist.Blacklist list = Blacklist.Blacklist.Instance;
            Assert.IsTrue(list.AggiungiUtenteCattivo("Massimo"));
           
        }
        
        [TestCase]
        public void TestSingletonBlacklist()
        {
            Blacklist.Blacklist list1 = Blacklist.Blacklist.Instance;
            Blacklist.Blacklist list2 = Blacklist.Blacklist.Instance;
            Assert.AreSame(list1, list2);
        }

        [TestCase]
        public void TestEliminaBlacklist()
        {
            Blacklist.Blacklist list = Blacklist.Blacklist.Instance;
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsTrue(list.EliminaUtenteCattivo("Massimo"));
        }

        [TestCase]
        public void TestIsInBlacklist()
        {
            Blacklist.Blacklist list = Blacklist.Blacklist.Instance;
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsTrue(list.IsInBlacklist("Massimo"));

        }

        [TestCase]
        public void TestBlacklistSetUnique()
        {
            Blacklist.Blacklist list = Blacklist.Blacklist.Instance;
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsFalse(list.AggiungiUtenteCattivo("Massimo"));
        }

        [TestCase]
        public void TestRemovingUserNotInBlackList()
        {
            Blacklist.Blacklist list = Blacklist.Blacklist.Instance;
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsFalse(list.EliminaUtenteCattivo("Gianni"));
        }

        [TestCase]
        public void TestPopulateBlacklistBySet()
        {
            HashSet<string> mySet = new HashSet<string>();
            mySet.Add("Massimo");
            mySet.Add("Gianni1");
            Blacklist.Blacklist blacklist = Blacklist.Blacklist.Instance;
            blacklist.Utenti = mySet;
            Assert.IsTrue(blacklist.IsInBlacklist("Massimo"));
            Assert.IsTrue(blacklist.IsInBlacklist("Gianni1"));
        }

    }
}
