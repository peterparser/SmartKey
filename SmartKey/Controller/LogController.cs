using SmartKey.Controller.Controller.Interfaces;
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
            _logPersistence = new ConcreteLogPersistence("log.txt",true);
        }

        public void UpdateLog(object sender, EventArgs e)
        {
          
            ActionCompletedEvent param = (ActionCompletedEvent)e;
            _log.AddEntry(param.ToEntry);
            _logPersistence.ScriviLog(_log);
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
