using SmartKey.Controller.Controller.Interfaces;
using SmartKey.Log.ModelLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Controller
{
    public class ProtezioneDatiController : IGestoreProtezioneDati
    {
        public event EventHandler<ActionCompletedEvent> ToLog;

        public void ProteggiCartella(string path)
        {
            if (!Directory.Exists(path))
            {

                ActionCompletedEvent args = new ActionCompletedEvent
                {
                    ToEntry = EntryFactory.CreateEntry(this, "protetta cartella "+path)
                };
                ToLog?.Invoke(this, args);
            }
        }
    }
}
