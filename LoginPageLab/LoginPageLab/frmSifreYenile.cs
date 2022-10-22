using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;


namespace LoginPageLab
{
    public partial class frmSifreYenile : Form
    {
        public frmSifreYenile()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-69DNETM\\SQLEXPRESS;Initial Catalog=LoginPage;Integrated Security=True");

        private void frmSifreYenile_Load(object sender, EventArgs e)
        {
        
        }
      
        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Login where eMail ='" + textBox1.Text.ToString()+ "'", baglanti);
            SqlDataReader dr = komut2.ExecuteReader();

            while (dr.Read()) {

                MailMessage mesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("denemehesabi_001@outlook.com", "958632Ee");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
                istemci.EnableSsl = true;
                mesaj.To.Add(dr["eMail"].ToString());
                mesaj.From = new MailAddress("denemehesabi_001@outlook.com");
                mesaj.Subject = "Şifre Yenileme";
                mesaj.Body = "Hesabınızın şifresi = " + dr["sifre"].ToString();
                istemci.Send(mesaj);
                baglanti.Close();
                MessageBox.Show("Doğrulama kodu e-mail adresinize gönderildi");

            }
        }

    }
}
