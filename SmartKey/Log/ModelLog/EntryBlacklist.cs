using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.ModelLog
{
    public class EntryBlacklist : Entry
    {
        private string _utenteProprietario;
        private string _utenteMalevolo;
        
        public EntryBlacklist(string operazione, string utenteProprietario,
            string utenteMalevolo): base(operazione)
        {
            _utenteProprietario = utenteProprietario;
            _utenteMalevolo = utenteMalevolo;
        }
        public string UtenteProprietario
        {
            get
            {
                return _utenteProprietario;
            }
        }
        public string UtenteMalevolo
        {
            get
            {
                return _utenteMalevolo;
            }
        }
        public override string ToString()
        {
            return "" + base.DataOra +"\tBlacklist\t"+ Operazione+"\t"+ UtenteMalevolo + "\t" + UtenteProprietario;
        }
    }
}
