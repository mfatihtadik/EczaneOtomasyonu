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
    public partial class hastaGecmisiForm : Form
    {
        SQL S = new SQL();
        public hastaGecmisiForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHGuncelle_Click(object sender, EventArgs e)
        {
            hastaGuncelleForm hasgunfrm = new hastaGuncelleForm();
            hasgunfrm.txTc.DataBindings.Add("Text", bs, "Tc");
            hasgunfrm.textBox2.DataBindings.Add("Text", bs, "ad");
            hasgunfrm.textBox3.DataBindings.Add("Text", bs, "soyad");
            hasgunfrm.maskedTextBox1.DataBindings.Add("Text", bs, "tel");
            hasgunfrm.ShowDialog();
            verilericek();

        }

        private void btnHEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHSil_Click(object sender, EventArgs e)
        {
          
            hastaSilForm hasilfrm = new hastaSilForm();

            hasilfrm.txtTC.DataBindings.Add("Text", bs, "Tc");
            hasilfrm.textBox2.DataBindings.Add("Text", bs, "ad");
            hasilfrm.textBox3.DataBindings.Add("Text", bs, "soyad");
            hasilfrm.maskedTextBox1.DataBindings.Add("Text", bs, "tel");
            hasilfrm.ShowDialog();
            verilericek();


        }
        
       public DataSet ds = new DataSet();
       public BindingSource bs = new BindingSource();
        private void hastaGecmisiForm_Load(object sender, EventArgs e)
        {

            verilericek();

        }
        private void verilericek()
        {
            dataGridView1.DataSource = null;
          //  bs = null;
            string komut = "SELECT * FROM Hasta_Table";
            SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
            ds.Clear();
            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView1.DataSource = bs;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //  bs = null;
            string komut = "SELECT * FROM Hasta_Table where tc like '%" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
            ds.Clear();
            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView1.DataSource = bs;
        }
    }
}
