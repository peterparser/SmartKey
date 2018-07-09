using SmartKey.Blacklist;
using SmartKey.Controller;
using SmartKey.Controller.Controller.Interfaces;
using SmartKey.DataPersistence;
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
            // Creo subito all'inizio un'istanza così l'utente ha già tutto
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Creazione cartella dove depositiamo le impostazioni
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = string.Join("\\", desktop, "Smartkey");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            ChiaveUSB chiavetta = new ChiaveUSB();
            NavigationHelper helper = new NavigationHelper();
           
            helper.AgganciaHandlers();
            IGestoreImpostazione impostazioniController = 
                new ImpostazioneTrasferimentoController((HomeImpostazioni)(helper.GetForm("HomeImpostazioni")));

            IGestoreBlacklist blacklistController = new BlackListController((HomeBlacklist)(helper.GetForm("HomeBlacklist")));
            InitControllers initializer = new InitControllers();
       
            initializer.Init(blacklistController, impostazioniController);
            IGestoreSincronizzazione sincroController = new GestoreSincronizzazioneController(blacklistController,
                impostazioniController,(HomeSmartKey) helper.GetForm("HomeSmartKey"));
            LogController logController = new LogController((HomeLog)(helper.GetForm("HomeLog")));
            ProtezioneDatiController protect = new ProtezioneDatiController(chiavetta.OttieniCartellaPrivata());
            protect.ProteggiCartella();

            protect.ToLog += logController.Update;
            blacklistController.ToLog += logController.Update;
            impostazioniController.ToLog += logController.Update;
            sincroController.ToLog += logController.Update;

            Application.Run(helper.GetForm("HomeSmartKey"));
          
        }
    }
}
