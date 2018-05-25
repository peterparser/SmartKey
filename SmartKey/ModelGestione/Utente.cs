using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
namespace SmartKey.ModelGestione
{
    public sealed class Utente
    {
        private static Utente _instance;
        private string _nomeHost = WindowsIdentity.GetCurrent().Name.ToString();
        private string _nomeUtente = WindowsIdentity.GetCurrent().User.ToString();
        private IDispositivo _dispositivo;

        private Utente()
        {

        }

        public static Utente GetUtente()
        {
            if(_instance == null)
            {
                _instance = new Utente();

            }
            return _instance;
        }

        public string NomeUtente
        {
            get
            {
                return _nomeUtente;
            }
        }

        public string NomeHost
        {
            get
            {
                return _nomeHost;
            }
        }

        public IDispositivo Dispositivo
        {
            get
            {
                return _dispositivo;
            }
            set
            {
                _dispositivo = value;
            }
        }

    
    }
}
