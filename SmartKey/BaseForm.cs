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
            switch (this.GetType().Name)
            {
                case ("HomeSmartKey"):
                    buttonSmartKey.BackColor = Color.CornflowerBlue;
                    buttonSmartKey.ForeColor = Color.White;
                    break;
                case ("HomeImpostazioni"):
                    buttonImpostazioni.BackColor = Color.CornflowerBlue;
                    buttonImpostazioni.ForeColor = Color.White;
                    break;
                case (""):
                    break;
                default:
                    break;
            }
        }
    }
}
