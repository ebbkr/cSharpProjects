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
    public partial class frmDoktorPanel : Form
    {
        sqlBaglantisi bgl = new sqlBaglantisi();

        public frmDoktorPanel()
        {
            InitializeComponent();
        }

        private void frmDoktorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Table_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            
            //Branslari Combobox'a Aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Table_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        // Yeni Doktor Kaydı
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Doktorlar (DoktorAd, DoktorSoyad, DoktorTC, DoktorBrans, DoktorSifre) values (@d1, @d2, @d3, @d4, @d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", mskTC.Text);
            komut.Parameters.AddWithValue("@d4", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d5", mskSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Doktor Kaydı Oluşturuldu!");
        }

        //Tıklanan satırdaki verileri boxlara getirme
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();           
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        //Doktor Kaydı Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Table_Doktorlar where DoktorTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi!");
        }

        //Doktor Kaydı Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Table_Doktorlar set DoktorAd=@d1, DoktorSoyad=@d2, DoktorBrans=@d4, DoktorSifre=@d5 Where DoktorTC=@d3",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);              
            komut.Parameters.AddWithValue("@d4", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d5", mskSifre.Text);
            komut.Parameters.AddWithValue("@d3", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi!");
        }
    }
}
