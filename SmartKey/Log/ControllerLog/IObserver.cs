using SmartKey.Log.ModelLog;
using SmartKey.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.ControllerLog
{
    //Itnerfaccia
    public interface IObserver
    {
        void Update(object sender, EventArgs e);
        IList<Entry> Entries { get; }
    }
}
