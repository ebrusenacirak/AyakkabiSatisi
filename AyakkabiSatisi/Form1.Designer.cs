namespace AyakkabiSatisi
{
    partial class Form1
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
            this.btnkategoriekle = new System.Windows.Forms.Button();
            this.btnurunekle = new System.Windows.Forms.Button();
            this.btnsatislar = new System.Windows.Forms.Button();
            this.btnmusteriekle = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkategoriekle
            // 
            this.btnkategoriekle.Location = new System.Drawing.Point(27, 65);
            this.btnkategoriekle.Name = "btnkategoriekle";
            this.btnkategoriekle.Size = new System.Drawing.Size(75, 104);
            this.btnkategoriekle.TabIndex = 0;
            this.btnkategoriekle.Text = "Kategori Ekle";
            this.btnkategoriekle.UseVisualStyleBackColor = true;
            // 
            // btnurunekle
            // 
            this.btnurunekle.Location = new System.Drawing.Point(135, 65);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(75, 104);
            this.btnurunekle.TabIndex = 1;
            this.btnurunekle.Text = "Ürün Ekle";
            this.btnurunekle.UseVisualStyleBackColor = true;
            // 
            // btnsatislar
            // 
            this.btnsatislar.Location = new System.Drawing.Point(240, 65);
            this.btnsatislar.Name = "btnsatislar";
            this.btnsatislar.Size = new System.Drawing.Size(75, 104);
            this.btnsatislar.TabIndex = 2;
            this.btnsatislar.Text = "Satışlar";
            this.btnsatislar.UseVisualStyleBackColor = true;
            // 
            // btnmusteriekle
            // 
            this.btnmusteriekle.Location = new System.Drawing.Point(357, 65);
            this.btnmusteriekle.Name = "btnmusteriekle";
            this.btnmusteriekle.Size = new System.Drawing.Size(75, 104);
            this.btnmusteriekle.TabIndex = 3;
            this.btnmusteriekle.Text = "Müşteri Ekle";
            this.btnmusteriekle.UseVisualStyleBackColor = true;
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(470, 65);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(75, 104);
            this.btncikis.TabIndex = 4;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 228);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnmusteriekle);
            this.Controls.Add(this.btnsatislar);
            this.Controls.Add(this.btnurunekle);
            this.Controls.Add(this.btnkategoriekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkategoriekle;
        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.Button btnsatislar;
        private System.Windows.Forms.Button btnmusteriekle;
        private System.Windows.Forms.Button btncikis;
    }
}

