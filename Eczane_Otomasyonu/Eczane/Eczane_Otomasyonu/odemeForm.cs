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
    public partial class odemeForm : Form
    {
        public odemeForm()
        {
            InitializeComponent();
        }
        public DataSet ds = new DataSet();
        public BindingSource bs = new BindingSource();
        SQL s = new SQL();

        private void verilericek()
        {

            dataGridView1.DataSource = null;
            //  bs = null;
            string komut = "SELECT * FROM GeciciSatis_Table";
            SqlDataAdapter da = new SqlDataAdapter(komut, s.baglantikur());
            ds.Clear();

            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView1.DataSource = bs;

        }

        private void odemeForm_Load(object sender, EventArgs e)
        {
            verilericek();


            // string komut ="SELECT SUM(fiyat) FROM GeciciSatis_Table";
            //SqlDataAdapter da = new SqlDataAdapter(komut, s.baglantikur());


            string baglantiCumlesi = "Data Source=localhost;Initial Catalog=ECZANE;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            string sorgu = "SELECT SUM(fiyat) FROM GeciciSatis_Table";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            textBox1.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string baglantiCumlesi = "Data Source=localhost;Initial Catalog=ECZANE;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
           

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                baglanti.Open();
                int adeger = int.Parse(dataGridView1.Rows[i].Cells["adet"].Value.ToString());
                int bdeger = int.Parse(dataGridView1.Rows[i].Cells["barkod"].Value.ToString());
                string sorgu = "UPDATE İlac_Table SET adet=adet-'" + adeger + "' WHERE barkod='" + bdeger + "'";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }


            Log logum = new Log();
            logum.log(textBox1.Text+" Tutarında satış yapıldı.", "");
            this.Close();
            
        }
    }
}
