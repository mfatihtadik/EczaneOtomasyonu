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
    public partial class urunEkleForm : Form
    {

        SQL S = new SQL();
        public urunEkleForm()
        {
          

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunEkleForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komutum = "insert into İlac_Table (ad,adet,fiyat) Values (@ad,@adet,@fiyat)";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            // sqlcomut.Parameters.AddWithValue("@barkod", textBox1.Text);
            sqlcomut.Parameters.AddWithValue("@ad", textBox2.Text);
            sqlcomut.Parameters.AddWithValue("@adet", numericUpDown1.Text);
            sqlcomut.Parameters.AddWithValue("@fiyat", textBox3.Text);
            //sqlcomut.Parameters.AddWithValue("@kutu", numericUpDown1.Text);
            S.komut(sqlcomut);
            Log logum = new Log();
            logum.log(textBox2.Text+"adlı ürün eklendi", "");

            MessageBox.Show(textBox2.Text+" adlı ürün eklendi");
          



        }
    }
}
