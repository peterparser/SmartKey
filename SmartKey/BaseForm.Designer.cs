using System.Windows.Forms;

namespace SmartKey
{
    public partial class BaseForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSmartKey = new System.Windows.Forms.Button();
            this.buttonImpostazioni = new System.Windows.Forms.Button();
            this.buttonBlacklist = new System.Windows.Forms.Button();
            this.buttonAnalisi = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Size = new System.Drawing.Size(562, 372);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSmartKey, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonImpostazioni, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBlacklist, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonAnalisi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonLog, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(187, 372);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonSmartKey
            // 
            this.buttonSmartKey.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSmartKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSmartKey.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSmartKey.Location = new System.Drawing.Point(3, 3);
            this.buttonSmartKey.Name = "buttonSmartKey";
            this.buttonSmartKey.Size = new System.Drawing.Size(181, 68);
            this.buttonSmartKey.TabIndex = 0;
            this.buttonSmartKey.Text = "Home Smartkey";
            this.buttonSmartKey.UseVisualStyleBackColor = false;
            this.buttonSmartKey.Click += new System.EventHandler(this.buttonSmartKey_Click);
            // 
            // buttonImpostazioni
            // 
            this.buttonImpostazioni.BackColor = System.Drawing.SystemColors.Window;
            this.buttonImpostazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonImpostazioni.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImpostazioni.Location = new System.Drawing.Point(3, 77);
            this.buttonImpostazioni.Name = "buttonImpostazioni";
            this.buttonImpostazioni.Size = new System.Drawing.Size(181, 68);
            this.buttonImpostazioni.TabIndex = 1;
            this.buttonImpostazioni.Text = "Impostazione Trasferimento";
            this.buttonImpostazioni.UseVisualStyleBackColor = false;
            // 
            // buttonBlacklist
            // 
            this.buttonBlacklist.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBlacklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBlacklist.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlacklist.Location = new System.Drawing.Point(3, 151);
            this.buttonBlacklist.Name = "buttonBlacklist";
            this.buttonBlacklist.Size = new System.Drawing.Size(181, 68);
            this.buttonBlacklist.TabIndex = 2;
            this.buttonBlacklist.Text = "Blacklist";
            this.buttonBlacklist.UseVisualStyleBackColor = false;
            // 
            // buttonAnalisi
            // 
            this.buttonAnalisi.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnalisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnalisi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalisi.Location = new System.Drawing.Point(3, 225);
            this.buttonAnalisi.Name = "buttonAnalisi";
            this.buttonAnalisi.Size = new System.Drawing.Size(181, 68);
            this.buttonAnalisi.TabIndex = 3;
            this.buttonAnalisi.Text = "Analisi e Ottimizzazione";
            this.buttonAnalisi.UseVisualStyleBackColor = false;
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.Location = new System.Drawing.Point(3, 299);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(181, 70);
            this.buttonLog.TabIndex = 4;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 372);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Smartkey";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected SplitContainer splitContainer1;
        protected TableLayoutPanel tableLayoutPanel1;
        protected Button buttonSmartKey;
        protected Button buttonImpostazioni;
        protected Button buttonBlacklist;
        protected Button buttonAnalisi;
        protected Button buttonLog;
    }
}

