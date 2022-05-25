using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Eczane_Otomasyonu
{
    public partial class girisForm : Form
    {
        public girisForm()
        {
            InitializeComponent();
        }

         SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SL8FJJ5;Initial Catalog=ECZANE;Integrated Security=True");
        public static string kuladi,yetki;
        
      
        
        
        



        private void btnGiris_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();
                string sql = "Select * From Kullanicigiris_tab where Kullanici_adi=@adi AND Parola=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", txtKadi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);


  
            if (dt.Rows.Count > 0)
            {
                    SqlDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    yetki = oku["Yetki"].ToString();
                    kuladi = oku["Kullanici_adi"].ToString();
                    if (girisForm.yetki.Trim() == "doktor")
                    {
                          DoktorForm dkfrm = new DoktorForm();
                          dkfrm.ShowDialog();
                     }
                    Anaform anfrm = new Anaform();
                    anfrm.Show();
                    this.Hide();
            }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata");
                    baglanti.Close();

                    txtKadi.Clear();
                    txtKadi.Focus();
                    pbKlogo.BackgroundImage = Properties.Resources.kadi_logo2; //txtKadi ye tıklandıgında fotoları ve texti maviye çeviriyor.
                    txtKadi.ForeColor = Color.FromArgb(78, 184, 206);
                    pnl1.BackColor = Color.FromArgb(78, 184, 206);


                    txtSifre.Clear();
                    pbSlogo.BackgroundImage = Properties.Resources.sifrelogo;  //Şifre kısmını standart hale getiriyor.
                    txtSifre.ForeColor = Color.WhiteSmoke;
                    pnl2.BackColor = Color.WhiteSmoke;




            }



        }

        private void txtKadi_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text == "Kullanıcı Adı")
            {
                txtKadi.Clear();
            }

            pbKlogo.BackgroundImage = Properties.Resources.kadi_logo2; //txtKadi ye tıklandıgında fotoları ve texti maviye çeviriyor.
            txtKadi.ForeColor = Color.FromArgb(78, 184, 206);
            pnl1.BackColor = Color.FromArgb(78, 184, 206);

            pbSlogo.BackgroundImage = Properties.Resources.sifrelogo;  //Şifre kısmını standart hale getiriyor.
            txtSifre.ForeColor = Color.WhiteSmoke;
            pnl2.BackColor = Color.WhiteSmoke;
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Clear();
            }
            //Burda zıt kodları yazdık böylece hangisine tıklanırsa o mavi, diğeri standart olacak...

            txtSifre.PasswordChar = '*';
            pbSlogo.BackgroundImage = Properties.Resources.sifrelogo2;
            txtSifre.ForeColor = Color.FromArgb(78, 184, 206);
            pnl2.BackColor = Color.FromArgb(78, 184, 206);

            pbKlogo.BackgroundImage = Properties.Resources.kadi_logo;
            txtKadi.ForeColor = Color.WhiteSmoke;
            pnl1.BackColor = Color.WhiteSmoke;
        }

        private void girisForm_Load(object sender, EventArgs e)
        {

        }

        private void pbKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
