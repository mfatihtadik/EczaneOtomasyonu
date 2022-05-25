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
    public partial class logKayitForm : Form
    {
        BindingSource bs = new BindingSource();
        DataSet ds = new DataSet();
        SQL s = new SQL();
        public logKayitForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logKayitForm_Load(object sender, EventArgs e)
        {
            verilericek();
        }
  
        private void verilericek()
        {
            dataGridView1.DataSource = null;
            //  bs = null;
            string komut = "SELECT * FROM Log_Table";
            SqlDataAdapter da = new SqlDataAdapter(komut, s.baglantikur());
            ds.Clear();
            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView1.DataSource = bs;
        }
    }
}
