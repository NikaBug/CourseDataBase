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
    public partial class FormReportInvoice2 : Form
    {
        public FormReportInvoice2()
        {
            InitializeComponent();
        }

        private void buttonGenReport_Click(object sender, EventArgs e)
        {
            int startM = dateTimePickerStart.Value.Month;
            int endM = dateTimePickerEnd.Value.Month;
            int startY = dateTimePickerStart.Value.Year;
            int endY = dateTimePickerEnd.Value.Year;
            this.dataTable4TableAdapter.Fill(this.storeDataSet.DataTable4, startM, endM, startY, endY);

            this.reportViewer1.RefreshReport();
        }

        private void FormReportInvoice2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.DataTable4' table. You can move, or remove it, as needed.
            //this.dataTable4TableAdapter.Fill(this.storeDataSet.DataTable4);

            //this.reportViewer1.RefreshReport();
        }
    }
}
