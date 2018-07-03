using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.DataPersistence
{
    public abstract class XMLDataPersistence :IDataPersistence
    {
        private readonly string _filename;
        public string Filename
        {
            get
            {
                return _filename;
            }
        }
        public XMLDataPersistence(string filename)
        {
            _filename = filename;
        }
        public abstract object Carica();
        public abstract void Salva(object o, PersistEvent e);
    }
}
