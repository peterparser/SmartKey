using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.Log.ModelLog;
using SmartKey.ModelGestione;

namespace SmartKey.Log.LogPersistence
{
    public class ConcreteLogPersistence : ILogPersistence
    {
        private readonly string _filename;
        
        public ConcreteLogPersistence(string filename)
        {
            _filename = filename;
        }
        public ModelLog.Log LeggiLog()
        {
            ModelLog.Log log = new ModelLog.Log();
            try
            {
                using (StreamReader readtext = new StreamReader(_filename))
                {
                    string readMeText = null;
                    while ((readMeText = readtext.ReadLine()) != null)
                    { 
                        //  29 / 06 / 2018 09:14:20 Blacklist aggiunto DESKTOP-TF7TLNM\massi    riccardo 
                        //  29 / 06 / 2018 09:14:20 Impostazione aggiunta    DESKTOP - TF7TLNM\massi mydir   yourDir
                        //Esempio righe da parsare

                        //Parsing della parte fissa.
                        string[] fields = readMeText.Split('\t');
                        string[] dateHour = fields[0].Split(' ');
                        string date = dateHour[0];
                        string hour = dateHour[1];
                        string entryType = fields[1];
                        string operazione = fields[2];
                        if(fields.Length > 2)
                        {
                            string utente = fields[3];
                        }  
                        //Assegno i parametri che variano
                        switch (entryType)
                        {
                            case ("Sistema"):
                                log.AddEntry(EntryFactory.CreateEntry(entryType, operazione, date, hour));
                                break;
                            case ("Blacklist"):
                                string badUser = fields[4];
                                log.AddEntry(EntryFactory.CreateEntry(entryType, operazione, date, hour,
                                    utenteMalevolo: badUser, utenteProprietario: Utente.GetNomeUtente()));
                                break;
                            case ("Impostazione"):
                                string sorgente = fields[4];
                                string destinazione = fields[5];
                                log.AddEntry(EntryFactory.CreateEntry(entryType, operazione, date, hour,
                                    sorgente: sorgente, destinazione: destinazione));
                                break;
                            case ("Sincronizzazione"):
                                string source = fields[4];
                                if(operazione.Equals("file eliminato"))
                                {
                                    log.AddEntry(EntryFactory.CreateEntry(entryType, operazione, date, hour,
                                        sorgente:source));
                                }
                                else
                                {
                                    string dst = fields[5];
                                    log.AddEntry(EntryFactory.CreateEntry(entryType, operazione, date, hour,
                                        sorgente:source, destinazione:dst));
                                }
                                break;
                        }

                    }
                }
            }catch(Exception e)
            {

            } 
            return log;
        }

        public void ScriviLog(ModelLog.Log log)
        {
            using (StreamWriter writer = new StreamWriter(_filename, append:true))
            {
                writer.WriteLine(log.Entries.Last());
            }
        }
    }
}
