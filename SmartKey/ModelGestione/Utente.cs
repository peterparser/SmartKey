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
        public static string GetNomeUtente()
        {
            return Environment.UserName;
        }

        public static string GetNomeHost()
        {
            return Environment.MachineName;
        }

        public static IList<IDispositivo> Dispositivo { get; } = new List<IDispositivo>();
    }
}
