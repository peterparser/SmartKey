using SmartKey.DataPersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller.Controller.Interfaces
{
    interface IPersistable
    {
        event EventHandler<PersistEvent> Persist;
    }
}
