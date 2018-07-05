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

        public Button ButtonLogSincro
        {
            get
            {
                return buttonLogSincro;
            }
        }
        public Button ButtonSincro
        {
            get
            {
                return buttonSincronizza;
            }
        }
       
    }
}
