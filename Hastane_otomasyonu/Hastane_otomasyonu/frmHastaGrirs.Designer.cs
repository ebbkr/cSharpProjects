namespace Hastane_otomasyonu
{
    partial class frmHastaGrirs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaGrirs));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblHastaTC = new System.Windows.Forms.Label();
            this.lblHastaSifre = new System.Windows.Forms.Label();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblHastaGiris = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 207);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 30);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // lblHastaTC
            // 
            this.lblHastaTC.AutoSize = true;
            this.lblHastaTC.BackColor = System.Drawing.Color.Transparent;
            this.lblHastaTC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHastaTC.Location = new System.Drawing.Point(102, 140);
            this.lblHastaTC.Name = "lblHastaTC";
            this.lblHastaTC.Size = new System.Drawing.Size(115, 20);
            this.lblHastaTC.TabIndex = 2;
            this.lblHastaTC.Text = "T.C Kimlik No:";
            // 
            // lblHastaSifre
            // 
            this.lblHastaSifre.AutoSize = true;
            this.lblHastaSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblHastaSifre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHastaSifre.Location = new System.Drawing.Point(169, 217);
            this.lblHastaSifre.Name = "lblHastaSifre";
            this.lblHastaSifre.Size = new System.Drawing.Size(48, 20);
            this.lblHastaSifre.TabIndex = 3;
            this.lblHastaSifre.Text = "Şifre:";
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.Location = new System.Drawing.Point(242, 266);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(113, 31);
            this.btnHastaGiris.TabIndex = 3;
            this.btnHastaGiris.Text = "Giriş Yap";
            this.btnHastaGiris.UseVisualStyleBackColor = true;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(269, 320);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblHastaGiris
            // 
            this.lblHastaGiris.AutoSize = true;
            this.lblHastaGiris.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaGiris.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHastaGiris.Location = new System.Drawing.Point(158, 27);
            this.lblHastaGiris.Name = "lblHastaGiris";
            this.lblHastaGiris.Size = new System.Drawing.Size(244, 72);
            this.lblHastaGiris.TabIndex = 6;
            this.lblHastaGiris.Text = "Hasta Giriş";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(242, 137);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(160, 30);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // frmHastaGrirs
            // 
            this.AcceptButton = this.btnHastaGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(584, 453);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblHastaGiris);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnHastaGiris);
            this.Controls.Add(this.lblHastaSifre);
            this.Controls.Add(this.lblHastaTC);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmHastaGrirs";
            this.Text = "Hasta Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblHastaTC;
        private System.Windows.Forms.Label lblHastaSifre;
        private System.Windows.Forms.Button btnHastaGiris;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblHastaGiris;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}