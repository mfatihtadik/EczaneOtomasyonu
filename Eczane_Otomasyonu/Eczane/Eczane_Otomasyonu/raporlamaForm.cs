using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane_Otomasyonu
{
    public partial class raporlamaForm : Form
    {
        public raporlamaForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            hastaraporForm hrpfrm = new hastaraporForm();
            hrpfrm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullaniciraporForm krpfrm = new kullaniciraporForm();
            krpfrm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ilacraporForm irfrm = new ilacraporForm();
            irfrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lograporForm lrfrm = new lograporForm();
            lrfrm.ShowDialog();
        }
    }
}
