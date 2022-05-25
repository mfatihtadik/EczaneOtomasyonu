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
    public partial class hastaEkleForm : Form
    {
        public static string tc;

        SQL sqlkomut = new SQL();
        public hastaEkleForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komutum = "insert into Hasta_Table (Tc,ad,soyad,tel) Values (@Tc,@ad,@soyad,@tel)";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlcomut.Parameters.AddWithValue("@Tc", txTc.Text);
            sqlcomut.Parameters.AddWithValue("@ad", textBox2.Text);
            sqlcomut.Parameters.AddWithValue("@soyad", textBox3.Text);
            sqlcomut.Parameters.AddWithValue("@tel", maskedTextBox1.Text);
            sqlkomut.komut(sqlcomut);
            Log logum = new Log();
            logum.log("Yeni kişi eklendi","");
            this.Close();
        }

        private void hastaEkleForm_Load(object sender, EventArgs e)
        {
            txTc.Text = tc;
        }
    }
}
