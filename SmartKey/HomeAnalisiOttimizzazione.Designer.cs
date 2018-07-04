namespace SmartKey
{
    partial class HomeAnalisiOttimizzazione
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
            this.labelCartelleConsigliate = new System.Windows.Forms.Label();
            this.comboBoxQualita = new System.Windows.Forms.ComboBox();
            this.labelQualita = new System.Windows.Forms.Label();
            this.buttonLogCompressione = new System.Windows.Forms.Button();
            this.buttonComprimi = new System.Windows.Forms.Button();
            this.buttonPulisciLista = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pathCartellaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensioneCartellaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer2.Panel2.Controls.Add(this.buttonLogCompressione);
            this.splitContainer2.Size = new System.Drawing.Size(371, 372);
            this.splitContainer2.SplitterDistance = 274;
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
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer3.Panel1.Controls.Add(this.labelCartelleConsigliate);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.buttonPulisciLista);
            this.splitContainer3.Panel2.Controls.Add(this.buttonComprimi);
            this.splitContainer3.Panel2.Controls.Add(this.labelQualita);
            this.splitContainer3.Panel2.Controls.Add(this.comboBoxQualita);
            this.splitContainer3.Size = new System.Drawing.Size(371, 274);
            this.splitContainer3.SplitterDistance = 254;
            this.splitContainer3.TabIndex = 0;
            // 
            // labelCartelleConsigliate
            // 
            this.labelCartelleConsigliate.AutoSize = true;
            this.labelCartelleConsigliate.Location = new System.Drawing.Point(4, 13);
            this.labelCartelleConsigliate.Name = "labelCartelleConsigliate";
            this.labelCartelleConsigliate.Size = new System.Drawing.Size(195, 13);
            this.labelCartelleConsigliate.TabIndex = 0;
            this.labelCartelleConsigliate.Text = "Cartelle consigliate per la compressione";
            // 
            // comboBoxQualita
            // 
            this.comboBoxQualita.FormattingEnabled = true;
            this.comboBoxQualita.Location = new System.Drawing.Point(7, 28);
            this.comboBoxQualita.Name = "comboBoxQualita";
            this.comboBoxQualita.Size = new System.Drawing.Size(94, 21);
            this.comboBoxQualita.TabIndex = 0;
            // 
            // labelQualita
            // 
            this.labelQualita.AutoSize = true;
            this.labelQualita.Location = new System.Drawing.Point(1, 12);
            this.labelQualita.Name = "labelQualita";
            this.labelQualita.Size = new System.Drawing.Size(109, 13);
            this.labelQualita.TabIndex = 1;
            this.labelQualita.Text = "Qualità compressione";
            // 
            // buttonLogCompressione
            // 
            this.buttonLogCompressione.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLogCompressione.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLogCompressione.Location = new System.Drawing.Point(126, 21);
            this.buttonLogCompressione.Name = "buttonLogCompressione";
            this.buttonLogCompressione.Size = new System.Drawing.Size(115, 42);
            this.buttonLogCompressione.TabIndex = 0;
            this.buttonLogCompressione.Text = "Visualizza Log Compressione";
            this.buttonLogCompressione.UseVisualStyleBackColor = false;
            // 
            // buttonComprimi
            // 
            this.buttonComprimi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonComprimi.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonComprimi.Location = new System.Drawing.Point(18, 77);
            this.buttonComprimi.Name = "buttonComprimi";
            this.buttonComprimi.Size = new System.Drawing.Size(83, 29);
            this.buttonComprimi.TabIndex = 2;
            this.buttonComprimi.Text = "Comprimi";
            this.buttonComprimi.UseVisualStyleBackColor = false;
            // 
            // buttonPulisciLista
            // 
            this.buttonPulisciLista.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPulisciLista.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonPulisciLista.Location = new System.Drawing.Point(18, 130);
            this.buttonPulisciLista.Name = "buttonPulisciLista";
            this.buttonPulisciLista.Size = new System.Drawing.Size(83, 29);
            this.buttonPulisciLista.TabIndex = 3;
            this.buttonPulisciLista.Text = "Pulisci Lista";
            this.buttonPulisciLista.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathCartellaColumn,
            this.dimensioneCartellaColumn});
            this.dataGridView1.Location = new System.Drawing.Point(4, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(248, 242);
            this.dataGridView1.TabIndex = 1;
            // 
            // pathCartellaColumn
            // 
            this.pathCartellaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pathCartellaColumn.HeaderText = "Path Cartella";
            this.pathCartellaColumn.Name = "pathCartellaColumn";
            this.pathCartellaColumn.ReadOnly = true;
            // 
            // dimensioneCartellaColumn
            // 
            this.dimensioneCartellaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dimensioneCartellaColumn.HeaderText = "Dimensione";
            this.dimensioneCartellaColumn.Name = "dimensioneCartellaColumn";
            this.dimensioneCartellaColumn.ReadOnly = true;
            // 
            // HomeAnalisiOttimizzazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 372);
            this.Name = "HomeAnalisiOttimizzazione";
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
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathCartellaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensioneCartellaColumn;
        private System.Windows.Forms.Label labelCartelleConsigliate;
        private System.Windows.Forms.Button buttonPulisciLista;
        private System.Windows.Forms.Button buttonComprimi;
        private System.Windows.Forms.Label labelQualita;
        private System.Windows.Forms.ComboBox comboBoxQualita;
        private System.Windows.Forms.Button buttonLogCompressione;
    }
}
