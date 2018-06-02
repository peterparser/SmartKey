using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelLog
{
   public abstract class Entry
    {
        private string _operazione;
        private DateTime _dataOra;
        public Entry(string operazione)
        {
            _dataOra = DateTime.Now;
            _operazione = operazione;
        }

        public string Operazione
        {
            get
            {
                return _operazione;
            }
        }
        public DateTime DataOra
        {
            get
            {
                return _dataOra;
            }
        }
    }
}
