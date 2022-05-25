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
    public partial class stokDurumForm : Form
    {
        public DataSet ds = new DataSet();
        public BindingSource bs = new BindingSource();
        SQL S = new SQL();
        public stokDurumForm()
        {
            InitializeComponent();
        }
        
        private void btnUrunekle_Click(object sender, EventArgs e)
        {
            if (girisForm.yetki.Trim() == "admin")
            {
                urunEkleForm urunekfrm = new urunEkleForm();

                urunekfrm.ShowDialog();
                verilericek();
            }
            else
                MessageBox.Show("Bu işlemi yalnızca admin yapabilir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUrunguncelle_Click(object sender, EventArgs e)
        {
           
            if (girisForm.yetki.Trim() == "admin")
            {

                urunGuncelleForm urungunfrm = new urunGuncelleForm();
                urungunfrm.textBox1.DataBindings.Add("Text", bs, "barkod");
                urungunfrm.textBox2.DataBindings.Add("Text", bs, "ad");
                urungunfrm.textBox3.DataBindings.Add("Text", bs, "fiyat");
                urungunfrm.numericUpDown1.DataBindings.Add("Text", bs, "adet");
                urungunfrm.ShowDialog();
                verilericek();
                

            }
            else
                MessageBox.Show("Bu işlemi yalnızca admin yapabilir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        

        private void btnUrunsil_Click(object sender, EventArgs e)
        {
            if (girisForm.yetki.Trim() == "admin")
            {
                urunSilForm urunsilfrm = new urunSilForm();
                urunsilfrm.textBox1.DataBindings.Add("Text", bs, "barkod");
                urunsilfrm.textBox2.DataBindings.Add("Text", bs, "ad");
                urunsilfrm.textBox3.DataBindings.Add("Text", bs, "adet");
                urunsilfrm.textBox4.DataBindings.Add("Text", bs, "fiyat");
                urunsilfrm.numericUpDown1.DataBindings.Add("Text", bs, "kutu");
                urunsilfrm.ShowDialog();
                verilericek();
            }
            else
                MessageBox.Show("Bu işlemi yalnızca admin yapabilir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
      

        private void stokDurumForm_Load(object sender, EventArgs e)
        {
            verilericek();
        }



        private void verilericek()
        {
            dataGridView1.DataSource = null;
            //  bs = null;
            string komut = "SELECT * FROM İlac_Table";
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
            string komut = "SELECT * FROM İlac_Table where ad like '%"+textBox1.Text+"%'";
            SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
            ds.Clear();
            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView1.DataSource = bs;
        }
    }
}
