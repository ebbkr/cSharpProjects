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

namespace LoginPageLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-69DNETM\\SQLEXPRESS;Initial Catalog=LoginPage;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifreYenile fr = new frmSifreYenile();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Login Where KullaniciAdi=@p1 and Sifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
           
            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                MessageBox.Show("Giriş Başarılı!");
            } 
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı! \nLütfen tekrar deneyin ya da şifre yenileme sayfasına gidin.");
            }

            baglanti.Close();
                
        }
    }
}
