namespace SmartKey
{
    partial class Form1
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
            this.bottone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bottone
            // 
            this.bottone.Location = new System.Drawing.Point(83, 111);
            this.bottone.Name = "bottone";
            this.bottone.Size = new System.Drawing.Size(75, 23);
            this.bottone.TabIndex = 0;
            this.bottone.Text = "Wella";
            this.bottone.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bottone.UseVisualStyleBackColor = true;
            this.bottone.Click += new System.EventHandler(this.bottone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bottone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bottone;
    }
}

