using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartKey
{
    public partial class HomeImpostazioni : SmartKey.BaseForm
    {
        public HomeImpostazioni()
        {
            InitializeComponent();
        }

        public Button ToLogImpostazioni
        {
            get
            {
                return buttonLogImpostazione;
            }
        }
        public Button AggiungiImpostazioneButton
        {
            get
            {
                return buttonAggiungi;
            }
        }
        public DataGridView DataGridImpostazioni
        {
            get
            {
                return dataGridViewImpostazioni;
            }
        }
        public Button RimuoviImpostazioneButton
        {
            get
            {
                return buttonRimuovi;
            }
        }

        
    }
}
