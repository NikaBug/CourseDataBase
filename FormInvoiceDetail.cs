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
    public partial class FormInvoiceDetail : Form
    {
        public FormInvoiceDetail()
        {
            InitializeComponent();
        }

        public void UpdateDataMessage()
        {
            MessageBox.Show("Дані успішно збережені!",
                "Оновлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormInvoiceDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.delivery_service' table. You can move, or remove it, as needed.
            this.delivery_serviceTableAdapter.Fill(this.storeDataSet.delivery_service);
            // TODO: This line of code loads data into the 'storeDataSet.seller' table. You can move, or remove it, as needed.
            this.sellerTableAdapter.Fill(this.storeDataSet.seller);
            // TODO: This line of code loads data into the 'storeDataSet.invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.storeDataSet.invoice);
            // TODO: This line of code loads data into the 'storeDataSet.good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.storeDataSet.good);
            // TODO: This line of code loads data into the 'storeDataSet.invoice_detail' table. You can move, or remove it, as needed.
            this.invoice_detailTableAdapter.Fill(this.storeDataSet.invoice_detail);

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                invoice_detailTableAdapter.Update(this.storeDataSet);
                UpdateDataMessage(); // повідомлення про успішну операцію
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ця таблиця має зв'язки з іншою таблицею",
                "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error); // повідомлення про помилку
            }
        }

        private void buttonReportTotalPrice_Click(object sender, EventArgs e)
        {
            FormIDReport formIDReport = new FormIDReport();
            formIDReport.ShowDialog();
        }
    }
}
