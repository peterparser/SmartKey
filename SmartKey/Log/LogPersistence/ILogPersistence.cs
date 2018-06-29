using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.LogPersistence
{
    interface ILogPersistence
    {
        void ScriviLog(ModelLog.Log log);
        ModelLog.Log LeggiLog();
    }
}
