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
            this.dataGridViewOutputLog = new System.Windows.Forms.DataGridView();
            this.labelElencoLog = new System.Windows.Forms.Label();
            this.checkedListBoxFiltriLog = new System.Windows.Forms.CheckedListBox();
            this.dataOraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoLogColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelDataEnd = new System.Windows.Forms.Label();
            this.labelDataStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer2.Panel1.Controls.Add(this.labelDataStart);
            this.splitContainer2.Panel1.Controls.Add(this.labelDataEnd);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePickerEnd);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePickerStart);
            this.splitContainer2.Panel1.Controls.Add(this.checkedListBoxFiltriLog);
            this.splitContainer2.Panel1.Controls.Add(this.labelElencoLog);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewOutputLog);
            this.splitContainer2.Size = new System.Drawing.Size(371, 372);
            this.splitContainer2.SplitterDistance = 126;
            this.splitContainer2.TabIndex = 0;
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
            this.dataOraColumn,
            this.tipoLogColumn,
            this.descrizioneColumn});
            this.dataGridViewOutputLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutputLog.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOutputLog.Name = "dataGridViewOutputLog";
            this.dataGridViewOutputLog.ReadOnly = true;
            this.dataGridViewOutputLog.RowHeadersVisible = false;
            this.dataGridViewOutputLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOutputLog.Size = new System.Drawing.Size(371, 242);
            this.dataGridViewOutputLog.TabIndex = 0;
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
            // checkedListBoxFiltriLog
            // 
            this.checkedListBoxFiltriLog.CheckOnClick = true;
            this.checkedListBoxFiltriLog.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkedListBoxFiltriLog.FormattingEnabled = true;
            this.checkedListBoxFiltriLog.Items.AddRange(new object[] {
            "Blacklist",
            "Compressione",
            "Data",
            "Impostazioni",
            "Sincronizzazione",
            "Sistema"});
            this.checkedListBoxFiltriLog.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxFiltriLog.MultiColumn = true;
            this.checkedListBoxFiltriLog.Name = "checkedListBoxFiltriLog";
            this.checkedListBoxFiltriLog.Size = new System.Drawing.Size(109, 100);
            this.checkedListBoxFiltriLog.Sorted = true;
            this.checkedListBoxFiltriLog.TabIndex = 1;
            // 
            // dataOraColumn
            // 
            this.dataOraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataOraColumn.HeaderText = "Data Ora";
            this.dataOraColumn.Name = "dataOraColumn";
            this.dataOraColumn.ReadOnly = true;
            // 
            // tipoLogColumn
            // 
            this.tipoLogColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoLogColumn.HeaderText = "Tipo Log";
            this.tipoLogColumn.Name = "tipoLogColumn";
            this.tipoLogColumn.ReadOnly = true;
            // 
            // descrizioneColumn
            // 
            this.descrizioneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descrizioneColumn.HeaderText = "Descrizione";
            this.descrizioneColumn.Name = "descrizioneColumn";
            this.descrizioneColumn.ReadOnly = true;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(259, 34);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(100, 21);
            this.dateTimePickerStart.TabIndex = 3;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(259, 77);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(100, 21);
            this.dateTimePickerEnd.TabIndex = 4;
            // 
            // labelDataEnd
            // 
            this.labelDataEnd.AutoSize = true;
            this.labelDataEnd.Location = new System.Drawing.Point(259, 61);
            this.labelDataEnd.Name = "labelDataEnd";
            this.labelDataEnd.Size = new System.Drawing.Size(59, 13);
            this.labelDataEnd.TabIndex = 5;
            this.labelDataEnd.Text = "Data finale";
            // 
            // labelDataStart
            // 
            this.labelDataStart.AutoSize = true;
            this.labelDataStart.Location = new System.Drawing.Point(259, 19);
            this.labelDataStart.Name = "labelDataStart";
            this.labelDataStart.Size = new System.Drawing.Size(64, 13);
            this.labelDataStart.TabIndex = 6;
            this.labelDataStart.Text = "Data iniziale";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewOutputLog;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiltriLog;
        private System.Windows.Forms.Label labelElencoLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLogColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneColumn;
        private System.Windows.Forms.Label labelDataStart;
        private System.Windows.Forms.Label labelDataEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
    }
}
