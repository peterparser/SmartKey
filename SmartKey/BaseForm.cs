using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartKey
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void buttonSmartKey_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ciao");
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            switch (GetType().Name)
            {
                case ("HomeSmartKey"):
                    ButtonHomeSmartKey.BackColor = Color.CornflowerBlue;
                    ButtonHomeSmartKey.ForeColor = Color.White;
                    break;
                case ("HomeImpostazioni"):
                    ButtonImpostazioneTrasferimento.BackColor = Color.CornflowerBlue;
                    ButtonImpostazioneTrasferimento.ForeColor = Color.White;
                    break;
                case ("HomeBlacklist"):
                    ButtonBlacklist.BackColor = Color.CornflowerBlue;
                    ButtonBlacklist.ForeColor = Color.White;
                    break;
                case ("HomeLog"):
                    ButtonLog.BackColor = Color.CornflowerBlue;
                    ButtonLog.ForeColor = Color.White;
                    break;
                case ("HomeAnalisiOttimizzazione"):
                    ButtonAnalisi.BackColor = Color.CornflowerBlue;
                    ButtonAnalisi.ForeColor = Color.White;
                    break;
                default:
                    break;
            }
        }
        public Button ButtonHomeSmartKey
        {
            get
            {
                return buttonSmartKey;
            }
        }
        public Button ButtonImpostazioneTrasferimento
        {
            get
            {
                return buttonImpostazioni;
            }
        }
        public Button ButtonAnalisi
        {
            get
            {
                return buttonAnalisi;
            }
        }
        public Button ButtonBlacklist
        {
            get
            {
                return buttonBlacklist;
            }
        }
        public Button ButtonLog
        {
            get
            {
                return buttonLog;
            }
        }
    }
}
