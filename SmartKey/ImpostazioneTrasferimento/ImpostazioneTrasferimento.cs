using SmartKey.ModelGestione;
using SmartKey.ModelGestione.Filesystem;
using SmartKey.ModelGestione.Filesystem.Filesystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ImpostazioneTrasferimento
{
   public  class ImpostazioneTrasferimento
    {
        private string _verso;
        private string _utente = Utente.GetUtente();
        private Cartella _cartellaSorgente;
        private string _cartellaDestinazione;

        
        public ImpostazioneTrasferimento(string cartellaSorgente, string cartellaDestinazione)
        {
            if(cartellaSorgente != null)
            {
                if(cartellaSorgente.Length < 261)
                {
                    _cartellaSorgente = new Cartella(cartellaSorgente);
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
        public Cartella CartellaSorgente
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
                    if(value.Path.Length > 260)
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
        public override bool Equals(object obj)
        {
            ImpostazioneTrasferimento otherSetting = (ImpostazioneTrasferimento)obj;
            return CartellaSorgente.Path.Equals(otherSetting.CartellaSorgente.Path) &&
                CartellaDestinazione.Equals(otherSetting.CartellaDestinazione);
        }

        public override int GetHashCode()
        {
            var hashCode = -2075503466;
            hashCode = hashCode * -1521134295 + EqualityComparer<Cartella>.Default.GetHashCode(_cartellaSorgente);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_cartellaDestinazione);
            return hashCode;
        }
    }
}
