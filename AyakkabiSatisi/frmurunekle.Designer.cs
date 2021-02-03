namespace AyakkabiSatisi
{
    partial class frmurunekle
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
            this.btnurunekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.cmbxkategori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnurunekle
            // 
            this.btnurunekle.Location = new System.Drawing.Point(298, 343);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(100, 23);
            this.btnurunekle.TabIndex = 0;
            this.btnurunekle.Text = "button1";
            this.btnurunekle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategori Id";
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(298, 64);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(100, 20);
            this.txturunad.TabIndex = 5;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(298, 135);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 6;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(298, 205);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(100, 20);
            this.txtstok.TabIndex = 7;
            // 
            // cmbxkategori
            // 
            this.cmbxkategori.FormattingEnabled = true;
            this.cmbxkategori.Location = new System.Drawing.Point(298, 272);
            this.cmbxkategori.Name = "cmbxkategori";
            this.cmbxkategori.Size = new System.Drawing.Size(100, 21);
            this.cmbxkategori.TabIndex = 8;
            // 
            // frmurunekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.cmbxkategori);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnurunekle);
            this.Name = "frmurunekle";
            this.Text = "frmurunekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.ComboBox cmbxkategori;
    }
}