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
    public partial class kullaniciguncelleForm : Form
    {
        SQL sqlkomut = new SQL();
        public kullaniciguncelleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string komutum = "UPDATE Kullanicigiris_tab SET Kullanici_adi=@ad,Parola=@sifre,Yetki=@yetki WHERE Eczane_id=@id";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlcomut.Parameters.AddWithValue("@ad", textBox1.Text);
            sqlcomut.Parameters.AddWithValue("@sifre", textBox2.Text);
            sqlcomut.Parameters.AddWithValue("@yetki", comboBox1.Text);
            sqlcomut.Parameters.AddWithValue("@id", textBox3.Text);
            sqlkomut.komut(sqlcomut);
            Log logum = new Log();
            logum.log(textBox1.Text + " adlı kişi guncellendi", "");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
