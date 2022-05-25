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
    public partial class receteliodemeform2 : Form
    {
        public receteliodemeform2()
        {
            InitializeComponent();
        }

        BindingSource bs = new BindingSource();
        DataSet ds1 = new DataSet();
        SQL s = new SQL();



        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public int recete_idd;
        public string tc_id;
        private void receteliodemeform2_Load(object sender, EventArgs e)
        {
            //and rt.hasta_tc = @tc
           
            con = s.baglantikur();
            SqlCommand cmd = new SqlCommand("select rit.barkod,rit.gunluk_adet,it.ad,it.fiyat from Recete_Table as rt  " +
                "inner join recete_ilac_table rit on(rt.recete_id = rit.recete_id)" +
                "inner join İlac_Table it on(it.barkod=rit.barkod) " +
                "where rt.recete_id=@id and rt.hasta_tc = @tc", con);
            cmd.Parameters.AddWithValue("@id",recete_idd);
            cmd.Parameters.AddWithValue("@tc", tc_id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds1, "tablom");
            bs.DataSource = ds1.Tables["tablom"];
            dataGridView1.DataSource = bs;



            decimal toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {               
                toplam +=Convert.ToDecimal(dataGridView1[3, i].Value);               
            }
            textBox1.Text = toplam.ToString();
            textBox2.Text = (toplam * 60 / 100).ToString();






            //dataGridView1.DataSource = null;
            ////  bs = null;
            //string komut = "SELECT * FROM Log_Table";
            //SqlDataAdapter da = new SqlDataAdapter(komut, s.baglantikur());
            //ds.Clear();
            //da.Fill(ds, "tablom");
            //bs.DataSource = ds.Tables["tablom"];
            //dataGridView1.DataSource = bs;




            //ListViewItem item = new ListViewItem(dr["Product_ID"].ToString());
            //item.SubItems.Add(dr["Product_Name"].ToString());
            //item.SubItems.Add(dr["Category_Name"].ToString());
            //item.SubItems.Add(dr["Product_Price"].ToString());
            //item.SubItems.Add(dr["Product_Amount"].ToString());
            //item.SubItems.Add(dr["Warranty_Period"].ToString());
            //listView1.Items.Add(item);

            if (dataGridView1.Rows.Count == 0)
            {               
                MessageBox.Show("Reçete bulunamadı!");
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {                
                string komut = "SELECT adet FROM İlac_Table where barkod=@barkod";
                SqlCommand cmdd = new SqlCommand(komut,con);
                cmdd.Parameters.AddWithValue("@barkod",Convert.ToInt32(dataGridView1[0, i].Value));
                int adet = Convert.ToInt32(cmdd.ExecuteScalar());
                if (adet==0)
                {
                    MessageBox.Show($"{dataGridView1[0, i].Value} İlacın stoğu yok");
                    con.Close();
                    return;
                }
                

            }

            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
               
                string sorgu = "UPDATE İlac_Table SET adet=adet-1 where barkod=@barkod";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@barkod", Convert.ToInt32(dataGridView1[0, i].Value));
                komut.ExecuteNonQuery();             
            }
            con.Close();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
