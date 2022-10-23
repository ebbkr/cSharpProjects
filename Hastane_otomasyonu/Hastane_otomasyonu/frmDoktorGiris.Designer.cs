namespace Hastane_otomasyonu
{
    partial class frmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorGiris));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblDoktorGiris = new System.Windows.Forms.Label();
            this.btnDoktorGiris = new System.Windows.Forms.Button();
            this.lblDoktorSifre = new System.Windows.Forms.Label();
            this.lblDoktorTC = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(220, 159);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(160, 30);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // lblDoktorGiris
            // 
            this.lblDoktorGiris.AutoSize = true;
            this.lblDoktorGiris.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoktorGiris.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoktorGiris.Location = new System.Drawing.Point(136, 49);
            this.lblDoktorGiris.Name = "lblDoktorGiris";
            this.lblDoktorGiris.Size = new System.Drawing.Size(264, 72);
            this.lblDoktorGiris.TabIndex = 12;
            this.lblDoktorGiris.Text = "Doktor Giriş";
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.Location = new System.Drawing.Point(220, 288);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(113, 31);
            this.btnDoktorGiris.TabIndex = 11;
            this.btnDoktorGiris.Text = "Giriş Yap";
            this.btnDoktorGiris.UseVisualStyleBackColor = true;
            this.btnDoktorGiris.Click += new System.EventHandler(this.btnDoktorGiris_Click);
            // 
            // lblDoktorSifre
            // 
            this.lblDoktorSifre.AutoSize = true;
            this.lblDoktorSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblDoktorSifre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoktorSifre.Location = new System.Drawing.Point(147, 239);
            this.lblDoktorSifre.Name = "lblDoktorSifre";
            this.lblDoktorSifre.Size = new System.Drawing.Size(48, 20);
            this.lblDoktorSifre.TabIndex = 10;
            this.lblDoktorSifre.Text = "Şifre:";
            // 
            // lblDoktorTC
            // 
            this.lblDoktorTC.AutoSize = true;
            this.lblDoktorTC.BackColor = System.Drawing.Color.Transparent;
            this.lblDoktorTC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoktorTC.Location = new System.Drawing.Point(80, 162);
            this.lblDoktorTC.Name = "lblDoktorTC";
            this.lblDoktorTC.Size = new System.Drawing.Size(115, 20);
            this.lblDoktorTC.TabIndex = 9;
            this.lblDoktorTC.Text = "T.C Kimlik No:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 229);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 30);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // frmDoktorGiris
            // 
            this.AcceptButton = this.btnDoktorGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(517, 416);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblDoktorGiris);
            this.Controls.Add(this.btnDoktorGiris);
            this.Controls.Add(this.lblDoktorSifre);
            this.Controls.Add(this.lblDoktorTC);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmDoktorGiris";
            this.Text = "Doktor Giriş";
            this.Load += new System.EventHandler(this.frmDoktorGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblDoktorGiris;
        private System.Windows.Forms.Button btnDoktorGiris;
        private System.Windows.Forms.Label lblDoktorSifre;
        private System.Windows.Forms.Label lblDoktorTC;
        private System.Windows.Forms.TextBox textBox2;
    }
}