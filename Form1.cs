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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddress_Click(object sender, EventArgs e)
        {
            FormAddress formAddress = new FormAddress();
            formAddress.ShowDialog();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.ShowDialog();
        }

        private void buttonGood_Click(object sender, EventArgs e)
        {
            FormGood formGood = new FormGood();
            formGood.ShowDialog();
        }

        private void buttonSeller_Click(object sender, EventArgs e)
        {
            FormSeller formSeller = new FormSeller();
            formSeller.ShowDialog();
        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            FormWarehouse formWarehouse = new FormWarehouse();
            formWarehouse.ShowDialog();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.ShowDialog();
        }

        private void buttonGoodsInWarehouse_Click(object sender, EventArgs e)
        {
            FormGoodsInWarehouse formGoodsInWarehouse = new FormGoodsInWarehouse();
            formGoodsInWarehouse.ShowDialog();
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {       
            FormInvoice formInvoice = new FormInvoice();
            formInvoice.ShowDialog();
        }

        private void buttonInvoiceDetail_Click(object sender, EventArgs e)
        {
            FormInvoiceDetail formInvoiceDetail = new FormInvoiceDetail();
            formInvoiceDetail.ShowDialog();
        }

        private void buttonDeliveryService_Click(object sender, EventArgs e)
        {
            FormDeliveryService formDeliveryService = new FormDeliveryService();
            formDeliveryService.ShowDialog();
        }
    }
}
