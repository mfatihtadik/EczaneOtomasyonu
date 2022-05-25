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
    public partial class receteliodemeForm : Form
    {
        SQL sqlkomut = new SQL();
        SQL sqlkomut2 = new SQL();
        public receteliodemeForm()
        {
            InitializeComponent();
        }
        public DataSet ds = new DataSet();
        public BindingSource bs = new BindingSource();
        SQL s = new SQL();


        public DataSet ds2 = new DataSet();
        public BindingSource bs2 = new BindingSource();
        SQL s2 = new SQL();

        public DataSet ds4 = new DataSet();
        public BindingSource bs4 = new BindingSource();
        SQL s4 = new SQL();



        private void receteliodemeForm_Load(object sender, EventArgs e)
        {
            int i = 0;


            dataGridView3.DataSource = null;
            //  bs = null;
            string komut4 = "SELECT * FROM recete_ilac_table where recete_id='" + ReceteSatisForm.recbarkod + "'";
            SqlDataAdapter da4 = new SqlDataAdapter(komut4, s4.baglantikur());
            ds4.Clear();
            da4.Fill(ds4, "tablom");
            bs4.DataSource = ds4.Tables["tablom"];
            dataGridView3.DataSource = bs4;




            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-SL8FJJ5;Initial Catalog=ECZANE;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM recete_ilac_table where recete_id='" + ReceteSatisForm.recbarkod + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
                //label3.Text += dr["barkod"];
                string test = dr["barkod"].ToString();

                dataGridView1.DataSource = null;
                //  bs = null;
                string komut2 = "SELECT * FROM İlac_Table where barkod='" + test + "'";
                SqlDataAdapter da2 = new SqlDataAdapter(komut2, s.baglantikur());
                

                da2.Fill(ds, "tablom");
                bs.DataSource = ds.Tables["tablom"];
                dataGridView1.DataSource = bs;


                string komutum = "insert into GeciciSatis_Table (ad,barkod,adet,fiyat) Values (@ad,@barkod,@adet,@fiyat)";
                SqlCommand sqlcomut = new SqlCommand(komutum);
                sqlcomut.Parameters.AddWithValue("@ad", dataGridView1.CurrentRow.Cells[1].Value);
                sqlcomut.Parameters.AddWithValue("@barkod", dataGridView1.CurrentRow.Cells[0].Value);
                //sqlcomut.Parameters.AddWithValue("@adet", dataGridView1.CurrentRow.Cells[2].Value);
                sqlcomut.Parameters.AddWithValue("@adet", dataGridView3.Rows[i].Cells[2].Value.ToString());
                sqlcomut.Parameters.AddWithValue("@fiyat", dataGridView1.CurrentRow.Cells[3].Value);
                sqlkomut.komut(sqlcomut);
                ds.Clear();
                i++;
            }
            baglanti.Close();



            dataGridView2.DataSource = null;
            //  bs = null;
            string komut3 = "SELECT * FROM GeciciSatis_Table";
            SqlDataAdapter da = new SqlDataAdapter(komut3, s.baglantikur());
            ds.Clear();

            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView2.DataSource = bs;




            //Fiyat Hesaplama...

            string baglantiCumlesi5 = "Data Source=localhost;Initial Catalog=ECZANE;Integrated Security=True";
            SqlConnection baglanti5 = new SqlConnection(baglantiCumlesi5);
            string sorgu5 = "SELECT SUM(fiyat) FROM GeciciSatis_Table";
            SqlCommand komut5 = new SqlCommand(sorgu5, baglanti5);
            baglanti5.Open();
            textBox1.Text = komut5.ExecuteScalar().ToString();
            baglanti5.Close();

            double toplam = 0;
            double sat = Convert.ToDouble(textBox1.Text);
            toplam = sat * 20 / 100;
            textBox2.Text = Convert.ToString(toplam);











            //"SELECT * FROM recete_ilac where recete_id='" + ReceteSatisForm.recbarkod + "'";












            //string komutum = "UPDATE Hasta_Table SET ad=@ad,soyad=@soyad,tel=@tel   WHERE Tc=@tc";
            //SqlCommand sqlcomut = new SqlCommand(komutum);
            //sqlcomut.Parameters.AddWithValue("@ad", textBox2.Text);
            //sqlcomut.Parameters.AddWithValue("@soyad", textBox3.Text);
            //sqlcomut.Parameters.AddWithValue("@tel", maskedTextBox1.Text);
            //sqlcomut.Parameters.AddWithValue("@tc", txTc.Text);
            //sqlkomut.komut(sqlcomut);
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




            // Satış İşlemleri bittikten sonra Geçici tabloyu temizledik... 
            string komutum = "delete  from GeciciSatis_Table";
            SqlCommand sqlcomut = new SqlCommand(komutum);
            sqlkomut.komut(sqlcomut);

            this.Close();

        }
    }
}
