using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane_Otomasyonu
{
    public partial class urunGuncelleForm : Form
    {
        SQL s = new SQL();

        public urunGuncelleForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunGuncelleForm_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komutum = "UPDATE İlac_Table SET  ad=@ad, adet=@adet,fiyat=@fiyat   WHERE barkod=@barkod";
            SqlCommand sqlcomut = new SqlCommand(komutum);

            double yfiyat = Convert.ToDouble(textBox3.Text);
            yfiyat.ToString("0.#");
            sqlcomut.Parameters.AddWithValue("@ad", textBox2.Text);
            sqlcomut.Parameters.AddWithValue("@fiyat", yfiyat);
            sqlcomut.Parameters.AddWithValue("@adet", numericUpDown1.Text);
            sqlcomut.Parameters.AddWithValue("@barkod", textBox1.Text);
            s.komut(sqlcomut);
            Log logum = new Log();
            logum.log("Ürün: " + textBox1.Text + " Güncellendi.", "admin");
        }
    }
}
