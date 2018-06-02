using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelLog
{
    public class EntryFactory
    {
        public static Entry GetEntry(Controller.IController controller, string operazione, string sorgente="", string destinazione="")
        {
            Type tipo = controller.GetType();
            switch (tipo.ToString())
            {
                case ("ImpostazioneTrasferimentoController"):
                    return new EntryImpostazione(operazione, sorgente, destinazione);
                default:
                    return null;
            }
        }
    }
}
