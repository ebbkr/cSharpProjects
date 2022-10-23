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
    public partial class frmSekreterGiris : Form
    {
        sqlBaglantisi bgl = new sqlBaglantisi();
        public frmSekreterGiris()
        {
            InitializeComponent();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Table_Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);  
            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                frmSekreterDetay fr = new frmSekreterDetay();
                fr.sekreterTC = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Hatalı!");
            }
            bgl.baglanti().Close();

        }
    }
}
