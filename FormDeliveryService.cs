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
    public partial class FormDeliveryService : Form
    {
        public FormDeliveryService()
        {
            InitializeComponent();
        }

        public void UpdateDataMessage()
        {
            MessageBox.Show("Дані успішно збережені!",
                "Оновлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormDeliveryService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.delivery_service' table. You can move, or remove it, as needed.
            this.delivery_serviceTableAdapter.Fill(this.storeDataSet.delivery_service);

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                delivery_serviceTableAdapter.Update(this.storeDataSet);
                UpdateDataMessage(); // повідомлення про успішну операцію
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ця таблиця має зв'язки з іншою таблицею",
                "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error); // повідомлення про помилку
            }
        }

        private void buttonAveragePrice_Click(object sender, EventArgs e)
        {
            FormDSReport formDSReport = new FormDSReport();
            formDSReport.ShowDialog();
        }
    }
}
