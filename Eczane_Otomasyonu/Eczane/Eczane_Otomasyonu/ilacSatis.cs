using Eczane_Otomasyonu.Classlar;
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
    public partial class ilacSatis : Form
    {
        SQL s = new SQL();
        List<ilac> ilaclar = new List<ilac>();
        ilac ilac = new ilac();
        public DataSet ds = new DataSet();

        public DataSet ds2 = new DataSet();

        public BindingSource bs = new BindingSource();

        public BindingSource bsbarkod = new BindingSource();
        public ilacSatis()
        {
            InitializeComponent();
        }

        SQL sqlkomut = new SQL();
        private void button1_Click(object sender, EventArgs e)
        {
            //secilenİlaclar.Items.Add(txtIlacara.Text+comboBox2.SelectedValue + " " + numericUpDown1.Value);

            string komutum = "insert into GeciciSatis_Table (ad,barkod,adet,fiyat) Values (@ad,@barkod,@adet,@fiyat)";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlcomut.Parameters.AddWithValue("@ad",dataGridView1.CurrentRow.Cells[1].Value);
            sqlcomut.Parameters.AddWithValue("@barkod", dataGridView1.CurrentRow.Cells[0].Value);
            sqlcomut.Parameters.AddWithValue("@adet", numericUpDown1.Value);
            sqlcomut.Parameters.AddWithValue("@fiyat", dataGridView1.CurrentRow.Cells[3].Value);
            sqlkomut.komut(sqlcomut);

            secilenİlaclar.Items.Add(dataGridView1.CurrentRow.Cells[1].Value + " -->" + numericUpDown1.Value + " adet");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ilacSatis_Load(object sender, EventArgs e)
        {
            verilericek();
            urunlericek();

        }



        private void verilericek()
        {

            dataGridView1.DataSource = null;
            //  bs = null;
            string komut = "SELECT * FROM İlac_Table";
            SqlDataAdapter da = new SqlDataAdapter(komut, s.baglantikur());
            ds.Clear();

            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView1.DataSource = bs;

        }

        private void urunlericek()
        {
            comboBox2.DataSource = null;
            //  bs = null;
            string komut = "SELECT barkod FROM İlac_Table";
            SqlDataAdapter da = new SqlDataAdapter(komut, s.baglantikur());
            ds2.Clear();

            da.Fill(ds2, "tablom");
            bsbarkod.DataSource = ds2.Tables["tablom"];
            comboBox2.DisplayMember = "barkod";
            comboBox2.ValueMember = "barkod";
            comboBox2.DataSource = bsbarkod;

        }

        private void txtIlacara_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //  bs = null;
            string komut = "SELECT * FROM İlac_Table where ad like '%" + txtIlacara.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(komut, s.baglantikur());
            ds.Clear();

            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView1.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odemeForm odefrm = new odemeForm();
            odefrm.ShowDialog();











            

             // Satış İşlemleri bittikten sonra Geçici tabloyu temizledik... 
            string komutum = "delete  from GeciciSatis_Table";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlkomut.komut(sqlcomut);

            secilenİlaclar.Items.Clear(); //Listboxu temizledik

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Listboxu ve Geçiçi tabloyu temizledik
            string komutum = "delete  from GeciciSatis_Table";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlkomut.komut(sqlcomut);

            secilenİlaclar.Items.Clear(); 
        }
    }
}
