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
    public partial class kullanicisilForm : Form
    {
        SQL sqlkomut = new SQL();
        public kullanicisilForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komutum = "delete  from Kullanicigiris_tab WHERE Eczane_id=@id";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlcomut.Parameters.AddWithValue("@id", textBox3.Text);
            sqlkomut.komut(sqlcomut);
            Log logum = new Log();
            logum.log(textBox1.Text + " adlı kişi silindi", "");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
