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

namespace Personel_Kayit
{
    public partial class frmGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-69DNETM\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        public frmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut01 = new SqlCommand("Select * From Table_2 Where KullaniciAd = @k1 and Sifre = @k2",baglanti);
            komut01.Parameters.AddWithValue("@k1", txtKullaniciAd.Text);
            komut01.Parameters.AddWithValue("@k2", maskedSifre.Text);
            SqlDataReader dr01 = komut01.ExecuteReader();

            if (dr01.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
            baglanti.Close();
        }
    }
}
