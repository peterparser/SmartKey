using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.Log.ModelLog
{
    public class EntryImpostazione : Entry
    {
        private string _sorgente;
        private string _destinatario;

        public EntryImpostazione(string operazione, string sorgente, string destinatario) : base(operazione)
        {
            _sorgente = sorgente;
            _destinatario = destinatario;

        }

        //Costruttore aggiunto per il parsing
        public EntryImpostazione(DateTime data, string operazione, string sorgente,
            string destinatario) : base(operazione, data)
        {
            _sorgente = sorgente;
            _destinatario = destinatario;
        }

        public string Sorgente
        {
            get
            {
                return _sorgente;
            }
        }
        public string Destinatario
        {
            get
            {
                return _destinatario;
            }
        }
        public override string ToString()
        {
            return "" + base.DataOra + "\t" +"Impostazione\t" + Operazione+"\t"+Utente.GetNomeUtente() + "\t"+Sorgente+"\t"+Destinatario;
        }
    }
}
