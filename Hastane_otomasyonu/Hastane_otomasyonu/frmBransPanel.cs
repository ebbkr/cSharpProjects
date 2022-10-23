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
    public partial class frmBransPanel : Form
    {
        sqlBaglantisi bgl = new sqlBaglantisi();
        public frmBransPanel()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBransPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Table_Branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            SqlCommand ekle = new SqlCommand("insert into Table_Branslar (BransAd) values (@b1)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@b1", txtBransAd.Text);
            
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni brans eklendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From Table_Branslar where Bransid = @i1", bgl.baglanti());
            sil.Parameters.AddWithValue("@i1", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Başarılı!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update Table_Branslar set BransAd=@b1 Where Bransid=@b2", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@b1", txtBransAd.Text);
            guncelle.Parameters.AddWithValue("@b2", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
