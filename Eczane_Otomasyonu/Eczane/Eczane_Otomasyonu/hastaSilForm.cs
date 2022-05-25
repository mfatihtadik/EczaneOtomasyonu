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
    public partial class hastaSilForm : Form
    {
        SQL sqlkomut = new SQL();
        public hastaSilForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komutum = "delete  from Hasta_Table WHERE Tc=@tc";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlcomut.Parameters.AddWithValue("@tc", txtTC.Text);
            sqlkomut.komut(sqlcomut);
            Log logum = new Log();
            logum.log( "TC: " +txtTC.Text +" Silindi.","");
            this.Close();

        }

        private void hastaSilForm_Load(object sender, EventArgs e)
        {

        }
    }
}
