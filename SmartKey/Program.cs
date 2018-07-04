using SmartKey.ImpostazioneTrasferimento;
using SmartKey.Log.ControllerLog;
using SmartKey.ModelGestione;
using SmartKey.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartKey
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]

     
        static void Main()
        {
            
            DriveInfo[] mydrives = DriveInfo.GetDrives();

            foreach (DriveInfo mydrive in mydrives)
            {               
                if (mydrive.DriveType == DriveType.Removable)
                {
                    Utente.Dispositivo.Add(new ChiaveUSB(mydrive.Name));
                    foreach(DirectoryInfo dirInfo in )
                    Console.WriteLine(mydrive.RootDirectory.GetDirectories().GetValue(2).ToString());
                    Console.WriteLine(mydrive.RootDirectory.ToString() + Utente.GetNomeUtente());
                    
                    Console.WriteLine(mydrive.RootDirectory.ToString());
                    
                }
           
            }
            foreach( mydrive in Utente.Dispositivo)
            {

            }
            foreach (IDispositivo disp in Utente.Dispositivo)
            {
                Console.WriteLine(disp.OttieniNomeDispositivo());
            }
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NavigationHelper helper = new NavigationHelper();
            helper.AgganciaHandlers();
            ImpostazioneTrasferimentoController impostazioniController = new ImpostazioneTrasferimentoController((HomeImpostazioni)(helper.GetForm("HomeImpostazioni")));
            LogController logController = new LogController((HomeLog)(helper.GetForm("HomeLog")));
            Application.Run(helper.GetForm("HomeSmartKey"));


        }



           
    }
}
