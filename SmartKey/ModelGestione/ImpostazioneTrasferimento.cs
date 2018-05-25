using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione
{
    class ImpostazioneTrasferimento
    {
        private string _verso;
        private Utente _utente = Utente.GetUtente();
        private string _cartellaSorgente;
        private string _cartellaDestinazione;


        public ImpostazioneTrasferimento(string cartellaSorgente, string CartellaDestinazione)
        {
            _cartellaSorgente = cartellaSorgente;
            _cartellaDestinazione = CartellaDestinazione;
        }

        public string Verso
        {
            get
            {
                return _verso;
            }
            set
            {
                _verso = value;
            }
        }
        public string CartellaSorgente
        {
            get
            {
                return _cartellaSorgente;
            }
        }
        public string CartellaDestinazione
        {
            get
            {
                return _cartellaDestinazione;
            }
        }
    }
}
