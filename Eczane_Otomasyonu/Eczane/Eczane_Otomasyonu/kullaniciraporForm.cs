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
    public partial class kullaniciraporForm : Form
    {
        public kullaniciraporForm()
        {
            InitializeComponent();
        }

        private void kullaniciraporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ECZANEDataSet1.Kullanicigiris_tab' table. You can move, or remove it, as needed.
            this.Kullanicigiris_tabTableAdapter.Fill(this.ECZANEDataSet1.Kullanicigiris_tab);

            this.reportViewer1.RefreshReport();
        }
    }
}
