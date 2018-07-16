using NUnit.Framework;
using SmartKey.ModelGestione;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Da spostare in ChiaveUSBTest
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
                    DirectoryInfo dirInfoPrivata = new DirectoryInfo(mydrive.RootDirectory.ToString() + Utente.GetNomeUtente());
                    DirectoryInfo dirInfoPubblica = new DirectoryInfo(mydrive.RootDirectory.ToString() + "Cartella Pubblica");
                    
                    if (!dirInfoPrivata.Exists)
                    {
                        dirInfoPrivata.Create();
                        Console.WriteLine(dirInfoPrivata.ToString());
                    }
                    if (!dirInfoPubblica.Exists)
                    {
                        dirInfoPubblica.Create();
                        DirectoryInfo dirInfoPubblicaUtente = dirInfoPubblica.CreateSubdirectory(Utente.GetNomeUtente());
                        Console.WriteLine(dirInfoPubblica.ToString());
                        Console.WriteLine(dirInfoPubblicaUtente.ToString());

                    }
                    else
                    {
                       if(! Directory.Exists(mydrive.RootDirectory.ToString() + "Cartella Privata\\" + Utente.GetNomeUtente())){
                            dirInfoPubblica.CreateSubdirectory(Utente.GetNomeUtente());
                        }
                    }
                }
            }
            foreach (IDispositivo disp in Utente.Dispositivo)
            {
                Console.WriteLine(disp.OttieniNomeDispositivo());
            }
        }
    }
}
