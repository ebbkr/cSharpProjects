namespace Hastane_otomasyonu
{
    partial class frmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreterGiris));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblSekreterGiris = new System.Windows.Forms.Label();
            this.btnSekreterGiris = new System.Windows.Forms.Button();
            this.lblSekreterSifre = new System.Windows.Forms.Label();
            this.lblSekreterTC = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(224, 165);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(160, 30);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // lblSekreterGiris
            // 
            this.lblSekreterGiris.AutoSize = true;
            this.lblSekreterGiris.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSekreterGiris.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSekreterGiris.Location = new System.Drawing.Point(99, 47);
            this.lblSekreterGiris.Name = "lblSekreterGiris";
            this.lblSekreterGiris.Size = new System.Drawing.Size(305, 72);
            this.lblSekreterGiris.TabIndex = 18;
            this.lblSekreterGiris.Text = "Sekreter Giriş";
            // 
            // btnSekreterGiris
            // 
            this.btnSekreterGiris.Location = new System.Drawing.Point(188, 309);
            this.btnSekreterGiris.Name = "btnSekreterGiris";
            this.btnSekreterGiris.Size = new System.Drawing.Size(137, 31);
            this.btnSekreterGiris.TabIndex = 17;
            this.btnSekreterGiris.Text = "Giriş Yap";
            this.btnSekreterGiris.UseVisualStyleBackColor = true;
            this.btnSekreterGiris.Click += new System.EventHandler(this.btnSekreterGiris_Click);
            // 
            // lblSekreterSifre
            // 
            this.lblSekreterSifre.AutoSize = true;
            this.lblSekreterSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSekreterSifre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSekreterSifre.Location = new System.Drawing.Point(151, 245);
            this.lblSekreterSifre.Name = "lblSekreterSifre";
            this.lblSekreterSifre.Size = new System.Drawing.Size(48, 20);
            this.lblSekreterSifre.TabIndex = 16;
            this.lblSekreterSifre.Text = "Şifre:";
            // 
            // lblSekreterTC
            // 
            this.lblSekreterTC.AutoSize = true;
            this.lblSekreterTC.BackColor = System.Drawing.Color.Transparent;
            this.lblSekreterTC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSekreterTC.Location = new System.Drawing.Point(84, 168);
            this.lblSekreterTC.Name = "lblSekreterTC";
            this.lblSekreterTC.Size = new System.Drawing.Size(115, 20);
            this.lblSekreterTC.TabIndex = 15;
            this.lblSekreterTC.Text = "T.C Kimlik No:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 235);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // frmSekreterGiris
            // 
            this.AcceptButton = this.btnSekreterGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(495, 427);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblSekreterGiris);
            this.Controls.Add(this.btnSekreterGiris);
            this.Controls.Add(this.lblSekreterSifre);
            this.Controls.Add(this.lblSekreterTC);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmSekreterGiris";
            this.Text = "Sekreter Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblSekreterGiris;
        private System.Windows.Forms.Button btnSekreterGiris;
        private System.Windows.Forms.Label lblSekreterSifre;
        private System.Windows.Forms.Label lblSekreterTC;
        private System.Windows.Forms.TextBox textBox2;
    }
}