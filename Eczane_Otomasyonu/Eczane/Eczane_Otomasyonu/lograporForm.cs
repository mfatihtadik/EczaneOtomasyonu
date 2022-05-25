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
    public partial class lograporForm : Form
    {
        public lograporForm()
        {
            InitializeComponent();
        }

        private void lograporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ECZANEDataSet1.Log_Table' table. You can move, or remove it, as needed.
            this.Log_TableTableAdapter.Fill(this.ECZANEDataSet1.Log_Table);

            this.reportViewer1.RefreshReport();
        }
    }
}
