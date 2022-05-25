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
    public partial class hastaGuncelleForm : Form
    {

        SQL sqlkomut = new SQL();
        public hastaGuncelleForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komutum = "UPDATE Hasta_Table SET ad=@ad,soyad=@soyad,tel=@tel   WHERE Tc=@tc";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlcomut.Parameters.AddWithValue("@ad", textBox2.Text);
            sqlcomut.Parameters.AddWithValue("@soyad", textBox3.Text);
            sqlcomut.Parameters.AddWithValue("@tel", maskedTextBox1.Text);
            sqlcomut.Parameters.AddWithValue("@tc",txTc.Text);
            sqlkomut.komut(sqlcomut);
            Log logum = new Log();
            logum.log("TC: " + txTc.Text + " Güncellendi.", "");
            this.Close();

        }

        private void hastaGuncelleForm_Load(object sender, EventArgs e)
        {
        }
    }
}
