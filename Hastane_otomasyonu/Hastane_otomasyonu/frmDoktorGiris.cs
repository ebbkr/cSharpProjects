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
    public partial class frmDoktorGiris : Form
    {

        sqlBaglantisi bgl = new sqlBaglantisi();
        public frmDoktorGiris()
        {
            InitializeComponent();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Table_Doktorlar Where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());          
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                frmDoktorDetay fr = new frmDoktorDetay();
                fr.tc = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Girdiniz!");
            }
            bgl.baglanti().Close();
        }

        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
