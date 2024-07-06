namespace CourseDataBase
{
    partial class FormInvoiceDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoiceDetail));
            this.dataGridViewInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.idInvoiceDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.fKidInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKidSellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKidDeliveryServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deliveryserviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicedetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice_detailTableAdapter = new CourseDataBase.storeDataSetTableAdapters.invoice_detailTableAdapter();
            this.goodTableAdapter = new CourseDataBase.storeDataSetTableAdapters.goodTableAdapter();
            this.invoiceTableAdapter = new CourseDataBase.storeDataSetTableAdapters.invoiceTableAdapter();
            this.sellerTableAdapter = new CourseDataBase.storeDataSetTableAdapters.sellerTableAdapter();
            this.delivery_serviceTableAdapter = new CourseDataBase.storeDataSetTableAdapters.delivery_serviceTableAdapter();
            this.bindingNavigatorInvoiceDetail = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.buttonReportTotalPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryserviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicedetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorInvoiceDetail)).BeginInit();
            this.bindingNavigatorInvoiceDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInvoiceDetail
            // 
            this.dataGridViewInvoiceDetail.AutoGenerateColumns = false;
            this.dataGridViewInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInvoiceDetailDataGridViewTextBoxColumn,
            this.fKidGoodDataGridViewTextBoxColumn,
            this.Good,
            this.fKidInvoiceDataGridViewTextBoxColumn,
            this.Invoice,
            this.fKidSellerDataGridViewTextBoxColumn,
            this.Seller,
            this.fKidDeliveryServiceDataGridViewTextBoxColumn,
            this.Delivery,
            this.amoutDataGridViewTextBoxColumn,
            this.commissionDataGridViewTextBoxColumn});
            this.dataGridViewInvoiceDetail.DataSource = this.invoicedetailBindingSource;
            this.dataGridViewInvoiceDetail.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewInvoiceDetail.Name = "dataGridViewInvoiceDetail";
            this.dataGridViewInvoiceDetail.RowHeadersWidth = 62;
            this.dataGridViewInvoiceDetail.RowTemplate.Height = 28;
            this.dataGridViewInvoiceDetail.Size = new System.Drawing.Size(948, 229);
            this.dataGridViewInvoiceDetail.TabIndex = 0;
            // 
            // idInvoiceDetailDataGridViewTextBoxColumn
            // 
            this.idInvoiceDetailDataGridViewTextBoxColumn.DataPropertyName = "idInvoiceDetail";
            this.idInvoiceDetailDataGridViewTextBoxColumn.HeaderText = "idInvoiceDetail";
            this.idInvoiceDetailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idInvoiceDetailDataGridViewTextBoxColumn.Name = "idInvoiceDetailDataGridViewTextBoxColumn";
            this.idInvoiceDetailDataGridViewTextBoxColumn.ReadOnly = true;
            this.idInvoiceDetailDataGridViewTextBoxColumn.Visible = false;
            this.idInvoiceDetailDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKidGoodDataGridViewTextBoxColumn
            // 
            this.fKidGoodDataGridViewTextBoxColumn.DataPropertyName = "FK_idGood";
            this.fKidGoodDataGridViewTextBoxColumn.HeaderText = "FK_idGood";
            this.fKidGoodDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidGoodDataGridViewTextBoxColumn.Name = "fKidGoodDataGridViewTextBoxColumn";
            this.fKidGoodDataGridViewTextBoxColumn.Visible = false;
            this.fKidGoodDataGridViewTextBoxColumn.Width = 150;
            // 
            // Good
            // 
            this.Good.DataPropertyName = "FK_idGood";
            this.Good.DataSource = this.goodBindingSource;
            this.Good.DisplayMember = "good name";
            this.Good.HeaderText = "Товар";
            this.Good.MinimumWidth = 8;
            this.Good.Name = "Good";
            this.Good.ValueMember = "idGood";
            this.Good.Width = 150;
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "good";
            this.goodBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKidInvoiceDataGridViewTextBoxColumn
            // 
            this.fKidInvoiceDataGridViewTextBoxColumn.DataPropertyName = "FK_idInvoice";
            this.fKidInvoiceDataGridViewTextBoxColumn.HeaderText = "FK_idInvoice";
            this.fKidInvoiceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidInvoiceDataGridViewTextBoxColumn.Name = "fKidInvoiceDataGridViewTextBoxColumn";
            this.fKidInvoiceDataGridViewTextBoxColumn.Visible = false;
            this.fKidInvoiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // Invoice
            // 
            this.Invoice.DataPropertyName = "FK_idInvoice";
            this.Invoice.DataSource = this.invoiceBindingSource;
            this.Invoice.DisplayMember = "number";
            this.Invoice.HeaderText = "Накладна";
            this.Invoice.MinimumWidth = 8;
            this.Invoice.Name = "Invoice";
            this.Invoice.ValueMember = "idInvoice";
            this.Invoice.Width = 150;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.storeDataSet;
            // 
            // fKidSellerDataGridViewTextBoxColumn
            // 
            this.fKidSellerDataGridViewTextBoxColumn.DataPropertyName = "FK_idSeller";
            this.fKidSellerDataGridViewTextBoxColumn.HeaderText = "FK_idSeller";
            this.fKidSellerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidSellerDataGridViewTextBoxColumn.Name = "fKidSellerDataGridViewTextBoxColumn";
            this.fKidSellerDataGridViewTextBoxColumn.Visible = false;
            this.fKidSellerDataGridViewTextBoxColumn.Width = 150;
            // 
            // Seller
            // 
            this.Seller.DataPropertyName = "FK_idSeller";
            this.Seller.DataSource = this.sellerBindingSource;
            this.Seller.DisplayMember = "name";
            this.Seller.HeaderText = "Продавець";
            this.Seller.MinimumWidth = 8;
            this.Seller.Name = "Seller";
            this.Seller.ValueMember = "idSeller";
            this.Seller.Width = 150;
            // 
            // sellerBindingSource
            // 
            this.sellerBindingSource.DataMember = "seller";
            this.sellerBindingSource.DataSource = this.storeDataSet;
            // 
            // fKidDeliveryServiceDataGridViewTextBoxColumn
            // 
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.DataPropertyName = "FK_idDeliveryService";
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.HeaderText = "FK_idDeliveryService";
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.Name = "fKidDeliveryServiceDataGridViewTextBoxColumn";
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.Visible = false;
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // Delivery
            // 
            this.Delivery.DataPropertyName = "FK_idDeliveryService";
            this.Delivery.DataSource = this.deliveryserviceBindingSource;
            this.Delivery.DisplayMember = "name";
            this.Delivery.HeaderText = "Доставка";
            this.Delivery.MinimumWidth = 8;
            this.Delivery.Name = "Delivery";
            this.Delivery.ValueMember = "idDeliveryService";
            this.Delivery.Width = 150;
            // 
            // deliveryserviceBindingSource
            // 
            this.deliveryserviceBindingSource.DataMember = "delivery_service";
            this.deliveryserviceBindingSource.DataSource = this.storeDataSet;
            // 
            // amoutDataGridViewTextBoxColumn
            // 
            this.amoutDataGridViewTextBoxColumn.DataPropertyName = "amout";
            this.amoutDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.amoutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amoutDataGridViewTextBoxColumn.Name = "amoutDataGridViewTextBoxColumn";
            this.amoutDataGridViewTextBoxColumn.Width = 150;
            // 
            // commissionDataGridViewTextBoxColumn
            // 
            this.commissionDataGridViewTextBoxColumn.DataPropertyName = "commission";
            this.commissionDataGridViewTextBoxColumn.HeaderText = "Комісія";
            this.commissionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.commissionDataGridViewTextBoxColumn.Name = "commissionDataGridViewTextBoxColumn";
            this.commissionDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoicedetailBindingSource
            // 
            this.invoicedetailBindingSource.DataMember = "invoice_detail";
            this.invoicedetailBindingSource.DataSource = this.storeDataSet;
            // 
            // invoice_detailTableAdapter
            // 
            this.invoice_detailTableAdapter.ClearBeforeFill = true;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // sellerTableAdapter
            // 
            this.sellerTableAdapter.ClearBeforeFill = true;
            // 
            // delivery_serviceTableAdapter
            // 
            this.delivery_serviceTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorInvoiceDetail
            // 
            this.bindingNavigatorInvoiceDetail.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorInvoiceDetail.BindingSource = this.invoicedetailBindingSource;
            this.bindingNavigatorInvoiceDetail.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorInvoiceDetail.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorInvoiceDetail.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorInvoiceDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButtonSave});
            this.bindingNavigatorInvoiceDetail.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorInvoiceDetail.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorInvoiceDetail.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorInvoiceDetail.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorInvoiceDetail.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorInvoiceDetail.Name = "bindingNavigatorInvoiceDetail";
            this.bindingNavigatorInvoiceDetail.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorInvoiceDetail.Size = new System.Drawing.Size(972, 33);
            this.bindingNavigatorInvoiceDetail.TabIndex = 1;
            this.bindingNavigatorInvoiceDetail.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // buttonReportTotalPrice
            // 
            this.buttonReportTotalPrice.Location = new System.Drawing.Point(12, 306);
            this.buttonReportTotalPrice.Name = "buttonReportTotalPrice";
            this.buttonReportTotalPrice.Size = new System.Drawing.Size(237, 73);
            this.buttonReportTotalPrice.TabIndex = 2;
            this.buttonReportTotalPrice.Text = "Загальна сума до сплати \r\nпо накладним";
            this.buttonReportTotalPrice.UseVisualStyleBackColor = true;
            this.buttonReportTotalPrice.Click += new System.EventHandler(this.buttonReportTotalPrice_Click);
            // 
            // FormInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 391);
            this.Controls.Add(this.buttonReportTotalPrice);
            this.Controls.Add(this.bindingNavigatorInvoiceDetail);
            this.Controls.Add(this.dataGridViewInvoiceDetail);
            this.Name = "FormInvoiceDetail";
            this.Text = "Деталі накладної";
            this.Load += new System.EventHandler(this.FormInvoiceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryserviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicedetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorInvoiceDetail)).EndInit();
            this.bindingNavigatorInvoiceDetail.ResumeLayout(false);
            this.bindingNavigatorInvoiceDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvoiceDetail;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource invoicedetailBindingSource;
        private storeDataSetTableAdapters.invoice_detailTableAdapter invoice_detailTableAdapter;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private storeDataSetTableAdapters.goodTableAdapter goodTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private storeDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource sellerBindingSource;
        private storeDataSetTableAdapters.sellerTableAdapter sellerTableAdapter;
        private System.Windows.Forms.BindingSource deliveryserviceBindingSource;
        private storeDataSetTableAdapters.delivery_serviceTableAdapter delivery_serviceTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigatorInvoiceDetail;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.Button buttonReportTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInvoiceDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Good;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidSellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidDeliveryServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionDataGridViewTextBoxColumn;
    }
}