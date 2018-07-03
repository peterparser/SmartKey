using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.Log.ModelLog;

namespace SmartKey.Log.LogPersistence
{
    public class ConcreteLogPersistence : ILogPersistence
    {
        private readonly string _filename;
        private readonly bool _append;
        
        public ConcreteLogPersistence(string filename,bool append=false)
        {
            _filename = filename;
            _append = true;
        }
        public ModelLog.Log LeggiLog()
        {
            ModelLog.Log log = new ModelLog.Log();
            try
            {
                using (StreamReader readtext = new StreamReader(_filename))
                {
                    string readMeText = readtext.ReadLine();
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
                    string utente = fields[3];

                    //Assegno i parametri che variano
                    switch (entryType)
                    {
                        case ("Blacklist"):
                            string badUser = fields[4];
                            log.AddEntry(EntryFactory.GetEntry(entryType, operazione, date, hour,
                                utenteMalevolo: badUser, utenteProprietario: "daaggiungere"));
                            break;
                        case ("Impostazione"):
                            string sorgente = fields[4];
                            string destinazione = fields[5];
                            log.AddEntry(EntryFactory.GetEntry(entryType, operazione, date, hour,
                                sorgente: sorgente, destinazione: destinazione));
                            break;
                    }


                    //Parte variabile Se impostazione ci sono le cartelle
                    //Se blacklist è finita

                }
            }catch(Exception e)
            {

            } 
            return log;
        }

        public void ScriviLog(ModelLog.Log log)
        {
            using (StreamWriter writer = new StreamWriter(_filename, append:_append))
            {
                foreach (Entry entry in log.Entries)
                {
                    writer.WriteLine(entry.ToString());
                }
            }
        }
    }
}
