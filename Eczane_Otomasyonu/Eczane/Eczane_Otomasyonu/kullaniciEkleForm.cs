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

namespace Eczane_Otomasyonu
{
    public partial class kullaniciEkleForm : Form
    {
        SQL sqlkomut = new SQL();
        public kullaniciEkleForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komutum = "insert into Kullanicigiris_tab (Kullanici_adi,Parola,Yetki) Values (@Kullanici_adi,@Parola,@Yetki)";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlcomut.Parameters.AddWithValue("@Kullanici_adi", textBox1.Text);
            sqlcomut.Parameters.AddWithValue("@Parola", textBox2.Text);
            sqlcomut.Parameters.AddWithValue("@Yetki", comboBox1.Text);
            sqlkomut.komut(sqlcomut);
            Log logum = new Log();
            logum.log(textBox1.Text+" adlı kişi eklendi", "");
            this.Close();
        }
    }
}
