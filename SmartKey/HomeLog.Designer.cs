using System.Windows.Forms;

namespace SmartKey
{
    partial class HomeLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonCancellaSelezione = new System.Windows.Forms.Button();
            this.groupBoxFiltri = new System.Windows.Forms.GroupBox();
            this.radioButtonSistema = new System.Windows.Forms.RadioButton();
            this.radioButtonSincronizzazione = new System.Windows.Forms.RadioButton();
            this.radioButtonImpostazioni = new System.Windows.Forms.RadioButton();
            this.radioButtonData = new System.Windows.Forms.RadioButton();
            this.radioButtonCompressione = new System.Windows.Forms.RadioButton();
            this.radioButtonBlackList = new System.Windows.Forms.RadioButton();
            this.labelDataStart = new System.Windows.Forms.Label();
            this.labelDataEnd = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelElencoLog = new System.Windows.Forms.Label();
            this.dataGridViewOutputLog = new System.Windows.Forms.DataGridView();
            this.dataOraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxFiltri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputLog)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonCancellaSelezione);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxFiltri);
            this.splitContainer2.Panel1.Controls.Add(this.labelDataStart);
            this.splitContainer2.Panel1.Controls.Add(this.labelDataEnd);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePickerEnd);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePickerStart);
            this.splitContainer2.Panel1.Controls.Add(this.labelElencoLog);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewOutputLog);
            this.splitContainer2.Size = new System.Drawing.Size(371, 372);
            this.splitContainer2.SplitterDistance = 125;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonCancellaSelezione
            // 
            this.buttonCancellaSelezione.Location = new System.Drawing.Point(274, 100);
            this.buttonCancellaSelezione.Name = "buttonCancellaSelezione";
            this.buttonCancellaSelezione.Size = new System.Drawing.Size(75, 23);
            this.buttonCancellaSelezione.TabIndex = 9;
            this.buttonCancellaSelezione.Text = "Reset";
            this.buttonCancellaSelezione.UseVisualStyleBackColor = true;
            this.buttonCancellaSelezione.Click += new System.EventHandler(this.ButtonCancellaSelezione_Click);
            // 
            // groupBoxFiltri
            // 
            this.groupBoxFiltri.Controls.Add(this.radioButtonSistema);
            this.groupBoxFiltri.Controls.Add(this.radioButtonSincronizzazione);
            this.groupBoxFiltri.Controls.Add(this.radioButtonImpostazioni);
            this.groupBoxFiltri.Controls.Add(this.radioButtonData);
            this.groupBoxFiltri.Controls.Add(this.radioButtonCompressione);
            this.groupBoxFiltri.Controls.Add(this.radioButtonBlackList);
            this.groupBoxFiltri.Location = new System.Drawing.Point(6, 19);
            this.groupBoxFiltri.Name = "groupBoxFiltri";
            this.groupBoxFiltri.Size = new System.Drawing.Size(247, 100);
            this.groupBoxFiltri.TabIndex = 8;
            this.groupBoxFiltri.TabStop = false;
            this.groupBoxFiltri.Text = "Filtri";
            // 
            // radioButtonSistema
            // 
            this.radioButtonSistema.AutoSize = true;
            this.radioButtonSistema.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonSistema.Location = new System.Drawing.Point(109, 66);
            this.radioButtonSistema.Name = "radioButtonSistema";
            this.radioButtonSistema.Size = new System.Drawing.Size(62, 17);
            this.radioButtonSistema.TabIndex = 12;
            this.radioButtonSistema.TabStop = true;
            this.radioButtonSistema.Text = "Sistema";
            this.radioButtonSistema.UseVisualStyleBackColor = true;
            // 
            // radioButtonSincronizzazione
            // 
            this.radioButtonSincronizzazione.AutoSize = true;
            this.radioButtonSincronizzazione.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonSincronizzazione.Location = new System.Drawing.Point(109, 42);
            this.radioButtonSincronizzazione.Name = "radioButtonSincronizzazione";
            this.radioButtonSincronizzazione.Size = new System.Drawing.Size(103, 17);
            this.radioButtonSincronizzazione.TabIndex = 11;
            this.radioButtonSincronizzazione.TabStop = true;
            this.radioButtonSincronizzazione.Text = "Sincronizzazione";
            this.radioButtonSincronizzazione.UseVisualStyleBackColor = true;
            // 
            // radioButtonImpostazioni
            // 
            this.radioButtonImpostazioni.AutoSize = true;
            this.radioButtonImpostazioni.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonImpostazioni.Location = new System.Drawing.Point(109, 20);
            this.radioButtonImpostazioni.Name = "radioButtonImpostazioni";
            this.radioButtonImpostazioni.Size = new System.Drawing.Size(85, 17);
            this.radioButtonImpostazioni.TabIndex = 10;
            this.radioButtonImpostazioni.TabStop = true;
            this.radioButtonImpostazioni.Text = "Impostazioni";
            this.radioButtonImpostazioni.UseVisualStyleBackColor = true;
            // 
            // radioButtonData
            // 
            this.radioButtonData.AutoSize = true;
            this.radioButtonData.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonData.Location = new System.Drawing.Point(6, 66);
            this.radioButtonData.Name = "radioButtonData";
            this.radioButtonData.Size = new System.Drawing.Size(48, 17);
            this.radioButtonData.TabIndex = 9;
            this.radioButtonData.TabStop = true;
            this.radioButtonData.Text = "Data";
            this.radioButtonData.UseVisualStyleBackColor = true;
            // 
            // radioButtonCompressione
            // 
            this.radioButtonCompressione.AutoSize = true;
            this.radioButtonCompressione.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonCompressione.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCompressione.Name = "radioButtonCompressione";
            this.radioButtonCompressione.Size = new System.Drawing.Size(92, 17);
            this.radioButtonCompressione.TabIndex = 8;
            this.radioButtonCompressione.TabStop = true;
            this.radioButtonCompressione.Text = "Compressione";
            this.radioButtonCompressione.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlackList
            // 
            this.radioButtonBlackList.AutoSize = true;
            this.radioButtonBlackList.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonBlackList.Location = new System.Drawing.Point(6, 20);
            this.radioButtonBlackList.Name = "radioButtonBlackList";
            this.radioButtonBlackList.Size = new System.Drawing.Size(62, 17);
            this.radioButtonBlackList.TabIndex = 7;
            this.radioButtonBlackList.TabStop = true;
            this.radioButtonBlackList.Text = "Blacklist";
            this.radioButtonBlackList.UseVisualStyleBackColor = true;
            // 
            // labelDataStart
            // 
            this.labelDataStart.AutoSize = true;
            this.labelDataStart.Location = new System.Drawing.Point(259, 19);
            this.labelDataStart.Name = "labelDataStart";
            this.labelDataStart.Size = new System.Drawing.Size(64, 13);
            this.labelDataStart.TabIndex = 6;
            this.labelDataStart.Text = "Data iniziale";
            this.labelDataStart.Visible = false;
            // 
            // labelDataEnd
            // 
            this.labelDataEnd.AutoSize = true;
            this.labelDataEnd.Location = new System.Drawing.Point(259, 61);
            this.labelDataEnd.Name = "labelDataEnd";
            this.labelDataEnd.Size = new System.Drawing.Size(59, 13);
            this.labelDataEnd.TabIndex = 5;
            this.labelDataEnd.Text = "Data finale";
            this.labelDataEnd.Visible = false;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(259, 77);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(100, 21);
            this.dateTimePickerEnd.TabIndex = 4;
            this.dateTimePickerEnd.Visible = false;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(259, 34);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(100, 21);
            this.dateTimePickerStart.TabIndex = 3;
            this.dateTimePickerStart.Visible = false;
            // 
            // labelElencoLog
            // 
            this.labelElencoLog.AutoSize = true;
            this.labelElencoLog.Location = new System.Drawing.Point(3, 3);
            this.labelElencoLog.Name = "labelElencoLog";
            this.labelElencoLog.Size = new System.Drawing.Size(76, 13);
            this.labelElencoLog.TabIndex = 0;
            this.labelElencoLog.Text = "Elenco Dei Log";
            // 
            // dataGridViewOutputLog
            // 
            this.dataGridViewOutputLog.AllowUserToAddRows = false;
            this.dataGridViewOutputLog.AllowUserToDeleteRows = false;
            this.dataGridViewOutputLog.AllowUserToResizeRows = false;
            this.dataGridViewOutputLog.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOutputLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOutputLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataOraColumn});
            this.dataGridViewOutputLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutputLog.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOutputLog.Name = "dataGridViewOutputLog";
            this.dataGridViewOutputLog.ReadOnly = true;
            this.dataGridViewOutputLog.RowHeadersVisible = false;
            this.dataGridViewOutputLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOutputLog.Size = new System.Drawing.Size(371, 243);
            this.dataGridViewOutputLog.TabIndex = 0;
            // 
            // dataOraColumn
            // 
            this.dataOraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataOraColumn.HeaderText = "Data Ora    Tipo      Descrizione";
            this.dataOraColumn.Name = "dataOraColumn";
            this.dataOraColumn.ReadOnly = true;
            // 
            // HomeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 372);
            this.Name = "HomeLog";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxFiltri.ResumeLayout(false);
            this.groupBoxFiltri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewOutputLog;
        private System.Windows.Forms.Label labelElencoLog;
        private System.Windows.Forms.Label labelDataStart;
        private System.Windows.Forms.Label labelDataEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private GroupBox groupBoxFiltri;
        private RadioButton radioButtonSistema;
        private RadioButton radioButtonSincronizzazione;
        private RadioButton radioButtonImpostazioni;
        private RadioButton radioButtonData;
        private RadioButton radioButtonCompressione;
        private RadioButton radioButtonBlackList;
        private Button buttonCancellaSelezione;
        private DataGridViewTextBoxColumn dataOraColumn;
    }
}
