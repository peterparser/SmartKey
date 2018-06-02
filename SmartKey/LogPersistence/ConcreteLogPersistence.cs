using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.ModelGestione;
using SmartKey.ModelLog;

namespace SmartKey.LogPersistence
{
    public class ConcreteLogPersistence : ILogPersistence
    {
        private readonly string _filename;
        private readonly bool _append;
        
        public ConcreteLogPersistence(string filename,bool append=false)
        {
            _filename = filename;
            _append = true;
        }
        public Log LeggiLog()
        {
            using (StreamReader readtext = new StreamReader(_filename))
            {
                string readMeText = readtext.ReadLine();
            }
            return null;
        }

        public void ScriviLog(Log log)
        {
            using (StreamWriter writer = new StreamWriter(_filename, append:_append))
            {
                foreach (Entry entry in log.Entries)
                {
                    writer.WriteLine(entry.ToString());
                }
            }
        }
    }
}
