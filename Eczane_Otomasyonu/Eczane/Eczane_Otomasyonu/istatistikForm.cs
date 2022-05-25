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
    public partial class istatistikForm : Form
    {

        public DataSet ds = new DataSet();
        public BindingSource bs = new BindingSource();
        SQL S = new SQL();

        public istatistikForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //DataGrid i sıfırlama...
            dataGridView1.Columns.Clear();
            ds.Tables.Clear();
            dataGridView1.Refresh();

            string istatistik;
            istatistik = cmbistatistik.Text.Trim();
            if (istatistik== "En pahalı ürün")
            {
                dataGridView1.DataSource = null;
                //  bs = null;
                string komut = "SELECT TOP 1 ad, fiyat FROM İlac_Table WHERE fiyat=(SELECT MAX(fiyat) FROM İlac_Table)";
                SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
                ds.Clear();
                da.Fill(ds, "tablom");
                bs.DataSource = ds.Tables["tablom"];
                dataGridView1.DataSource = bs;
            }
            else if (istatistik == "En ucuz ürün")
            {
                dataGridView1.DataSource = null;
                //  bs = null;
                string komut = "SELECT TOP 1 ad, fiyat FROM İlac_Table WHERE fiyat=(SELECT MIN(fiyat) FROM İlac_Table)";
                SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
                ds.Clear();
                da.Fill(ds, "tablom");
                bs.DataSource = ds.Tables["tablom"];
                dataGridView1.DataSource = bs;
            }
            else if (istatistik == "Stok adedi en yüksek ürünler")
            {
                dataGridView1.DataSource = null;
                //  bs = null;
                string komut = "SELECT ad, adet FROM İlac_Table WHERE adet=(SELECT MAX(adet) FROM İlac_Table)";
                SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
                ds.Clear();
                da.Fill(ds, "tablom");
                bs.DataSource = ds.Tables["tablom"];
                dataGridView1.DataSource = bs;
            }
            else if (istatistik == "Stok adedi en düşük ürünler")
            {
                dataGridView1.DataSource = null;
                //  bs = null;
                string komut = "SELECT ad, adet FROM İlac_Table WHERE adet=(SELECT MIN(adet) FROM İlac_Table)";
                SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
                ds.Clear();
                da.Fill(ds, "tablom");
                bs.DataSource = ds.Tables["tablom"];
                dataGridView1.DataSource = bs;
            }
            else if (istatistik == "Toplam ürün sayısı")
            {
                dataGridView1.DataSource = null;
                //  bs = null;
                string komut = "SELECT COUNT(*) AS 'Toplam ürün sayısı' FROM İlac_Table";
                SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
                ds.Clear();
                da.Fill(ds, "tablom");
                bs.DataSource = ds.Tables["tablom"];
                dataGridView1.DataSource = bs;
            }
            else if (istatistik == "Ürünlerin toplam fiyatı")
            {
                dataGridView1.DataSource = null;
                //  bs = null;
                string komut = "SELECT SUM(fiyat) AS 'Ürünlerin toplam fiyatı' FROM İlac_Table";
                SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
                ds.Clear();
                da.Fill(ds, "tablom");
                bs.DataSource = ds.Tables["tablom"];
                dataGridView1.DataSource = bs;
            }
            else if (istatistik == "Ürünlerin fiyat ortalaması")
            {
                dataGridView1.DataSource = null;
                //  bs = null;
                string komut = "SELECT AVG(fiyat) AS 'Ürünlerin fiyat ortalaması' FROM İlac_Table";
                SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
                ds.Clear();
                da.Fill(ds, "tablom");
                bs.DataSource = ds.Tables["tablom"];
                dataGridView1.DataSource = bs;
            }


            Log logum = new Log();
            logum.log(istatistik+" Listelendi", "");












            // ----Uzun yol-----
            //string islem =istatistik+" Listelendi";
            //string komut2 = "insert Log_Table (islem,zaman,yetkili) values (@islem,@zaman,@yetkili)";
            //SqlCommand kmt = new SqlCommand(komut2);
            //kmt.Parameters.AddWithValue("@islem", islem);
            //kmt.Parameters.AddWithValue("@zaman", DateTime.Now);
            //kmt.Parameters.AddWithValue("@yetkili", girisForm.kuladi.ToString());
            //S.komut(kmt);
            //-----
        }
    }
}
