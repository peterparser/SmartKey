using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione.ModelGestione.Tests
{
    [TestFixture]
    class BlacklistTest
    {
        [TestCase]
        public void TestAggiungiBlacklist()
        {
            Blacklist list = Blacklist.Instance;
            Assert.IsTrue(list.AggiungiUtenteCattivo("Massimo"));
           
        }
        
        [TestCase]
        public void TestSingletonBlacklist()
        {
            Blacklist list1 = Blacklist.Instance;
            Blacklist list2 = Blacklist.Instance;
            Assert.AreSame(list1, list2);
        }

        [TestCase]
        public void TestEliminaBlacklist()
        {
            Blacklist list = Blacklist.Instance;
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsTrue(list.EliminaUtenteCattivo("Massimo"));
        }

        [TestCase]
        public void TestIsInBlacklist()
        {
            Blacklist list = Blacklist.Instance;
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsTrue(list.IsInBlacklist("Massimo"));

        }

        [TestCase]
        public void TestBlacklistSetUnique()
        {
            Blacklist list = Blacklist.Instance;
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsFalse(list.AggiungiUtenteCattivo("Massimo"));
        }

        [TestCase]
        public void TestRemovingUserNotInBlackList()
        {
            Blacklist list = Blacklist.Instance;
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsFalse(list.EliminaUtenteCattivo("Gianni"));
        }

        [TestCase]
        public void TestPopulateBlacklistBySet()
        {
            HashSet<string> mySet = new HashSet<string>();
            mySet.Add("Massimo");
            mySet.Add("Gianni1");
            Blacklist blacklist = Blacklist.Instance;
            blacklist.SetUtenti = mySet;
            Assert.IsTrue(blacklist.IsInBlacklist("Massimo"));
            Assert.IsTrue(blacklist.IsInBlacklist("Gianni1"));
        }

    }
}
