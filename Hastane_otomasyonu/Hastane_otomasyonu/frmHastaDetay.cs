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


namespace Hastane_otomasyonu
{
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTCDeger.Text = tc;
            
            //Kişi Bilgi Bölümü
            SqlCommand komut = new SqlCommand("Select HastaAd, HastaSoyad from Table_Hastalar where HastaTc = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1" , tc);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lblAdSoyadDeger.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu geçmişi Bölümü
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular where HastaTc = '" + tc + "'" + "and RandevuDurum = '"  + false + "'", bgl.baglanti());
            da.Fill(dt); //da'nın içini dt'den gelen verilerle doldurma işlemi!
            dataGridView1.DataSource = dt;

            //Randevu Paneli Bölümü
            SqlCommand komut2 = new SqlCommand("Select BransAd From Table_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From Table_Doktorlar where DoktorBrans = @p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while(dr3.Read())
            {
                comboBox2.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Table_Randevular where RandevuBrans='" + comboBox1.Text + "'" + "and RandevuDoktor='" + comboBox2.Text +"'" + " and RandevuDurum='" + true + "'" ,bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaBilgiDuzenle fr = new frmHastaBilgiDuzenle();
            fr.TC = lblTCDeger.Text; 
            fr.Show();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into Table_Randevular ( RandevuBrans, RandevuDoktor, RandevuDate, RandevuTime, HastaTC, HastaSikayet, RandevuDurum) values (@r1, @r2, @r3, @r4, @r5, @r6, @r7)", bgl.baglanti());
            kaydet.Parameters.AddWithValue("@r1", comboBox1.Text);
            kaydet.Parameters.AddWithValue("@r2", comboBox2.Text);
            kaydet.Parameters.AddWithValue("@r3", mskTarih.Text);
            kaydet.Parameters.AddWithValue("@r4", mskSaat.Text);
            kaydet.Parameters.AddWithValue("@r5", tc);
            kaydet.Parameters.AddWithValue("@r6", richTextBox1.Text);
            kaydet.Parameters.AddWithValue("@r7", true);
            kaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu!");
        }
    
    }
}
