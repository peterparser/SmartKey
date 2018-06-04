using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.ModelGestione;

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
        public abstract object Carica(Utente utente);
        public abstract void Salva(object o);
    }
}
