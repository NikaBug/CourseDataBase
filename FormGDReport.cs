using CourseDataBase.storeDataSetTableAdapters;
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
    public partial class FormGDReport : Form
    {
        public FormGDReport()
        {
            InitializeComponent();
        }

        private void FormGDReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.good1' table. You can move, or remove it, as needed.
            this.good1TableAdapter.Fill(this.storeDataSet.good1);

            // TODO: This line of code loads data into the 'storeDataSet.DataTable5' table. You can move, or remove it, as needed.
            // this.dataTable5TableAdapter.Fill(this.storeDataSet.DataTable5);

            //this.reportViewer1.RefreshReport();
        }

        private void buttonGenReport_Click(object sender, EventArgs e)
        {
            string country = comboBoxCountry.Text;
            this.dataTable5TableAdapter.Fill(this.storeDataSet.DataTable5, country);
            this.reportViewer1.RefreshReport();

        }
    }
}
