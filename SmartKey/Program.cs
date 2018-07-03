﻿using SmartKey.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Application.Run(helper.GetForm("HomeSmartKey"));
        }
    }
}
