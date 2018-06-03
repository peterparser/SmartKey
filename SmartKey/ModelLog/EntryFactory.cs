using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey.ModelLog
{
    public class EntryFactory
    {
        public static Entry GetEntry(Controller.IController controller, string operazione, string utenteMalevolo="" ,string sorgente="", string destinazione="")
        {
            
            Type tipo = controller.GetType();
            switch (tipo.Name)
            {
                case ("ImpostazioneTrasferimentoController"):
                    return new EntryImpostazione(operazione, sorgente, destinazione);
                case ("BlackListController"):
                    return new EntryBlacklist(operazione, Utente.GetUtente().NomeHost, utenteMalevolo);
                default:
                    return null;
            }
            //TODO bisogna implementare le altre entry
               
            
        }
    }
}
