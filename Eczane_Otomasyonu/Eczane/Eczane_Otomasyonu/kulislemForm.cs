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
    public partial class kulislemForm : Form
    {
        public DataSet ds = new DataSet();
        public BindingSource bs = new BindingSource();
        SQL S = new SQL();

        public kulislemForm()
        {
            InitializeComponent();
        }


        private void verilericek()
        {
            dataGridView1.DataSource = null;
            //  bs = null;
            string komut = "SELECT * FROM Kullanicigiris_tab";
            SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
            ds.Clear();
            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView1.DataSource = bs;
        }

        private void kulislemForm_Load(object sender, EventArgs e)
        {
            verilericek();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //  bs = null;
            string komut = "SELECT * FROM Kullanicigiris_tab where Kullanici_adi like '%" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(komut, S.baglantikur());
            ds.Clear();
            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (girisForm.yetki.Trim() == "admin")
            {
                kullaniciEkleForm kulekfrm = new kullaniciEkleForm();

                kulekfrm.ShowDialog();
                verilericek();
            }
            else
                MessageBox.Show("Bu işlemi yalnızca admin yapabilir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (girisForm.yetki.Trim() == "admin")
            {
                kullaniciguncelleForm kgfrm = new kullaniciguncelleForm();
                kgfrm.textBox3.DataBindings.Add("Text", bs, "Eczane_id");
                kgfrm.textBox1.DataBindings.Add("Text", bs, "Kullanici_adi");
                kgfrm.textBox2.DataBindings.Add("Text", bs, "Parola");
                kgfrm.comboBox1.DataBindings.Add("Text", bs, "Yetki");
                kgfrm.ShowDialog();
                verilericek();
            }
            else
                MessageBox.Show("Bu işlemi yalnızca admin yapabilir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (girisForm.yetki.Trim() == "admin")
            {
                kullanicisilForm ksfrm = new kullanicisilForm();
                ksfrm.textBox3.DataBindings.Add("Text", bs, "Eczane_id");
                ksfrm.textBox1.DataBindings.Add("Text", bs, "Kullanici_adi");
                ksfrm.textBox2.DataBindings.Add("Text", bs, "Parola");
                ksfrm.comboBox1.DataBindings.Add("Text", bs, "Yetki");
                ksfrm.ShowDialog();
                verilericek();
            }
            else
                MessageBox.Show("Bu işlemi yalnızca admin yapabilir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
