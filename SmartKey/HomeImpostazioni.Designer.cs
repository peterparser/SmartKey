namespace SmartKey
{
    partial class HomeImpostazioni
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewImpostazioni = new System.Windows.Forms.DataGridView();
            this.sorgenteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinazioneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDescrizioneTabella = new System.Windows.Forms.Label();
            this.buttonRimuovi = new System.Windows.Forms.Button();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonLogImpostazione = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpostazioni)).BeginInit();
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
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonLogImpostazione);
            this.splitContainer2.Size = new System.Drawing.Size(371, 372);
            this.splitContainer2.SplitterDistance = 294;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridViewImpostazioni);
            this.splitContainer3.Panel1.Controls.Add(this.labelDescrizioneTabella);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.buttonRimuovi);
            this.splitContainer3.Panel2.Controls.Add(this.buttonAggiungi);
            this.splitContainer3.Size = new System.Drawing.Size(371, 294);
            this.splitContainer3.SplitterDistance = 263;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridViewImpostazioni
            // 
            this.dataGridViewImpostazioni.AllowUserToAddRows = false;
            this.dataGridViewImpostazioni.AllowUserToDeleteRows = false;
            this.dataGridViewImpostazioni.AllowUserToResizeRows = false;
            this.dataGridViewImpostazioni.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImpostazioni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImpostazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImpostazioni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sorgenteColumn,
            this.destinazioneColumn});
            this.dataGridViewImpostazioni.Location = new System.Drawing.Point(3, 29);
            this.dataGridViewImpostazioni.Name = "dataGridViewImpostazioni";
            this.dataGridViewImpostazioni.RowHeadersVisible = false;
            this.dataGridViewImpostazioni.RowTemplate.ReadOnly = true;
            this.dataGridViewImpostazioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImpostazioni.Size = new System.Drawing.Size(257, 262);
            this.dataGridViewImpostazioni.TabIndex = 0;
            // 
            // sorgenteColumn
            // 
            this.sorgenteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sorgenteColumn.HeaderText = "Sorgente";
            this.sorgenteColumn.Name = "sorgenteColumn";
            this.sorgenteColumn.ReadOnly = true;
            // 
            // destinazioneColumn
            // 
            this.destinazioneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destinazioneColumn.HeaderText = "Destinazione";
            this.destinazioneColumn.Name = "destinazioneColumn";
            this.destinazioneColumn.ReadOnly = true;
            // 
            // labelDescrizioneTabella
            // 
            this.labelDescrizioneTabella.AutoSize = true;
            this.labelDescrizioneTabella.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrizioneTabella.Location = new System.Drawing.Point(4, 13);
            this.labelDescrizioneTabella.Name = "labelDescrizioneTabella";
            this.labelDescrizioneTabella.Size = new System.Drawing.Size(125, 13);
            this.labelDescrizioneTabella.TabIndex = 0;
            this.labelDescrizioneTabella.Text = "Cartelle da Sincronizzare";
            // 
            // buttonRimuovi
            // 
            this.buttonRimuovi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRimuovi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRimuovi.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonRimuovi.Location = new System.Drawing.Point(8, 126);
            this.buttonRimuovi.Name = "buttonRimuovi";
            this.buttonRimuovi.Size = new System.Drawing.Size(87, 35);
            this.buttonRimuovi.TabIndex = 1;
            this.buttonRimuovi.Text = "Rimuovi";
            this.buttonRimuovi.UseVisualStyleBackColor = false;
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAggiungi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggiungi.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAggiungi.Location = new System.Drawing.Point(8, 62);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(87, 33);
            this.buttonAggiungi.TabIndex = 0;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = false;
            // 
            // buttonLogImpostazione
            // 
            this.buttonLogImpostazione.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLogImpostazione.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogImpostazione.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLogImpostazione.Location = new System.Drawing.Point(125, 14);
            this.buttonLogImpostazione.Name = "buttonLogImpostazione";
            this.buttonLogImpostazione.Size = new System.Drawing.Size(111, 45);
            this.buttonLogImpostazione.TabIndex = 0;
            this.buttonLogImpostazione.Text = "Visualizza Log di Impostazione";
            this.buttonLogImpostazione.UseVisualStyleBackColor = false;
            // 
            // HomeImpostazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 372);
            this.Name = "HomeImpostazioni";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpostazioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button buttonRimuovi;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Button buttonLogImpostazione;
        private System.Windows.Forms.Label labelDescrizioneTabella;
        private System.Windows.Forms.DataGridView dataGridViewImpostazioni;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorgenteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinazioneColumn;
    }
}
