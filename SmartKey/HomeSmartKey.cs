using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartKey
{
    public partial class HomeSmartKey : SmartKey.BaseForm
    {
        public HomeSmartKey()
        {
            InitializeComponent();
        }

        public bool ChiediScelta(string badUser)
        {
            var confirmResult = MessageBox.Show("Vuoi sincronizzare i file prodotti da " +badUser+" ?",
                                     "Attenzione Sincronizzazione",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Button ButtonLogSincro
        {
            get
            {
                return buttonLogSincro;
            }
        }
        public Button ButtonSincronizza
        {
            get
            {
                return buttonSincronizza;
            }
        }

    }
}
