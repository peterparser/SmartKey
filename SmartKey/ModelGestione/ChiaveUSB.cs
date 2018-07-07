using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartKey.ModelGestione.Filesystem;

namespace SmartKey.ModelGestione
{
    class ChiaveUSB : IDispositivo
    {
        private DriveInfo _dispositivo;
        DriveInfo[] mydrives = DriveInfo.GetDrives();
        // Ho aggiunto un costruttore vuoto per ChiaveUSB così non appena apro l'applicazione 
        // l'utente aggiunge subito tra la sua lista di dispositivi la chiavetta
        public ChiaveUSB()
        {
            foreach (DriveInfo mydrive in mydrives)
            {
                if (mydrive.DriveType == DriveType.Removable)
                    Utente.Dispositivo.Add(new ChiaveUSB(mydrive.Name));
            }
        }

        public ChiaveUSB(string _nome)
        {
            _dispositivo = new DriveInfo(_nome);
        }

        //Forse conviene restituire una stringa
        //Dato che dobbiamo solo visualizzare il path
        // --> sì è meglio
        public string OttieniCartellaPrivata()
        {
            DirectoryInfo dirInfoPrivata = null;
           
            foreach (DriveInfo mydrive in mydrives)
            {
                    dirInfoPrivata = new DirectoryInfo(mydrive.RootDirectory.ToString() + Utente.GetNomeUtente());
                if (mydrive.DriveType == DriveType.Removable)
                {

                    if (!dirInfoPrivata.Exists)
                    {
                        dirInfoPrivata.Create();
                    }

                }
            }
            return dirInfoPrivata.ToString();
        }

        public String OttieniCartellaPubblica()
        {
            DirectoryInfo dirInfoPubblica = null;
            foreach (DriveInfo mydrive in mydrives)
            {
                dirInfoPubblica = new DirectoryInfo(mydrive.RootDirectory.ToString() + "Cartella Pubblica");
                if (mydrive.DriveType == DriveType.Removable)
                {
                    if (!dirInfoPubblica.Exists)
                    {
                        dirInfoPubblica.Create();
                        dirInfoPubblica.CreateSubdirectory(Utente.GetNomeUtente());

                    }
                    else
                    {
                        if (!Directory.Exists(mydrive.RootDirectory.ToString() + "Cartella Privata\\" + Utente.GetNomeUtente()))
                        {
                            dirInfoPubblica.CreateSubdirectory(Utente.GetNomeUtente());
                        }
                    }
                }
                   
            }
            return dirInfoPubblica.ToString();

        }

        public string OttieniNomeDispositivo()
        {
            return _dispositivo.VolumeLabel;
        }
    }
}
