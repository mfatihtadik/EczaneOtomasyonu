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
    public partial class hastaraporForm : Form
    {
        public hastaraporForm()
        {
            InitializeComponent();
        }

        private void hastaraporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ECZANEDataSet1.Hasta_Table' table. You can move, or remove it, as needed.
            this.Hasta_TableTableAdapter.Fill(this.ECZANEDataSet1.Hasta_Table);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
