namespace Hastane_otomasyonu
{
    partial class frmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreterDetay));
            this.grpSekreterBiilgi = new System.Windows.Forms.GroupBox();
            this.lblAdSoyadDeger = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTCDeger = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyuru = new System.Windows.Forms.Button();
            this.rchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnRandevuListe = new System.Windows.Forms.Button();
            this.btnBransPaneş = new System.Windows.Forms.Button();
            this.btnDoktorpanel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.chckDurum = new System.Windows.Forms.CheckBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblRandevuTC = new System.Windows.Forms.Label();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.lblBrans = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grpSekreterBiilgi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSekreterBiilgi
            // 
            this.grpSekreterBiilgi.Controls.Add(this.lblAdSoyadDeger);
            this.grpSekreterBiilgi.Controls.Add(this.lblAdSoyad);
            this.grpSekreterBiilgi.Controls.Add(this.lblTCDeger);
            this.grpSekreterBiilgi.Controls.Add(this.lblTC);
            this.grpSekreterBiilgi.ForeColor = System.Drawing.SystemColors.Control;
            this.grpSekreterBiilgi.Location = new System.Drawing.Point(9, 11);
            this.grpSekreterBiilgi.Name = "grpSekreterBiilgi";
            this.grpSekreterBiilgi.Size = new System.Drawing.Size(384, 163);
            this.grpSekreterBiilgi.TabIndex = 0;
            this.grpSekreterBiilgi.TabStop = false;
            this.grpSekreterBiilgi.Text = "Sekreter Bilgi";
            // 
            // lblAdSoyadDeger
            // 
            this.lblAdSoyadDeger.AutoSize = true;
            this.lblAdSoyadDeger.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdSoyadDeger.Location = new System.Drawing.Point(181, 100);
            this.lblAdSoyadDeger.Name = "lblAdSoyadDeger";
            this.lblAdSoyadDeger.Size = new System.Drawing.Size(79, 20);
            this.lblAdSoyadDeger.TabIndex = 7;
            this.lblAdSoyadDeger.Text = "__________";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdSoyad.Location = new System.Drawing.Point(88, 100);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(85, 20);
            this.lblAdSoyad.TabIndex = 6;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTCDeger
            // 
            this.lblTCDeger.AutoSize = true;
            this.lblTCDeger.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTCDeger.Location = new System.Drawing.Point(181, 42);
            this.lblTCDeger.Name = "lblTCDeger";
            this.lblTCDeger.Size = new System.Drawing.Size(108, 20);
            this.lblTCDeger.TabIndex = 5;
            this.lblTCDeger.Text = "00000000000";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTC.Location = new System.Drawing.Point(58, 42);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(115, 20);
            this.lblTC.TabIndex = 4;
            this.lblTC.Text = "T.C Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuyuru);
            this.groupBox2.Controls.Add(this.rchDuyuru);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(9, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnDuyuru
            // 
            this.btnDuyuru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDuyuru.Location = new System.Drawing.Point(62, 240);
            this.btnDuyuru.Name = "btnDuyuru";
            this.btnDuyuru.Size = new System.Drawing.Size(263, 43);
            this.btnDuyuru.TabIndex = 1;
            this.btnDuyuru.Text = "Oluştur";
            this.btnDuyuru.UseVisualStyleBackColor = true;
            this.btnDuyuru.Click += new System.EventHandler(this.btnDuyuru_Click);
            // 
            // rchDuyuru
            // 
            this.rchDuyuru.Location = new System.Drawing.Point(12, 30);
            this.rchDuyuru.Name = "rchDuyuru";
            this.rchDuyuru.Size = new System.Drawing.Size(358, 199);
            this.rchDuyuru.TabIndex = 0;
            this.rchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDuyurular);
            this.groupBox3.Controls.Add(this.btnRandevuListe);
            this.groupBox3.Controls.Add(this.btnBransPaneş);
            this.groupBox3.Controls.Add(this.btnDoktorpanel);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(9, 507);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 163);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDuyurular.Location = new System.Drawing.Point(568, 67);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(179, 43);
            this.btnDuyurular.TabIndex = 5;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnRandevuListe
            // 
            this.btnRandevuListe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRandevuListe.Location = new System.Drawing.Point(382, 67);
            this.btnRandevuListe.Name = "btnRandevuListe";
            this.btnRandevuListe.Size = new System.Drawing.Size(172, 43);
            this.btnRandevuListe.TabIndex = 4;
            this.btnRandevuListe.Text = "Randevu Liste";
            this.btnRandevuListe.UseVisualStyleBackColor = true;
            this.btnRandevuListe.Click += new System.EventHandler(this.btnRandevuListe_Click);
            // 
            // btnBransPaneş
            // 
            this.btnBransPaneş.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBransPaneş.Location = new System.Drawing.Point(197, 67);
            this.btnBransPaneş.Name = "btnBransPaneş";
            this.btnBransPaneş.Size = new System.Drawing.Size(172, 43);
            this.btnBransPaneş.TabIndex = 3;
            this.btnBransPaneş.Text = "Branş Paneli";
            this.btnBransPaneş.UseVisualStyleBackColor = true;
            this.btnBransPaneş.Click += new System.EventHandler(this.btnBransPaneş_Click);
            // 
            // btnDoktorpanel
            // 
            this.btnDoktorpanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDoktorpanel.Location = new System.Drawing.Point(12, 67);
            this.btnDoktorpanel.Name = "btnDoktorpanel";
            this.btnDoktorpanel.Size = new System.Drawing.Size(172, 43);
            this.btnDoktorpanel.TabIndex = 2;
            this.btnDoktorpanel.Text = "Doktor Paneli";
            this.btnDoktorpanel.UseVisualStyleBackColor = true;
            this.btnDoktorpanel.Click += new System.EventHandler(this.btnDoktorpanel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnKayit);
            this.groupBox4.Controls.Add(this.chckDurum);
            this.groupBox4.Controls.Add(this.mskTC);
            this.groupBox4.Controls.Add(this.cmbDoktor);
            this.groupBox4.Controls.Add(this.cmbBrans);
            this.groupBox4.Controls.Add(this.mskSaat);
            this.groupBox4.Controls.Add(this.mskTarih);
            this.groupBox4.Controls.Add(this.txtid);
            this.groupBox4.Controls.Add(this.lblRandevuTC);
            this.groupBox4.Controls.Add(this.lblDoktor);
            this.groupBox4.Controls.Add(this.lblBrans);
            this.groupBox4.Controls.Add(this.lblSaat);
            this.groupBox4.Controls.Add(this.lblTarih);
            this.groupBox4.Controls.Add(this.lblid);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(410, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 479);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Paneli";
            //this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnKayit
            // 
            this.btnKayit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKayit.Location = new System.Drawing.Point(128, 418);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(139, 35);
            this.btnKayit.TabIndex = 14;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // chckDurum
            // 
            this.chckDurum.AutoSize = true;
            this.chckDurum.Location = new System.Drawing.Point(142, 326);
            this.chckDurum.Name = "chckDurum";
            this.chckDurum.Size = new System.Drawing.Size(84, 24);
            this.chckDurum.TabIndex = 13;
            this.chckDurum.Text = "Durum";
            this.chckDurum.UseVisualStyleBackColor = true;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(142, 277);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(166, 30);
            this.mskTC.TabIndex = 12;
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(142, 237);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(166, 28);
            this.cmbDoktor.TabIndex = 11;
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(142, 199);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(166, 28);
            this.cmbBrans.TabIndex = 10;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(142, 158);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(166, 30);
            this.mskSaat.TabIndex = 9;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(142, 117);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(166, 30);
            this.mskTarih.TabIndex = 8;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(142, 77);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(167, 30);
            this.txtid.TabIndex = 7;
            // 
            // lblRandevuTC
            // 
            this.lblRandevuTC.AutoSize = true;
            this.lblRandevuTC.Location = new System.Drawing.Point(8, 287);
            this.lblRandevuTC.Name = "lblRandevuTC";
            this.lblRandevuTC.Size = new System.Drawing.Size(115, 20);
            this.lblRandevuTC.TabIndex = 5;
            this.lblRandevuTC.Text = "T.C Kimlik No:";
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.Location = new System.Drawing.Point(58, 245);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(65, 20);
            this.lblDoktor.TabIndex = 4;
            this.lblDoktor.Text = "Doktor:";
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(66, 207);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(57, 20);
            this.lblBrans.TabIndex = 3;
            this.lblBrans.Text = "Branş:";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(77, 168);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(46, 20);
            this.lblSaat.TabIndex = 2;
            this.lblSaat.Text = "Saat:";
            //this.lblSaat.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(72, 127);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(51, 20);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(96, 80);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "id:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox5.Location = new System.Drawing.Point(788, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(546, 328);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(11, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(529, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox6.Location = new System.Drawing.Point(788, 346);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(546, 324);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(540, 290);
            this.dataGridView2.TabIndex = 1;
            // 
            // frmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1346, 682);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpSekreterBiilgi);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSekreterDetay";
            this.Text = "frmSekreterDetay";
            this.Load += new System.EventHandler(this.frmSekreterDetay_Load);
            this.grpSekreterBiilgi.ResumeLayout(false);
            this.grpSekreterBiilgi.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSekreterBiilgi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblAdSoyadDeger;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTCDeger;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Button btnDuyuru;
        private System.Windows.Forms.RichTextBox rchDuyuru;
        private System.Windows.Forms.Button btnRandevuListe;
        private System.Windows.Forms.Button btnBransPaneş;
        private System.Windows.Forms.Button btnDoktorpanel;
        private System.Windows.Forms.Label lblRandevuTC;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.CheckBox chckDurum;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnDuyurular;
    }
}