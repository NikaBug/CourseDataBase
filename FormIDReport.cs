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
    public partial class FormIDReport : Form
    {
        public FormIDReport()
        {
            InitializeComponent();
        }

        private void FormIDReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.DataTable3' table. You can move, or remove it, as needed.
            //this.dataTable3TableAdapter.Fill(this.storeDataSet.DataTable3);

            //// this.reportViewer1.RefreshReport();
            //this.reportViewerID.RefreshReport();
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            int n1 = (int)numericUpDownStart.Value;
            int n2 = (int)numericUpDownEnd.Value;
            this.dataTable3TableAdapter.Fill(this.storeDataSet.DataTable3, n1, n2);

            // this.reportViewer1.RefreshReport();
            this.reportViewerID.RefreshReport();
        }
    }
}
