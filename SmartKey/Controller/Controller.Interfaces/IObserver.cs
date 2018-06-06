using SmartKey.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller.Controller.Interfaces
{
    public interface IObserver
    {
        void UpdateLog(object sender, EventArgs e);
    }
}
