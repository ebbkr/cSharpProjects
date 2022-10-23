namespace Hastane_otomasyonu
{
    partial class frmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorDetay));
            this.grpDoktorBilgi = new System.Windows.Forms.GroupBox();
            this.lblDoktorAdSoyadDeger = new System.Windows.Forms.Label();
            this.lblDoktorAdSoyad = new System.Windows.Forms.Label();
            this.lblDoktorTCDeger = new System.Windows.Forms.Label();
            this.lbDoktorlTC = new System.Windows.Forms.Label();
            this.grpRandevuDetay = new System.Windows.Forms.GroupBox();
            this.rchTxtRandevuDetay = new System.Windows.Forms.RichTextBox();
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.grpRandevuList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpDoktorBilgi.SuspendLayout();
            this.grpRandevuDetay.SuspendLayout();
            this.grpIslemler.SuspendLayout();
            this.grpRandevuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDoktorBilgi
            // 
            this.grpDoktorBilgi.Controls.Add(this.lblDoktorAdSoyadDeger);
            this.grpDoktorBilgi.Controls.Add(this.lblDoktorAdSoyad);
            this.grpDoktorBilgi.Controls.Add(this.lblDoktorTCDeger);
            this.grpDoktorBilgi.Controls.Add(this.lbDoktorlTC);
            this.grpDoktorBilgi.ForeColor = System.Drawing.SystemColors.Control;
            this.grpDoktorBilgi.Location = new System.Drawing.Point(12, 12);
            this.grpDoktorBilgi.Name = "grpDoktorBilgi";
            this.grpDoktorBilgi.Size = new System.Drawing.Size(393, 203);
            this.grpDoktorBilgi.TabIndex = 1;
            this.grpDoktorBilgi.TabStop = false;
            this.grpDoktorBilgi.Text = "Doktor Bilgi";
            // 
            // lblDoktorAdSoyadDeger
            // 
            this.lblDoktorAdSoyadDeger.AutoSize = true;
            this.lblDoktorAdSoyadDeger.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoktorAdSoyadDeger.Location = new System.Drawing.Point(161, 124);
            this.lblDoktorAdSoyadDeger.Name = "lblDoktorAdSoyadDeger";
            this.lblDoktorAdSoyadDeger.Size = new System.Drawing.Size(79, 20);
            this.lblDoktorAdSoyadDeger.TabIndex = 3;
            this.lblDoktorAdSoyadDeger.Text = "__________";
            // 
            // lblDoktorAdSoyad
            // 
            this.lblDoktorAdSoyad.AutoSize = true;
            this.lblDoktorAdSoyad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoktorAdSoyad.Location = new System.Drawing.Point(68, 124);
            this.lblDoktorAdSoyad.Name = "lblDoktorAdSoyad";
            this.lblDoktorAdSoyad.Size = new System.Drawing.Size(85, 20);
            this.lblDoktorAdSoyad.TabIndex = 2;
            this.lblDoktorAdSoyad.Text = "Ad Soyad:";
            // 
            // lblDoktorTCDeger
            // 
            this.lblDoktorTCDeger.AutoSize = true;
            this.lblDoktorTCDeger.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoktorTCDeger.Location = new System.Drawing.Point(161, 66);
            this.lblDoktorTCDeger.Name = "lblDoktorTCDeger";
            this.lblDoktorTCDeger.Size = new System.Drawing.Size(108, 20);
            this.lblDoktorTCDeger.TabIndex = 1;
            this.lblDoktorTCDeger.Text = "00000000000";
            // 
            // lbDoktorlTC
            // 
            this.lbDoktorlTC.AutoSize = true;
            this.lbDoktorlTC.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDoktorlTC.Location = new System.Drawing.Point(38, 66);
            this.lbDoktorlTC.Name = "lbDoktorlTC";
            this.lbDoktorlTC.Size = new System.Drawing.Size(115, 20);
            this.lbDoktorlTC.TabIndex = 0;
            this.lbDoktorlTC.Text = "T.C Kimlik No:";
            // 
            // grpRandevuDetay
            // 
            this.grpRandevuDetay.Controls.Add(this.rchTxtRandevuDetay);
            this.grpRandevuDetay.ForeColor = System.Drawing.SystemColors.Control;
            this.grpRandevuDetay.Location = new System.Drawing.Point(12, 232);
            this.grpRandevuDetay.Name = "grpRandevuDetay";
            this.grpRandevuDetay.Size = new System.Drawing.Size(393, 248);
            this.grpRandevuDetay.TabIndex = 2;
            this.grpRandevuDetay.TabStop = false;
            this.grpRandevuDetay.Text = "Randevu Detay";
            // 
            // rchTxtRandevuDetay
            // 
            this.rchTxtRandevuDetay.Location = new System.Drawing.Point(12, 33);
            this.rchTxtRandevuDetay.Name = "rchTxtRandevuDetay";
            this.rchTxtRandevuDetay.Size = new System.Drawing.Size(367, 204);
            this.rchTxtRandevuDetay.TabIndex = 0;
            this.rchTxtRandevuDetay.Text = "";
            // 
            // grpIslemler
            // 
            this.grpIslemler.Controls.Add(this.btnCikis);
            this.grpIslemler.Controls.Add(this.btnDuyurular);
            this.grpIslemler.ForeColor = System.Drawing.SystemColors.Control;
            this.grpIslemler.Location = new System.Drawing.Point(13, 502);
            this.grpIslemler.Name = "grpIslemler";
            this.grpIslemler.Size = new System.Drawing.Size(391, 187);
            this.grpIslemler.TabIndex = 3;
            this.grpIslemler.TabStop = false;
            this.grpIslemler.Text = "İşlemler";
            // 
            // btnCikis
            // 
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCikis.Location = new System.Drawing.Point(110, 117);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(158, 51);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDuyurular.Location = new System.Drawing.Point(110, 38);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(158, 51);
            this.btnDuyurular.TabIndex = 1;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // grpRandevuList
            // 
            this.grpRandevuList.Controls.Add(this.dataGridView1);
            this.grpRandevuList.ForeColor = System.Drawing.SystemColors.Control;
            this.grpRandevuList.Location = new System.Drawing.Point(423, 12);
            this.grpRandevuList.Name = "grpRandevuList";
            this.grpRandevuList.Size = new System.Drawing.Size(803, 676);
            this.grpRandevuList.TabIndex = 4;
            this.grpRandevuList.TabStop = false;
            this.grpRandevuList.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(797, 647);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1242, 714);
            this.Controls.Add(this.grpRandevuList);
            this.Controls.Add(this.grpIslemler);
            this.Controls.Add(this.grpRandevuDetay);
            this.Controls.Add(this.grpDoktorBilgi);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmDoktorDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.frmDoktorDetay_Load);
            this.grpDoktorBilgi.ResumeLayout(false);
            this.grpDoktorBilgi.PerformLayout();
            this.grpRandevuDetay.ResumeLayout(false);
            this.grpIslemler.ResumeLayout(false);
            this.grpRandevuList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDoktorBilgi;
        private System.Windows.Forms.Label lblDoktorAdSoyadDeger;
        private System.Windows.Forms.Label lblDoktorAdSoyad;
        private System.Windows.Forms.Label lblDoktorTCDeger;
        private System.Windows.Forms.Label lbDoktorlTC;
        private System.Windows.Forms.GroupBox grpRandevuDetay;
        private System.Windows.Forms.GroupBox grpIslemler;
        private System.Windows.Forms.GroupBox grpRandevuList;
        private System.Windows.Forms.RichTextBox rchTxtRandevuDetay;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}