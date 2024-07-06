namespace CourseDataBase
{
    partial class FormInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.idInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.fKidWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new CourseDataBase.storeDataSetTableAdapters.invoiceTableAdapter();
            this.bindingNavigatorInvoice = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customerTableAdapter = new CourseDataBase.storeDataSetTableAdapters.customerTableAdapter();
            this.warehouseTableAdapter = new CourseDataBase.storeDataSetTableAdapters.warehouseTableAdapter();
            this.dataGridViewInvDet = new System.Windows.Forms.DataGridView();
            this.idInvoiceDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Seller = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Delivery = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deliveryserviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKidInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidSellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidDeliveryServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKinvoicedFKid603D47BBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice_detailTableAdapter = new CourseDataBase.storeDataSetTableAdapters.invoice_detailTableAdapter();
            this.goodTableAdapter = new CourseDataBase.storeDataSetTableAdapters.goodTableAdapter();
            this.sellerTableAdapter = new CourseDataBase.storeDataSetTableAdapters.sellerTableAdapter();
            this.delivery_serviceTableAdapter = new CourseDataBase.storeDataSetTableAdapters.delivery_serviceTableAdapter();
            this.buttonReportByYear = new System.Windows.Forms.Button();
            this.buttonReportByDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorInvoice)).BeginInit();
            this.bindingNavigatorInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryserviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKinvoicedFKid603D47BBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AutoGenerateColumns = false;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInvoiceDataGridViewTextBoxColumn,
            this.fKidCustomerDataGridViewTextBoxColumn,
            this.Customer,
            this.fKidWarehouseDataGridViewTextBoxColumn,
            this.Warehouse,
            this.dateDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridViewInvoice.DataSource = this.invoiceBindingSource;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.RowHeadersWidth = 62;
            this.dataGridViewInvoice.RowTemplate.Height = 28;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(984, 255);
            this.dataGridViewInvoice.TabIndex = 0;
            // 
            // idInvoiceDataGridViewTextBoxColumn
            // 
            this.idInvoiceDataGridViewTextBoxColumn.DataPropertyName = "idInvoice";
            this.idInvoiceDataGridViewTextBoxColumn.HeaderText = "idInvoice";
            this.idInvoiceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idInvoiceDataGridViewTextBoxColumn.Name = "idInvoiceDataGridViewTextBoxColumn";
            this.idInvoiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idInvoiceDataGridViewTextBoxColumn.Visible = false;
            this.idInvoiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKidCustomerDataGridViewTextBoxColumn
            // 
            this.fKidCustomerDataGridViewTextBoxColumn.DataPropertyName = "FK_idCustomer";
            this.fKidCustomerDataGridViewTextBoxColumn.HeaderText = "FK_idCustomer";
            this.fKidCustomerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidCustomerDataGridViewTextBoxColumn.Name = "fKidCustomerDataGridViewTextBoxColumn";
            this.fKidCustomerDataGridViewTextBoxColumn.Visible = false;
            this.fKidCustomerDataGridViewTextBoxColumn.Width = 150;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "FK_idCustomer";
            this.Customer.DataSource = this.customerBindingSource;
            this.Customer.DisplayMember = "name";
            this.Customer.HeaderText = "Покупець";
            this.Customer.MinimumWidth = 8;
            this.Customer.Name = "Customer";
            this.Customer.ValueMember = "idCustomers";
            this.Customer.Width = 150;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKidWarehouseDataGridViewTextBoxColumn
            // 
            this.fKidWarehouseDataGridViewTextBoxColumn.DataPropertyName = "FK_idWarehouse";
            this.fKidWarehouseDataGridViewTextBoxColumn.HeaderText = "FK_idWarehouse";
            this.fKidWarehouseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidWarehouseDataGridViewTextBoxColumn.Name = "fKidWarehouseDataGridViewTextBoxColumn";
            this.fKidWarehouseDataGridViewTextBoxColumn.Visible = false;
            this.fKidWarehouseDataGridViewTextBoxColumn.Width = 150;
            // 
            // Warehouse
            // 
            this.Warehouse.DataPropertyName = "FK_idWarehouse";
            this.Warehouse.DataSource = this.warehouseBindingSource;
            this.Warehouse.DisplayMember = "name";
            this.Warehouse.HeaderText = "Склад";
            this.Warehouse.MinimumWidth = 8;
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.ValueMember = "idWarehouse";
            this.Warehouse.Width = 150;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "warehouse";
            this.warehouseBindingSource.DataSource = this.storeDataSet;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.storeDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorInvoice
            // 
            this.bindingNavigatorInvoice.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorInvoice.BindingSource = this.invoiceBindingSource;
            this.bindingNavigatorInvoice.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorInvoice.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorInvoice.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorInvoice.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorInvoice.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorInvoice.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorInvoice.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorInvoice.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorInvoice.Name = "bindingNavigatorInvoice";
            this.bindingNavigatorInvoice.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorInvoice.Size = new System.Drawing.Size(1011, 38);
            this.bindingNavigatorInvoice.TabIndex = 1;
            this.bindingNavigatorInvoice.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
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
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewInvDet
            // 
            this.dataGridViewInvDet.AllowUserToAddRows = false;
            this.dataGridViewInvDet.AllowUserToDeleteRows = false;
            this.dataGridViewInvDet.AutoGenerateColumns = false;
            this.dataGridViewInvDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInvoiceDetailDataGridViewTextBoxColumn,
            this.fKidGoodDataGridViewTextBoxColumn,
            this.Good,
            this.Seller,
            this.Delivery,
            this.fKidInvoiceDataGridViewTextBoxColumn,
            this.fKidSellerDataGridViewTextBoxColumn,
            this.fKidDeliveryServiceDataGridViewTextBoxColumn,
            this.amoutDataGridViewTextBoxColumn,
            this.commissionDataGridViewTextBoxColumn});
            this.dataGridViewInvDet.DataSource = this.fKinvoicedFKid603D47BBBindingSource;
            this.dataGridViewInvDet.Location = new System.Drawing.Point(12, 347);
            this.dataGridViewInvDet.Name = "dataGridViewInvDet";
            this.dataGridViewInvDet.ReadOnly = true;
            this.dataGridViewInvDet.RowHeadersWidth = 62;
            this.dataGridViewInvDet.RowTemplate.Height = 28;
            this.dataGridViewInvDet.Size = new System.Drawing.Size(984, 150);
            this.dataGridViewInvDet.TabIndex = 2;
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
            this.fKidGoodDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.Good.ReadOnly = true;
            this.Good.ValueMember = "idGood";
            this.Good.Width = 150;
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "good";
            this.goodBindingSource.DataSource = this.storeDataSet;
            // 
            // Seller
            // 
            this.Seller.DataPropertyName = "FK_idSeller";
            this.Seller.DataSource = this.sellerBindingSource;
            this.Seller.DisplayMember = "name";
            this.Seller.HeaderText = "Продавець";
            this.Seller.MinimumWidth = 8;
            this.Seller.Name = "Seller";
            this.Seller.ReadOnly = true;
            this.Seller.ValueMember = "idSeller";
            this.Seller.Width = 150;
            // 
            // sellerBindingSource
            // 
            this.sellerBindingSource.DataMember = "seller";
            this.sellerBindingSource.DataSource = this.storeDataSet;
            // 
            // Delivery
            // 
            this.Delivery.DataPropertyName = "FK_idDeliveryService";
            this.Delivery.DataSource = this.deliveryserviceBindingSource;
            this.Delivery.DisplayMember = "name";
            this.Delivery.HeaderText = "Доставка";
            this.Delivery.MinimumWidth = 8;
            this.Delivery.Name = "Delivery";
            this.Delivery.ReadOnly = true;
            this.Delivery.ValueMember = "idDeliveryService";
            this.Delivery.Width = 150;
            // 
            // deliveryserviceBindingSource
            // 
            this.deliveryserviceBindingSource.DataMember = "delivery_service";
            this.deliveryserviceBindingSource.DataSource = this.storeDataSet;
            // 
            // fKidInvoiceDataGridViewTextBoxColumn
            // 
            this.fKidInvoiceDataGridViewTextBoxColumn.DataPropertyName = "FK_idInvoice";
            this.fKidInvoiceDataGridViewTextBoxColumn.HeaderText = "FK_idInvoice";
            this.fKidInvoiceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidInvoiceDataGridViewTextBoxColumn.Name = "fKidInvoiceDataGridViewTextBoxColumn";
            this.fKidInvoiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKidInvoiceDataGridViewTextBoxColumn.Visible = false;
            this.fKidInvoiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKidSellerDataGridViewTextBoxColumn
            // 
            this.fKidSellerDataGridViewTextBoxColumn.DataPropertyName = "FK_idSeller";
            this.fKidSellerDataGridViewTextBoxColumn.HeaderText = "FK_idSeller";
            this.fKidSellerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidSellerDataGridViewTextBoxColumn.Name = "fKidSellerDataGridViewTextBoxColumn";
            this.fKidSellerDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKidSellerDataGridViewTextBoxColumn.Visible = false;
            this.fKidSellerDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKidDeliveryServiceDataGridViewTextBoxColumn
            // 
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.DataPropertyName = "FK_idDeliveryService";
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.HeaderText = "FK_idDeliveryService";
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.Name = "fKidDeliveryServiceDataGridViewTextBoxColumn";
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.Visible = false;
            this.fKidDeliveryServiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // amoutDataGridViewTextBoxColumn
            // 
            this.amoutDataGridViewTextBoxColumn.DataPropertyName = "amout";
            this.amoutDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.amoutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amoutDataGridViewTextBoxColumn.Name = "amoutDataGridViewTextBoxColumn";
            this.amoutDataGridViewTextBoxColumn.ReadOnly = true;
            this.amoutDataGridViewTextBoxColumn.Width = 150;
            // 
            // commissionDataGridViewTextBoxColumn
            // 
            this.commissionDataGridViewTextBoxColumn.DataPropertyName = "commission";
            this.commissionDataGridViewTextBoxColumn.HeaderText = "Комісія";
            this.commissionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.commissionDataGridViewTextBoxColumn.Name = "commissionDataGridViewTextBoxColumn";
            this.commissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.commissionDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKinvoicedFKid603D47BBBindingSource
            // 
            this.fKinvoicedFKid603D47BBBindingSource.DataMember = "FK__invoice_d__FK_id__603D47BB";
            this.fKinvoicedFKid603D47BBBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // invoice_detailTableAdapter
            // 
            this.invoice_detailTableAdapter.ClearBeforeFill = true;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // sellerTableAdapter
            // 
            this.sellerTableAdapter.ClearBeforeFill = true;
            // 
            // delivery_serviceTableAdapter
            // 
            this.delivery_serviceTableAdapter.ClearBeforeFill = true;
            // 
            // buttonReportByYear
            // 
            this.buttonReportByYear.Location = new System.Drawing.Point(30, 518);
            this.buttonReportByYear.Name = "buttonReportByYear";
            this.buttonReportByYear.Size = new System.Drawing.Size(220, 61);
            this.buttonReportByYear.TabIndex = 3;
            this.buttonReportByYear.Text = "Сума цін товарів \r\nпо роках";
            this.buttonReportByYear.UseVisualStyleBackColor = true;
            this.buttonReportByYear.Click += new System.EventHandler(this.buttonReportByDate_Click);
            // 
            // buttonReportByDate
            // 
            this.buttonReportByDate.Location = new System.Drawing.Point(272, 518);
            this.buttonReportByDate.Name = "buttonReportByDate";
            this.buttonReportByDate.Size = new System.Drawing.Size(245, 61);
            this.buttonReportByDate.TabIndex = 4;
            this.buttonReportByDate.Text = "Кількість покупців на місяць \r\nпо роках";
            this.buttonReportByDate.UseVisualStyleBackColor = true;
            this.buttonReportByDate.Click += new System.EventHandler(this.buttonReportByDate_Click_1);
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 604);
            this.Controls.Add(this.buttonReportByDate);
            this.Controls.Add(this.buttonReportByYear);
            this.Controls.Add(this.dataGridViewInvDet);
            this.Controls.Add(this.bindingNavigatorInvoice);
            this.Controls.Add(this.dataGridViewInvoice);
            this.Name = "FormInvoice";
            this.Text = "Накладна";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorInvoice)).EndInit();
            this.bindingNavigatorInvoice.ResumeLayout(false);
            this.bindingNavigatorInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryserviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKinvoicedFKid603D47BBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private storeDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigatorInvoice;
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
        private System.Windows.Forms.BindingSource customerBindingSource;
        private storeDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private storeDataSetTableAdapters.warehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidWarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewInvDet;
        private System.Windows.Forms.BindingSource fKinvoicedFKid603D47BBBindingSource;
        private storeDataSetTableAdapters.invoice_detailTableAdapter invoice_detailTableAdapter;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private storeDataSetTableAdapters.goodTableAdapter goodTableAdapter;
        private System.Windows.Forms.BindingSource sellerBindingSource;
        private storeDataSetTableAdapters.sellerTableAdapter sellerTableAdapter;
        private System.Windows.Forms.BindingSource deliveryserviceBindingSource;
        private storeDataSetTableAdapters.delivery_serviceTableAdapter delivery_serviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInvoiceDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Good;
        private System.Windows.Forms.DataGridViewComboBoxColumn Seller;
        private System.Windows.Forms.DataGridViewComboBoxColumn Delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidSellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidDeliveryServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonReportByYear;
        private System.Windows.Forms.Button buttonReportByDate;
    }
}