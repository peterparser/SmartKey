﻿using SmartKey.Blacklist;
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NavigationHelper helper = new NavigationHelper();
            helper.AgganciaHandlers();
            IGestoreImpostazione impostazioniController = 
                new ImpostazioneTrasferimentoController((HomeImpostazioni)(helper.GetForm("HomeImpostazioni")));

            IGestoreBlacklist blacklistController = new BlackListController((HomeBlacklist)(helper.GetForm("HomeBlacklist")));
            InitControllers initializer = new InitControllers();

            initializer.Init(blacklistController, impostazioniController);

            LogController logController = new LogController((HomeLog)(helper.GetForm("HomeLog")));
            impostazioniController.ToLog += logController.Update;
            Application.Run(helper.GetForm("HomeSmartKey"));


        }



           
    }
}
