namespace SmartKey
{
    partial class HomeSmartKey
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonSincronizza = new System.Windows.Forms.Button();
            this.buttonLogSincro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonLogSincro);
            this.splitContainer2.Panel2.Controls.Add(this.buttonSincronizza);
            this.splitContainer2.Size = new System.Drawing.Size(371, 372);
            this.splitContainer2.SplitterDistance = 123;
            this.splitContainer2.TabIndex = 0;
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
            // HomeSmartKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 372);
            this.Name = "HomeSmartKey";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonSincronizza;
        private System.Windows.Forms.Button buttonLogSincro;
    }
}
