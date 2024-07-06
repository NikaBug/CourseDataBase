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
    public partial class FormReportInvoice : Form
    {
        public FormReportInvoice()
        {
            InitializeComponent();
        }

        private void buttonReportInvoice_Click(object sender, EventArgs e)
        {
            int start = dateTimePickerStart.Value.Year;
            int end = dateTimePickerEnd.Value.Year;
            this.dataTable2TableAdapter.Fill(this.storeDataSet.DataTable2, start, end);
            this.reportViewerIV.RefreshReport();
        }

        private void FormReportInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.DataTable2' table. You can move, or remove it, as needed.
            //this.dataTable2TableAdapter.Fill(this.storeDataSet.DataTable2);
            // TODO: This line of code loads data into the 'storeDataSet.DataTable2' table. You can move, or remove it, as needed.
            // this.dataTable2TableAdapter.Fill(this.storeDataSet.DataTable2);
            // TODO: This line of code loads data into the 'storeDataSet.DataTable2' table. You can move, or remove it, as needed.
            //this.dataTable2TableAdapter.Fill(this.storeDataSet.DataTable2);
            // TODO: This line of code loads data into the 'storeDataSet.DataTable2' table. You can move, or remove it, as needed.
            // this.dataTable2TableAdapter.Fill(this.storeDataSet.DataTable2);

            // this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            // this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }
    }
}
