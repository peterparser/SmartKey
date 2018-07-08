using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.DataPersistence
{
    interface IDataPersistence
    {
       object Carica();
       void Salva(object o, PersistEvent e);
    }
}
