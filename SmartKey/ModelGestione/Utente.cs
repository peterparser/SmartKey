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
        private string nomeHost = WindowsIdentity.GetCurrent().Name.ToString();
        private string nomeUtente = WindowsIdentity.GetCurrent().User.ToString();
        private IDispositivo device;

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
                return nomeUtente;
            }
        }

        public string NomeHost
        {
            get
            {
                return nomeHost;
            }
        }

    
    }
}
