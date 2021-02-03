namespace AyakkabiSatisi
{
    partial class frmUrunListele
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
            this.datagridurunliste = new System.Windows.Forms.DataGridView();
            this.clmkategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridurunliste)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridurunliste
            // 
            this.datagridurunliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridurunliste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmkategori});
            this.datagridurunliste.Location = new System.Drawing.Point(49, 42);
            this.datagridurunliste.Name = "datagridurunliste";
            this.datagridurunliste.Size = new System.Drawing.Size(464, 368);
            this.datagridurunliste.TabIndex = 0;
            // 
            // clmkategori
            // 
            this.clmkategori.HeaderText = "Urun";
            this.clmkategori.Name = "clmkategori";
            // 
            // frmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.datagridurunliste);
            this.Name = "frmUrunListele";
            this.Text = "frmUrunListele";
            ((System.ComponentModel.ISupportInitialize)(this.datagridurunliste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridurunliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmkategori;
    }
}