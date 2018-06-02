using SmartKey.LogPersistence;
using SmartKey.ModelGestione;
using SmartKey.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller
{
    class LogController : IObserver
    {
        private ILogPersistence _logPersistence;
        private Log _log;
        public LogController()
        {
            _log = new Log();
            _logPersistence = new ConcreteLogPersistence("log.xml",true);
        }

        public void UpdateLog(object sender, EventArgs e)
        {
          
            ActionCompletedEvent param = (ActionCompletedEvent)e;
            Console.WriteLine(param.ToEntry);
            ScriviEntry(param.ToEntry);
        }
        private void ScriviEntry(Entry e)
        {
            _log.AddEntry(e);
        }
        public IList<Entry> Entries
        {
            get
            {
                return _log.Entries;
            }
        }
    }
}
