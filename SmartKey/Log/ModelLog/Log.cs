using SmartKey.ModelLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.ModelLog
{
    public class Log
    {
        IList<Entry> _entries;
        public Log()
        {
            _entries = new List<Entry>();
        }
        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }
        public IList<Entry> Entries
        {
            get
            {
                return _entries;
            }
            set
            {
                _entries = value;
            }
        }
    }
}
