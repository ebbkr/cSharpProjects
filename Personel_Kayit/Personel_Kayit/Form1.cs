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
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void temizle() {

            textAd.Text = "";
            txtSoyad.Text = "";
            comboSehir.Text = "";
            maskedMaas.Text = "";
            txtMeslek.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textAd.Focus();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-69DNETM\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButton1.Checked == true )
            {
                label8.Text = "True";
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {              
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.table_1TableAdapter.Fill(this.personelVeriTabaniDataSet.Table_1);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Table_1 (PersAd,PersSoyad,PersSehir,PersMaas,PersMeslek,PersDurum) values (@p1, @p2, @p3, @p4, @p5, @p6)",baglanti);
            
            komut.Parameters.AddWithValue("@p1", textAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboSehir.Text);
            komut.Parameters.AddWithValue("@p4", maskedMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void textAd_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtPersonelid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true; 
            }
            if(label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Table_1 Where personelid = @k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtPersonelid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı!");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update Table_1 Set persAd = @a1, persSoyad = @a2, persSehir = @a3, persMaas = @a4, persDurum = @a5, persMeslek = @a6 where personelid = @a7",baglanti);
          
            komutguncelle.Parameters.AddWithValue("@a1", textAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", comboSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", maskedMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtPersonelid.Text);
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
        }


        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistik ist = new frmIstatistik();
            ist.Show();
        }

        private void BtnGrafikler_Click_1(object sender, EventArgs e)
        {
            frmGrafikler grf = new frmGrafikler();
            grf.Show();
        }
    }
}
