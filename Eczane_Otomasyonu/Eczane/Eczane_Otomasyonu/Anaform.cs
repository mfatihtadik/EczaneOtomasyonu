using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane_Otomasyonu
{
    public partial class Anaform : Form
    {
        SQL sqlkomut = new SQL();
        public Anaform()
        {
            InitializeComponent();
        }



        private void btnSatıs_MouseMove(object sender, MouseEventArgs e)
        {
            pbSatıs.BackColor = Color.FromArgb(218, 165, 32);
        }

        private void btnSatıs_MouseLeave(object sender, EventArgs e)
        {
            pbSatıs.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            pbStok.BackColor = Color.FromArgb(218, 165, 32);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pbStok.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            pbHastag.BackColor = Color.FromArgb(218, 165, 32);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            pbHastag.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void btnLog_MouseMove(object sender, MouseEventArgs e)
        {
            pbLog.BackColor = Color.FromArgb(218, 165, 32);
        }

        private void btnLog_MouseLeave(object sender, EventArgs e)
        {
            pbLog.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void Anaform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSatıs_Click(object sender, EventArgs e)
        {
            ilacSatis ilacs = new ilacSatis();
            ilacs.ShowDialog();
        }

        private void btnReceteSatis_Click(object sender, EventArgs e)
        {
 
        }

        private void btnReceteliSatis_Click(object sender, EventArgs e)
        {
            ReceteSatisForm rsForm = new ReceteSatisForm();
            rsForm.ShowDialog();
        }

        private void btnReceteliSatis_MouseMove(object sender, MouseEventArgs e)
        {
            pbRecSat.BackColor = Color.FromArgb(218, 165, 32);
        }

        private void btnReceteliSatis_MouseLeave(object sender, EventArgs e)
        {
            pbRecSat.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stokDurumForm stokdurfrm = new stokDurumForm();
            stokdurfrm.ShowDialog();
            Log logum = new Log();
            logum.log(" Stok incelendi.", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hastaGecmisiForm hasgecfrm = new hastaGecmisiForm();
            hasgecfrm.ShowDialog();
            Log logum = new Log();
            logum.log(" Hasta geçmişine girildi.", "");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {           
            if(girisForm.yetki.Trim()=="admin")
            {
                logKayitForm logfrm = new logKayitForm();
                logfrm.ShowDialog();

                Log logum = new Log();
                logum.log(" Log kayıtları incelendi.", "");
            }
            else
            {
                MessageBox.Show("Bu işlemi yalnızca admin yapabilir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log logum = new Log();
                logum.log(" Log kayıtlarına erişim engellendi.", "");
            }


            
        }

        private void btnKulislem_MouseMove(object sender, MouseEventArgs e)
        {
            pbKul.BackColor = Color.FromArgb(218, 165, 32);
        }

        private void btnKulislem_MouseLeave(object sender, EventArgs e)
        {
            pbKul.BackColor = Color.FromArgb(34, 36, 49);
        }

       
        private void btnKulislem_Click(object sender, EventArgs e)
        {
            
            if (girisForm.yetki.Trim()=="admin")
            {
                kulislemForm kifrm = new kulislemForm();
                kifrm.ShowDialog();

            }
            else
                MessageBox.Show("Bu işlemi yalnızca admin yapabilir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void pbKul_Click(object sender, EventArgs e)
        {

        }

        private void btnReceteOlustur_MouseMove(object sender, MouseEventArgs e)
        {
            //pbReceteOlustur.BackColor = Color.FromArgb(218, 165, 32);
            

        }

        private void btnReceteOlustur_MouseLeave(object sender, EventArgs e)
        {
           // pbReceteOlustur.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void btnReceteOlustur_Click(object sender, EventArgs e)
        {
            DoktorForm dkfrm = new DoktorForm();
            dkfrm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (girisForm.yetki.Trim() == "admin")
            {
                istatistikForm istfrm = new istatistikForm();
                istfrm.ShowDialog();

                Log logum = new Log();
                logum.log("İstatistik incelendi.", "");

            }
            else
            {
                MessageBox.Show("Bu işlemi yalnızca admin yapabilir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log logum = new Log();
                logum.log("İstatistik girişi engellendi.", "");
            }
                

        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(218, 165, 32);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (girisForm.yetki.Trim() == "admin")
            {

                raporlamaForm rpfrm = new raporlamaForm();
                rpfrm.ShowDialog();

                Log logum = new Log();
                logum.log("Raporlamaya giriş yapıldı.", "");

            }
            else
            {
                MessageBox.Show("Bu işlemi yalnızca admin yapabilir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log logum = new Log();
                logum.log("Raporlama girişi engellendi.", "");
            }


        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(218, 165, 32);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
        }
    }
}
