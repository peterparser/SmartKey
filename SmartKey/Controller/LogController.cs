using SmartKey.LogPersistence;
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
        public LogController()
        {
            _logPersistence = new ConcreteLogPersistence();
        }

        public void UpdateLog(object sender, EventArgs e)
        {
            ActionCompletedEvent param = (ActionCompletedEvent)e;
            Console.WriteLine(param.ToEntry);
        }
    }
}
