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
    public partial class frmDoktorDetay : Form
    {
        public string tc;
        sqlBaglantisi bgl = new sqlBaglantisi();
        public frmDoktorDetay()
        {
            InitializeComponent();
        }
        
        private void frmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblDoktorTCDeger.Text = tc;
            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad from Table_Doktorlar where DoktorTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lblDoktorAdSoyadDeger.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular Bölümü

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular where RandevuDoktor='" + lblDoktorAdSoyadDeger + "'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular fr = new frmDuyurular();
            fr.Show();
        }
    }
}
