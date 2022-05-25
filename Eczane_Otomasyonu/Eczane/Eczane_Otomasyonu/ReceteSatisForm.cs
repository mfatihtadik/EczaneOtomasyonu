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
    public partial class ReceteSatisForm : Form
    {
        BindingSource bshasta = new BindingSource();
        DataSet ds1 = new DataSet();
        SQL s = new SQL();



        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public ReceteSatisForm()
        {
            InitializeComponent();
        }

        public static int recbarkod;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReceteSatisForm_Load(object sender, EventArgs e)
        {
            hastacek();


           




            //DateTimeOffset.Now.AddDays(-10).ToUnixTimeSeconds();
            //label6.Text= DateTimeOffset.Now.ToUnixTimeSeconds().ToString();

            //label6.Text = DateTimeOffset.FromUnixTimeSeconds(1601174246).DateTime.ToLocalTime().ToString();





        }


        private void hastacek()
        {
            comboBox1.DataSource = null;
            //  bs = null;
            string komut = "SELECT * FROM Hasta_Table";
            SqlDataAdapter da = new SqlDataAdapter(komut, s.baglantikur());
            ds1.Clear();

            da.Fill(ds1, "tablom");
            bshasta.DataSource = ds1.Tables["tablom"];
            comboBox1.DisplayMember = "Tc";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = bshasta;

            textBox1.DataBindings.Add("Text", bshasta, "ad");


            textBox2.DataBindings.Add("Text", bshasta, "soyad");

            textBox3.DataBindings.Add("Text", bshasta, "tel");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //Random random = new Random();
            //for (int i = 0; i < random.Next(2,10); i++)
            //{
            //   /*
            //    * update hastatcsine gore ara ve buldugunda hastaya urunleri ekle 
            //    * log kaydına satısı gir
            //    * stoktan satıstaki ürünleri tek tek tek düş
            //    * 
            //    */
            //    listBox1.Items.Add("A"+random.Next(1,5898)+"F"+random.Next(10000,50000000));
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Eski Kod...

            //string tc = comboBox1.Text;
            //con = new SqlConnection("Data Source=DESKTOP-SL8FJJ5;Initial Catalog=ECZANE;Integrated Security=True");
            //com = new SqlCommand();
            //con.Open();
            //com.Connection = con;
            //com.CommandText = "Select * From Hasta_Table where tc='" + comboBox1.Text + "'";
            //dr = com.ExecuteReader();
            //if (dr.Read())
            //{
            //    if (maskedTextBox2.Text == "")
            //    {
            //        MessageBox.Show("Eksik giriş yaptınız");
            //    }
            //    else
            //    {
            //        recbarkod = int.Parse(maskedTextBox2.Text);
            //        receteliodemeForm rofrm = new receteliodemeForm();
            //        rofrm.ShowDialog();
            //    }

            //}
            //else
            //{
            //    hastaEkleForm hefrm = new hastaEkleForm();
            //    hefrm.ShowDialog();
            //}

            //Eski Kod...


            receteliodemeform2 rofrm2 = new receteliodemeform2();
            rofrm2.recete_idd = int.Parse(maskedTextBox2.Text);
            rofrm2.tc_id = comboBox1.GetItemText(comboBox1.SelectedItem);
            rofrm2.ShowDialog();


















            //SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-SL8FJJ5;Initial Catalog=ECZANE;Integrated Security=True");
            //con2.Open();

            //var cmd = new SqlCommand("ilacBittiMi", con2);
            //cmd.Parameters.AddWithValue("ilac_no", int.Parse(maskedTextBox2.Text));
            //cmd.Parameters.AddWithValue("hasta_no", comboBox1.Text);
            //cmd.CommandType = CommandType.StoredProcedure;

            //int sonuc = Convert.ToInt32(cmd.ExecuteScalar());

            //if (sonuc > 0) 
            //    label6.Text = $"{comboBox1.Text} numaralı hasta {maskedTextBox2.Text} numaralı ilacı 10 gün içerisinde almış";
            //else

            //{

            //}

            //con2.Close();
            //con2.Dispose();

        }

        private void btnRecetekle_Click(object sender, EventArgs e)
        {
            DoktorForm dkfrm = new DoktorForm();
            dkfrm.ShowDialog();
        }
    }
}
