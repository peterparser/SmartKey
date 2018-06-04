using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelLog
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
            return "" + base.DataOra + "\t" + UtenteMalevolo + "\t" + UtenteProprietario;
        }
    }
}
