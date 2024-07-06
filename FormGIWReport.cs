using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseDataBase
{
    public partial class FormGIWReport : Form
    {
        public FormGIWReport()
        {
            InitializeComponent();
        }

        private void FormGIWReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.storeDataSet.DataTable1);
            // TODO: This line of code loads data into the 'storeDataSet.DataTable3' table. You can move, or remove it, as needed.
            reportViewer1.RefreshReport();
        }
    }
}
