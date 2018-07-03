using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace SmartKey.ModelGestione
{

    //Non può essere singleton
    //Va cambiato in modo che non sia singleton
    //Va fatto mettere in un controller poi farlo condividere.
    public class Utente
    {
        private IList<IDispositivo> _dispositivo;
        
        public static string GetNomeUtente()
        {
            return WindowsIdentity.GetCurrent().Name.ToString();
        }



        public IList<IDispositivo> Dispositivo
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
