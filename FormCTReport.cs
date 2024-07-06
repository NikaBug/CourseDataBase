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
    public partial class FormCTReport : Form
    {
        public FormCTReport()
        {
            InitializeComponent();
        }

        private void FormCTReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.category1' table. You can move, or remove it, as needed.
            this.category1TableAdapter.Fill(this.storeDataSet.category1);
            // TODO: This line of code loads data into the 'storeDataSet.category1' table. You can move, or remove it, as needed.
            this.category1TableAdapter.Fill(this.storeDataSet.category1);

            this.reportViewer1.RefreshReport();
        }
    }
}
