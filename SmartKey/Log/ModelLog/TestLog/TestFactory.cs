using NUnit.Framework;
using SmartKey.Controller;
using SmartKey.Log.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelLog.TestLog
{
    [TestFixture]
    class TestFactory
    {
        [TestCase]
        public void TestReturnType()
        {
            Entry entry = EntryFactory.CreateEntry(new ImpostazioneTrasferimento.ImpostazioneTrasferimentoController(), "ciao");
            Assert.IsInstanceOf(new EntryImpostazione("cioa", "mi", "u").GetType(), entry);
        }
    }
}
