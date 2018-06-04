using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.LogPersistence
{
    interface ILogPersistence
    {
        void ScriviLog(Log log);
        Log LeggiLog();
    }
}
