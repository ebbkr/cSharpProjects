using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hastane_otomasyonu
{

    public partial class frmSekreterDetay : Form
    {

        sqlBaglantisi bgl = new sqlBaglantisi();

        public string sekreterTC;
        public frmSekreterDetay()
        {
            InitializeComponent();
        }


        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            //Sekreter Bilgi Bölümü
            lblTCDeger.Text = sekreterTC;
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Table_Sekreterler where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTCDeger.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while(dr1.Read())
            {
                lblAdSoyadDeger.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşlar Bölümü
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1= new SqlDataAdapter("Select * From Table_Branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorlar Bölümü
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select Doktorid, (DoktorAd +' '+DoktorSoyad),DoktorBrans, DoktorTC From Table_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        
            //Branslari Combobox'a Aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Table_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
            {
            //Doktorlari Combobox'a Aktarma
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select (DoktorAd+' '+DoktorSoyad) From Table_Doktorlar where DoktorBrans=@b1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@b1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
            }

        //Randevu Paneli Bölümü
        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into Table_Randevular (RandevuDate, RandevuTime, RandevuBrans, RandevuDoktor, HastaTC) values (@r1, @r2, @r3, @r4, @r5)",bgl.baglanti());
            kaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            kaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            kaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            kaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            kaydet.Parameters.AddWithValue("@r5", mskTC.Text);
            kaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu!");
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            SqlCommand duyuru = new SqlCommand("insert into Table_Duyurular (Duyuru) values (@d1)",bgl.baglanti());
            duyuru.Parameters.AddWithValue("d1",rchDuyuru.Text);
            duyuru.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu!");
        }

        private void btnDoktorpanel_Click(object sender, EventArgs e)
        {
            frmDoktorPanel fr = new frmDoktorPanel();
            fr.Show();
        }

        private void btnBransPaneş_Click(object sender, EventArgs e)
        {
            frmBransPanel frm = new frmBransPanel();
            frm.Show();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            frmRandevuList frmL = new frmRandevuList();
            frmL.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular frmD = new frmDuyurular();
            frmD.Show();
        }
    }
}
