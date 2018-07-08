namespace SmartKey
{
    partial class HomeBlacklist
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
            this.dataGridViewBlacklist = new System.Windows.Forms.DataGridView();
            this.utentiBloccatiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelBlacklist = new System.Windows.Forms.Label();
            this.buttonRimuovi = new System.Windows.Forms.Button();
            this.buttonLogBlacklist = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlacklist)).BeginInit();
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
            this.splitContainer2.Panel2.Controls.Add(this.buttonLogBlacklist);
            this.splitContainer2.Size = new System.Drawing.Size(371, 372);
            this.splitContainer2.SplitterDistance = 275;
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
            this.splitContainer3.Panel1.Controls.Add(this.dataGridViewBlacklist);
            this.splitContainer3.Panel1.Controls.Add(this.labelBlacklist);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.buttonRimuovi);
            this.splitContainer3.Size = new System.Drawing.Size(371, 275);
            this.splitContainer3.SplitterDistance = 272;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridViewBlacklist
            // 
            this.dataGridViewBlacklist.AllowDrop = true;
            this.dataGridViewBlacklist.AllowUserToAddRows = false;
            this.dataGridViewBlacklist.AllowUserToDeleteRows = false;
            this.dataGridViewBlacklist.AllowUserToOrderColumns = true;
            this.dataGridViewBlacklist.AllowUserToResizeRows = false;
            this.dataGridViewBlacklist.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBlacklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBlacklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBlacklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utentiBloccatiColumn});
            this.dataGridViewBlacklist.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewBlacklist.Name = "dataGridViewBlacklist";
            this.dataGridViewBlacklist.ReadOnly = true;
            this.dataGridViewBlacklist.RowHeadersVisible = false;
            this.dataGridViewBlacklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBlacklist.Size = new System.Drawing.Size(262, 252);
            this.dataGridViewBlacklist.TabIndex = 1;
            // 
            // utentiBloccatiColumn
            // 
            this.utentiBloccatiColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.utentiBloccatiColumn.HeaderText = "Utenti Bloccati";
            this.utentiBloccatiColumn.Name = "utentiBloccatiColumn";
            this.utentiBloccatiColumn.ReadOnly = true;
            // 
            // labelBlacklist
            // 
            this.labelBlacklist.AutoSize = true;
            this.labelBlacklist.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlacklist.Location = new System.Drawing.Point(4, 4);
            this.labelBlacklist.Name = "labelBlacklist";
            this.labelBlacklist.Size = new System.Drawing.Size(44, 13);
            this.labelBlacklist.TabIndex = 0;
            this.labelBlacklist.Text = "Blacklist";
            // 
            // buttonRimuovi
            // 
            this.buttonRimuovi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRimuovi.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonRimuovi.Location = new System.Drawing.Point(3, 56);
            this.buttonRimuovi.Name = "buttonRimuovi";
            this.buttonRimuovi.Size = new System.Drawing.Size(86, 31);
            this.buttonRimuovi.TabIndex = 0;
            this.buttonRimuovi.Text = "Rimuovi";
            this.buttonRimuovi.UseVisualStyleBackColor = false;
            // 
            // buttonLogBlacklist
            // 
            this.buttonLogBlacklist.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLogBlacklist.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLogBlacklist.Location = new System.Drawing.Point(133, 20);
            this.buttonLogBlacklist.Name = "buttonLogBlacklist";
            this.buttonLogBlacklist.Size = new System.Drawing.Size(110, 36);
            this.buttonLogBlacklist.TabIndex = 0;
            this.buttonLogBlacklist.Text = "Visualizza Log Blacklist";
            this.buttonLogBlacklist.UseVisualStyleBackColor = false;
            // 
            // HomeBlacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 372);
            this.Name = "HomeBlacklist";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlacklist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridViewBlacklist;
        private System.Windows.Forms.Label labelBlacklist;
        private System.Windows.Forms.Button buttonRimuovi;
        private System.Windows.Forms.Button buttonLogBlacklist;
        private System.Windows.Forms.DataGridViewTextBoxColumn utentiBloccatiColumn;
    }
}
