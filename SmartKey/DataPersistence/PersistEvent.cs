using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.DataPersistence
{
    public class PersistEvent : EventArgs
  
    {
        public object ToPersist { get; set; }
        public string Action { get; set; }
    }
}
