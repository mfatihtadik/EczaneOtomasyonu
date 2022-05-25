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
    public partial class urunSilForm : Form
    {
        SQL s = new SQL();
        public urunSilForm()
        {
            InitializeComponent();
        }

        private void urunSilForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komutum = "delete  from İlac_Table WHERE barkod=@barkod";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlcomut.Parameters.AddWithValue("@barkod", textBox1.Text);
            s.komut(sqlcomut);
            Log logum = new Log();
            logum.log("ilaç: " + textBox1.Text + " Silindi.", "admin");


        }
    }
}
