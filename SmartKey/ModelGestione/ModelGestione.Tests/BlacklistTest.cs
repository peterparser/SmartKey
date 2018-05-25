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
            Blacklist list = new Blacklist();
            Assert.IsTrue(list.AggiungiUtenteCattivo("Massimo"));
           
        }

        [TestCase]
        public void TestEliminaBlacklist()
        {
            Blacklist list = new Blacklist();
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsTrue(list.EliminaUtenteCattivo("Massimo"));
        }

        [TestCase]
        public void TestIsInBlacklist()
        {
            Blacklist list = new Blacklist();
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsTrue(list.IsInBlacklist("Massimo"));

        }

        [TestCase]
        public void TestSetUnique()
        {
            Blacklist list = new Blacklist();
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsFalse(list.AggiungiUtenteCattivo("Massimo"));
        }

        [TestCase]
        public void TestRemovingUserNotInList()
        {
            Blacklist list = new Blacklist();
            list.AggiungiUtenteCattivo("Massimo");
            Assert.IsFalse(list.EliminaUtenteCattivo("Gianni"));
        }

        [TestCase]
        public void TestPopulateBySet()
        {
            HashSet<string> mySet = new HashSet<string>();
            mySet.Add("Massimo");
            mySet.Add("Gianni1");
            Blacklist blacklist = new Blacklist(mySet);
            Assert.IsTrue(blacklist.IsInBlacklist("Massimo"));
            Assert.IsTrue(blacklist.IsInBlacklist("Gianni1"));
        }

    }
}
