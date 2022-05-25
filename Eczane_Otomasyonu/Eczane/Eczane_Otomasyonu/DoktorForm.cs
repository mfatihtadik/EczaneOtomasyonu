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
    public partial class DoktorForm : Form
    {


        SQL S = new SQL();

        SQL sqlkomut = new SQL();



        SQL s = new SQL();

        public DataSet ds = new DataSet();

        public BindingSource bs = new BindingSource();
        public DoktorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ilac i = new ilac()
            {
                Barkod = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value),
                Ad = dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                Kutu = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value)
            };

            //listBox1.Items.Add(i + "-->" + txtGunlukadet.Text + " adet");

            //item.SubItems.Add(dr["Category_Name"].ToString());



            ListViewItem item = new ListViewItem(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            item.SubItems.Add(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            item.SubItems.Add(txtBarkod.Text);
            item.SubItems.Add(txtGunlukadet.Text);
            listView1.Items.Add(item);










            //ilac ilisim =listBox1.SelectedItem as ilac;










            //Veritabanına ekleme...

            //string komutum = "insert into recete_ilac_table (recete_id,barkod,gunluk_adet) Values (@recete_id,@barkod,@gunluk_adet)";
            //SqlCommand sqlcomut = new SqlCommand(komutum);
            //sqlcomut.Parameters.AddWithValue("@recete_id", txtReceteid.Text);
            //sqlcomut.Parameters.AddWithValue("@barkod", txtBarkod.Text);
            //sqlcomut.Parameters.AddWithValue("@gunluk_adet", txtGunlukadet.Text);
            //sqlkomut.komut(sqlcomut);




        }

        private void verilericek()
        {

            dataGridView1.DataSource = null;
            //  bs = null;
            string komut = "SELECT * FROM View_dilac";        //Viewww 
            //string komut = "SELECT ad, barkod ,kutu FROM İlac_Table";
            SqlDataAdapter da = new SqlDataAdapter(komut, s.baglantikur());
            ds.Clear();

            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView1.DataSource = bs;

        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            verilericek();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkod.Text = dataGridView1[1, e.RowIndex].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secimSayisi = listView1.SelectedItems.Count;

            foreach (ListViewItem bilgi in listView1.SelectedItems)
            {
                bilgi.Remove();
            }
            MessageBox.Show(secimSayisi + " adet kayıt silindi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtTc.Text))
            {
                MessageBox.Show("Hasta Tc Boş");
            }
            else
            {
                SqlConnection con = s.baglantikur();
                string komut = "SELECT COUNT(*) FROM Hasta_Table where tc =@tc";
                SqlCommand da = new SqlCommand(komut, con);
                con.Open();
                da.Parameters.AddWithValue("@tc", mtxtTc.Text);
                int sonuc = Convert.ToInt32(da.ExecuteScalar());
                
                if (sonuc>0)
                {
                    bool varmi = false;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        
                        string komut2 = "ilacBittiMi";
                        SqlCommand da2 = new SqlCommand(komut2, con);
                        da2.Parameters.AddWithValue("@ilac_no", int.Parse(listView1.Items[i].SubItems[2].Text));
                        da2.Parameters.AddWithValue("@hasta_no", mtxtTc.Text);
                        da2.CommandType = CommandType.StoredProcedure;
                        int sonuc2 = Convert.ToInt32(da2.ExecuteScalar());
                        if (sonuc2>0)
                        {
                            varmi = true;
                            break;
                        }
                    }

                  
                    if (varmi)
                    {
                        MessageBox.Show("Şuan hala ilacı var");
                    }
                    else
                    {
                        string komutum = "insert into Recete_Table (hasta_tc,tarih) Values (@hasta_tc,@tarih);SELECT SCOPE_IDENTITY()";
                        SqlCommand sqlcomut = new SqlCommand(komutum,con);
                        sqlcomut.Parameters.AddWithValue("@hasta_tc", mtxtTc.Text);
                        sqlcomut.Parameters.AddWithValue("@tarih", DateTimeOffset.Now.ToUnixTimeSeconds());
                        int recete_id = Convert.ToInt32(sqlcomut.ExecuteScalar());




                        // Buradan devam edeceğiz... (To Be Continue...)


                     for (int i = 0; i < listView1.Items.Count; i++)
                        {

                            string komut3 = "insert into recete_ilac_table (recete_id,barkod,gunluk_adet) Values (@recete_id,@barkod,@gunluk_adet)";
                            SqlCommand da3 = new SqlCommand(komut3, con);
                            da3.Parameters.AddWithValue("@recete_id", recete_id);
                            da3.Parameters.AddWithValue("@barkod", int.Parse(listView1.Items[i].SubItems[2].Text));
                            da3.Parameters.AddWithValue("@gunluk_adet", int.Parse(listView1.Items[i].SubItems[3].Text));
                            sqlkomut.komut(da3);

                        }

                        con.Close();
                        MessageBox.Show("Reçete oluşturuldu.");
























                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz TC' de bir hasta bulunmuyor. Hasta kayıt sayfasına yönlendiriliyorsunuz...");
                    hastaEkleForm hstklfrm = new hastaEkleForm();
                    hastaEkleForm.tc = mtxtTc.Text;
                    hstklfrm.ShowDialog();
                }

            }
        }
    }
}
