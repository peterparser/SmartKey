using SmartKey.ModelGestione.Filesystem.Filesystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelGestione
{
   public  class ImpostazioneTrasferimento
    {
        private string _verso;
        private Utente _utente = Utente.GetUtente();
        private string _cartellaSorgente;
        private string _cartellaDestinazione;


        public ImpostazioneTrasferimento(string cartellaSorgente, string cartellaDestinazione)
        {
            if(cartellaSorgente != null)
            {
                if(cartellaSorgente.Length < 261)
                {
                    _cartellaSorgente = cartellaSorgente;
                }
                else
                {
                    throw new PathNotValidException("Il path della cartella sorgente è troppo lungo");
                }
            }
            else
            {
                throw new PathNotValidException("Il path sorgente è nullo");
            }
            if (cartellaDestinazione != null)
            {
                if (cartellaDestinazione.Length < 261)
                {
                    _cartellaDestinazione = cartellaDestinazione;
                }
                else
                {
                    throw new PathNotValidException("Il path della cartella destinazione è troppo lungo");
                }
            }
            else
            {
                throw new PathNotValidException("Il path destinazione è nullo");
            }
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
            set
            {
                if(value == null)
                {
                    throw new PathNotValidException("Il path inserito come cartella sorgente è nullo");

                }
                else
                {
                    if(value.Length > 260)
                    {
                        throw new PathNotValidException("Il path inserito è troppo lungo");
                    }
                    else
                    {
                        _cartellaSorgente = value;
                    }
                }
            }
        }
        public string CartellaDestinazione
        {
            get
            {
                return _cartellaDestinazione;
            }
            set
            {
                if (value == null)
                {
                    throw new PathNotValidException("Il path inserito come cartella destinazione è nullo");

                }
                else
                {
                    if (value.Length > 260)
                    {
                        throw new PathNotValidException("Il path inserito come cartella destinazione troppo lungo");
                    }
                    else
                    {
                        _cartellaDestinazione = value;
                    }
                }
            }
        }
    }
}
