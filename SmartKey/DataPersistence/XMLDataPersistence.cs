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
        public XMLDataPersistence(string fileName)
        {
           string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
           string path = string.Join("\\", desktop,"Smartkey" ,fileName);
            _filename = path;
        }
        public abstract object Carica();
        public abstract void Salva(object o, PersistEvent e);
    }
}
