using SmartKey.Controller.Controller.Interfaces;
using SmartKey.ModelGestione;
using System;

namespace SmartKey.Log.ModelLog
{
    public class EntryFactory
    {
        public static Entry GetEntry(IController controller, string operazione, 
            string utenteMalevolo="" ,string sorgente="", string destinazione="")
        {
            
            Type tipo = controller.GetType();
            switch (tipo.Name)
            {
                case ("ImpostazioneTrasferimentoController"):
                    return new EntryImpostazione(operazione, sorgente, destinazione);
                case ("BlackListController"):
                    return new EntryBlacklist(operazione, Utente.GetUtente(), utenteMalevolo);
                case ("GestoreSincronizzazioneController"):
                    return new EntrySincronizzazione(operazione, sorgente, destinazione);
                default:
                    return null;
            }
            //TODO bisogna implementare le altre entry
               
            
        }
        //Metodo da usare per ricostruire le entry dal file di log
        public static Entry GetEntry(string entryType, string operazione,
            string dataString, string oraString,
            string utenteMalevolo="",string utenteProprietario="", string sorgente="", string destinazione = "")
        {
            //Parsing della data
            string[] dateFields = dataString.Split('/');
            int giorno = Int32.Parse(dateFields[0]);
            int mese = Int32.Parse(dateFields[1]);
            int anno = Int32.Parse(dateFields[2]);

            string[] hourFields = oraString.Split(':');
            int ora = Int32.Parse(hourFields[0]);
            int minuti = Int32.Parse(hourFields[1]);
            int secondi = Int32.Parse(hourFields[2]);

            DateTime entryTime = new DateTime(anno, mese, giorno, ora, minuti, secondi);
            //TODO da implementare il parsing del log
            switch (entryType)
            {
                case ("Blacklist"):
                    return new EntryBlacklist(entryTime, operazione, utenteProprietario, utenteMalevolo);
                case ("Impostazione"):
                    return new EntryImpostazione(entryTime, operazione, sorgente, destinazione);
                default:
                    return null;
            }
        }
    }
}
