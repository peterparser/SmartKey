using SmartKey.DataPersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller.Controller.Interfaces
{
    public interface IPersistActions :IController
    {
         event EventHandler<PersistEvent> Persist;
    }
}
