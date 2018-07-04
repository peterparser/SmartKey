using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartKey
{
    public partial class HomeBlacklist : SmartKey.BaseForm
    {
        public HomeBlacklist()
        {
            InitializeComponent();
        }
        public Button ButtonRimuovi
        {
            get
            {
               return this.buttonRimuovi;
            }
        }
        public DataGridView DataGridViewBlacklist
        {
            get
            {
                return this.dataGridViewBlacklist;
            }
        }
    }
}
