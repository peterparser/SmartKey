using NUnit.Framework;
using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartKey
{
    [TestFixture]
    class TestChiavetta
    {
        [TestCase]
        public void Test()
        {

            DriveInfo[] mydrives = DriveInfo.GetDrives();

            foreach (DriveInfo mydrive in mydrives)
            {
                if (mydrive.DriveType == DriveType.Removable)
                {
                    Utente.Dispositivo.Add(new ChiaveUSB(mydrive.Name));
                    // Te l'ho commentato perchè non compilava
                    foreach (DirectoryInfo dirInfo in mydrive.RootDirectory.GetDirectories())
                    {
                        //      Directory.CreateDirectory(mydrive.Name + Utente.GetNomeUtente());
                        // Nel ciclo itero su RootDirectory controllando se esiste la cartella E:/arian, se non esiste la creo
                        //Se esiste la rendo reperibile
                        // Console.WriteLine(mydrive.RootDirectory.ToString() + Utente.GetNomeUtente());

                        //Console.WriteLine(mydrive.RootDirectory.ToString());
                    }

                }

            }
          //  foreach (mydrive in Utente.Dispositivo)
            //{
                    
//            }
            foreach (IDispositivo disp in Utente.Dispositivo)
            {
                Console.WriteLine(disp.OttieniNomeDispositivo());
            }
        }
    }
}
