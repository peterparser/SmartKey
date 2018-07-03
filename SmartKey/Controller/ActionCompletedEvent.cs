using SmartKey.Log.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller
{
   public class ActionCompletedEvent : EventArgs
    {
       public Entry ToEntry { get; set; }
    }
}
