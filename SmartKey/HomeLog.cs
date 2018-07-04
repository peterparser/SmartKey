using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartKey
{
    public partial class HomeLog : SmartKey.BaseForm
    {
        public HomeLog()
        {
            InitializeComponent();
        }

        public RadioButton RadioButtonData
        {
            get
            {
                return this.radioButtonData;
            }
        }
        public RadioButton RadioButtonSincronizzazione
        {
            get
            {
                return this.radioButtonSincronizzazione;
            }
        }
        public RadioButton RadioButtonImpostazioni
        {
            get
            {
                return this.radioButtonImpostazioni;
            }
        }
        public RadioButton RadioButtonSistema
        {
            get
            {
                return this.radioButtonSistema;
            }
        }
        public RadioButton RadioButtonCompressione
        {
            get
            {
                return this.radioButtonCompressione;
            }
        }
        public RadioButton RadioButtonBlacklist
        {
            get
            {
                return this.radioButtonBlackList;
            }
        }
        public Label LabelDataStart
        {
            get
            {
                return this.labelDataStart;
            }
        }
        public Label LabelDataEnd
        {
            get
            {
                return this.labelDataEnd;
            }
        }
        public DateTimePicker DateTimePickerStart
        {
            get
            {
                return this.dateTimePickerStart;
            }
        }
        public DateTimePicker DateTimePickerEnd
        {
            get
            {
                return this.dateTimePickerEnd;
            }
        }
        public GroupBox GroupBoxFiltri
        {
            get
            {
                return this.groupBoxFiltri;
            }
        }

    }
}
