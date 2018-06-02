using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller
{
    class LogController : IObserver
    {
        //Test
        public int Count { get; set; }
        public void UpdateLog(object sender, EventArgs e)
        {
            ActionCompletedEvent param = (ActionCompletedEvent)e;
            Console.WriteLine(param.Action);
            Count = 10;
        }
    }
}
