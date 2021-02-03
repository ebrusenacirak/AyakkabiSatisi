namespace OyuncakSatisi
{
    partial class frmmusterilistele
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
            this.datagridmusteriliste = new System.Windows.Forms.DataGridView();
            this.btnkaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridmusteriliste)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridmusteriliste
            // 
            this.datagridmusteriliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridmusteriliste.Location = new System.Drawing.Point(46, 50);
            this.datagridmusteriliste.Name = "datagridmusteriliste";
            this.datagridmusteriliste.Size = new System.Drawing.Size(314, 224);
            this.datagridmusteriliste.TabIndex = 0;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(285, 321);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "button1";
            this.btnkaydet.UseVisualStyleBackColor = true;
            // 
            // frmmusterilistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 376);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.datagridmusteriliste);
            this.Name = "frmmusterilistele";
            this.Text = "frmmusterilistele";
            ((System.ComponentModel.ISupportInitialize)(this.datagridmusteriliste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridmusteriliste;
        private System.Windows.Forms.Button btnkaydet;
    }
}