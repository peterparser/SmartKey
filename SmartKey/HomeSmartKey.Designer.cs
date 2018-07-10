using SmartKey.ModelGestione;

namespace SmartKey
{
    partial class HomeSmartKey
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        protected new System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        protected new void InitializeComponent()
        {
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelUtente = new System.Windows.Forms.Label();
            this.labelDispositivo = new System.Windows.Forms.Label();
            this.labelCartellaPrivata = new System.Windows.Forms.Label();
            this.textBoxUtente = new System.Windows.Forms.TextBox();
            this.textBoxDispositivo = new System.Windows.Forms.TextBox();
            this.textBoxCartellaPrivata = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonLogSincro = new System.Windows.Forms.Button();
            this.buttonSincronizza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Panel2.Controls.Add(this.buttonLogSincro);
            this.splitContainer2.Panel2.Controls.Add(this.buttonSincronizza);
            this.splitContainer2.Size = new System.Drawing.Size(371, 372);
            this.splitContainer2.SplitterDistance = 123;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelUtente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDispositivo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCartellaPrivata, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxUtente, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDispositivo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCartellaPrivata, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84077F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.57961F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.57961F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(371, 123);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelUtente
            // 
            this.labelUtente.AutoSize = true;
            this.labelUtente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUtente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtente.Location = new System.Drawing.Point(3, 0);
            this.labelUtente.Name = "labelUtente";
            this.labelUtente.Size = new System.Drawing.Size(179, 45);
            this.labelUtente.TabIndex = 0;
            this.labelUtente.Text = "Utente";
            this.labelUtente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDispositivo
            // 
            this.labelDispositivo.AutoSize = true;
            this.labelDispositivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDispositivo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDispositivo.Location = new System.Drawing.Point(3, 45);
            this.labelDispositivo.Name = "labelDispositivo";
            this.labelDispositivo.Size = new System.Drawing.Size(179, 38);
            this.labelDispositivo.TabIndex = 1;
            this.labelDispositivo.Text = "Dispositivo";
            this.labelDispositivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCartellaPrivata
            // 
            this.labelCartellaPrivata.AutoSize = true;
            this.labelCartellaPrivata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCartellaPrivata.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartellaPrivata.Location = new System.Drawing.Point(3, 83);
            this.labelCartellaPrivata.Name = "labelCartellaPrivata";
            this.labelCartellaPrivata.Size = new System.Drawing.Size(179, 40);
            this.labelCartellaPrivata.TabIndex = 2;
            this.labelCartellaPrivata.Text = "Cartella Privata";
            this.labelCartellaPrivata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUtente
            // 
            this.textBoxUtente.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUtente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUtente.Location = new System.Drawing.Point(188, 3);
            this.textBoxUtente.Name = "textBoxUtente";
            this.textBoxUtente.ReadOnly = true;
            this.textBoxUtente.Size = new System.Drawing.Size(180, 21);
            this.textBoxUtente.TabIndex = 3;
            this.textBoxUtente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDispositivo
            // 
            this.textBoxDispositivo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDispositivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDispositivo.Location = new System.Drawing.Point(188, 48);
            this.textBoxDispositivo.Name = "textBoxDispositivo";
            this.textBoxDispositivo.ReadOnly = true;
            this.textBoxDispositivo.Size = new System.Drawing.Size(180, 21);
            this.textBoxDispositivo.TabIndex = 4;
            this.textBoxDispositivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCartellaPrivata
            // 
            this.textBoxCartellaPrivata.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCartellaPrivata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCartellaPrivata.Location = new System.Drawing.Point(188, 86);
            this.textBoxCartellaPrivata.Name = "textBoxCartellaPrivata";
            this.textBoxCartellaPrivata.ReadOnly = true;
            this.textBoxCartellaPrivata.Size = new System.Drawing.Size(180, 21);
            this.textBoxCartellaPrivata.TabIndex = 5;
            this.textBoxCartellaPrivata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 223);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(371, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabel.Size = new System.Drawing.Size(46, 17);
            this.statusLabel.Text = "Pronto!";
            // 
            // buttonLogSincro
            // 
            this.buttonLogSincro.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLogSincro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogSincro.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLogSincro.Location = new System.Drawing.Point(129, 131);
            this.buttonLogSincro.Name = "buttonLogSincro";
            this.buttonLogSincro.Size = new System.Drawing.Size(131, 47);
            this.buttonLogSincro.TabIndex = 1;
            this.buttonLogSincro.Text = "Visualizza Log di Sincronizzazione";
            this.buttonLogSincro.UseVisualStyleBackColor = false;
            // 
            // buttonSincronizza
            // 
            this.buttonSincronizza.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSincronizza.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSincronizza.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSincronizza.Location = new System.Drawing.Point(129, 56);
            this.buttonSincronizza.Name = "buttonSincronizza";
            this.buttonSincronizza.Size = new System.Drawing.Size(131, 50);
            this.buttonSincronizza.TabIndex = 0;
            this.buttonSincronizza.Text = "Sincronizza";
            this.buttonSincronizza.UseVisualStyleBackColor = false;
            // 
            // HomeSmartKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 372);
            this.Name = "HomeSmartKey";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer splitContainer2;
        protected System.Windows.Forms.Button buttonSincronizza;
        protected System.Windows.Forms.Button buttonLogSincro;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        protected System.Windows.Forms.Label labelUtente;
        protected System.Windows.Forms.Label labelDispositivo;
        protected System.Windows.Forms.Label labelCartellaPrivata;
        protected System.Windows.Forms.TextBox textBoxUtente;
        protected System.Windows.Forms.TextBox textBoxDispositivo;
        protected System.Windows.Forms.TextBox textBoxCartellaPrivata;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}
