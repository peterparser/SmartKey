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

        public Button ButtonToLogBlacklist
        {
            get
            {
                return buttonLogBlacklist;
            }
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

        public void AddRow(string baduser)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    DataGridViewBlacklist.Rows.Add(baduser);
                }));
            }
            else
            {
                DataGridViewBlacklist.Rows.Add(baduser);
            }
        }
    }
}
