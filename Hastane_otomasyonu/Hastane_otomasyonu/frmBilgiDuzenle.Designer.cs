namespace Hastane_otomasyonu
{
    partial class frmHastaBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaBilgiDuzenle));
            this.lblHastaGuncelle = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblbSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHastaGuncelle
            // 
            this.lblHastaGuncelle.AutoSize = true;
            this.lblHastaGuncelle.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHastaGuncelle.Location = new System.Drawing.Point(125, 47);
            this.lblHastaGuncelle.Name = "lblHastaGuncelle";
            this.lblHastaGuncelle.Size = new System.Drawing.Size(245, 49);
            this.lblHastaGuncelle.TabIndex = 27;
            this.lblHastaGuncelle.Text = "Bilgi Güncelle";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(207, 298);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(163, 28);
            this.cmbCinsiyet.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(207, 184);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(163, 30);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(207, 334);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(163, 30);
            this.txtSifre.TabIndex = 6;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(207, 146);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(163, 30);
            this.txtAd.TabIndex = 1;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(207, 222);
            this.mskTC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(163, 30);
            this.mskTC.TabIndex = 3;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(207, 260);
            this.mskTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(163, 30);
            this.mskTel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSifre.Location = new System.Drawing.Point(136, 334);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(48, 20);
            this.lblSifre.TabIndex = 19;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCinsiyet.Location = new System.Drawing.Point(112, 298);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(72, 20);
            this.lblCinsiyet.TabIndex = 18;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefon.Location = new System.Drawing.Point(112, 260);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(69, 20);
            this.lblTelefon.TabIndex = 17;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTC.Location = new System.Drawing.Point(66, 232);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(115, 20);
            this.lblTC.TabIndex = 16;
            this.lblTC.Text = "T.C Kimlik No:";
            // 
            // lblbSoyad
            // 
            this.lblbSoyad.AutoSize = true;
            this.lblbSoyad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblbSoyad.Location = new System.Drawing.Point(122, 194);
            this.lblbSoyad.Name = "lblbSoyad";
            this.lblbSoyad.Size = new System.Drawing.Size(59, 20);
            this.lblbSoyad.TabIndex = 15;
            this.lblbSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAd.Location = new System.Drawing.Point(147, 156);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(34, 20);
            this.lblAd.TabIndex = 14;
            this.lblAd.Text = "Ad:";
            // 
            // frmHastaBilgiDuzenle
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(470, 504);
            this.Controls.Add(this.lblHastaGuncelle);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblbSoyad);
            this.Controls.Add(this.lblAd);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmHastaBilgiDuzenle";
            this.Text = "frmBilgiDuzenle";
            this.Load += new System.EventHandler(this.frmHastaBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHastaGuncelle;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblbSoyad;
        private System.Windows.Forms.Label lblAd;
    }
}