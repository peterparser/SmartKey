using SmartKey.Controller;
using SmartKey.Log.LogPersistence;
using SmartKey.Log.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.ControllerLog
{
    public class LogController : IObserver
    {
        private ILogPersistence _logPersistence;
        private ModelLog.Log _log;

        public LogController()
        {
            _logPersistence = new ConcreteLogPersistence("C:\\Users\\massi\\Desktop\\log.txt", true);
            _log = _logPersistence.LeggiLog();
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
