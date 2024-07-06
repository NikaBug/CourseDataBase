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
    public partial class FormDSReport : Form
    {
        public FormDSReport()
        {
            InitializeComponent();
        }

        private void FormDSReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.delivery_service1' table. You can move, or remove it, as needed.
            this.delivery_service1TableAdapter.Fill(this.storeDataSet.delivery_service1);

            this.reportViewer1.RefreshReport();
        }
    }
}
