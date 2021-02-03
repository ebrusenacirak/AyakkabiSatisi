namespace AyakkabiSatisi
{
    partial class frmMusteriAra
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
            this.txtmustericep = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmustericep
            // 
            this.txtmustericep.Location = new System.Drawing.Point(145, 47);
            this.txtmustericep.Name = "txtmustericep";
            this.txtmustericep.Size = new System.Drawing.Size(153, 20);
            this.txtmustericep.TabIndex = 0;
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(145, 145);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(153, 33);
            this.btnara.TabIndex = 1;
            this.btnara.Text = "Müsteri Ara";
            this.btnara.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müsteri Ara";
            // 
            // frmMusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtmustericep);
            this.Name = "frmMusteriAra";
            this.Text = "frmMusteriAra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmustericep;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Label label1;
    }
}