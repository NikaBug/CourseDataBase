namespace CourseDataBase
{
    partial class FormGoodsInWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodsInWarehouse));
            this.dataGridViewGoodsInWarehouse = new System.Windows.Forms.DataGridView();
            this.idGoodsInWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.fKidWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amoutInWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsinwarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goods_in_warehouseTableAdapter = new CourseDataBase.storeDataSetTableAdapters.goods_in_warehouseTableAdapter();
            this.goodTableAdapter = new CourseDataBase.storeDataSetTableAdapters.goodTableAdapter();
            this.warehouseTableAdapter = new CourseDataBase.storeDataSetTableAdapters.warehouseTableAdapter();
            this.bindingNavigatorGIW = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.buttonReportTotalSum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoodsInWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsinwarehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGIW)).BeginInit();
            this.bindingNavigatorGIW.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGoodsInWarehouse
            // 
            this.dataGridViewGoodsInWarehouse.AutoGenerateColumns = false;
            this.dataGridViewGoodsInWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoodsInWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGoodsInWarehouseDataGridViewTextBoxColumn,
            this.fKidGoodDataGridViewTextBoxColumn,
            this.Good,
            this.fKidWarehouseDataGridViewTextBoxColumn,
            this.Warehouse,
            this.amoutInWarehouseDataGridViewTextBoxColumn,
            this.nameDepartmentDataGridViewTextBoxColumn});
            this.dataGridViewGoodsInWarehouse.DataSource = this.goodsinwarehouseBindingSource;
            this.dataGridViewGoodsInWarehouse.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewGoodsInWarehouse.Name = "dataGridViewGoodsInWarehouse";
            this.dataGridViewGoodsInWarehouse.RowHeadersWidth = 62;
            this.dataGridViewGoodsInWarehouse.RowTemplate.Height = 28;
            this.dataGridViewGoodsInWarehouse.Size = new System.Drawing.Size(776, 251);
            this.dataGridViewGoodsInWarehouse.TabIndex = 0;
            // 
            // idGoodsInWarehouseDataGridViewTextBoxColumn
            // 
            this.idGoodsInWarehouseDataGridViewTextBoxColumn.DataPropertyName = "idGoodsInWarehouse";
            this.idGoodsInWarehouseDataGridViewTextBoxColumn.HeaderText = "idGoodsInWarehouse";
            this.idGoodsInWarehouseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idGoodsInWarehouseDataGridViewTextBoxColumn.Name = "idGoodsInWarehouseDataGridViewTextBoxColumn";
            this.idGoodsInWarehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGoodsInWarehouseDataGridViewTextBoxColumn.Visible = false;
            this.idGoodsInWarehouseDataGridViewTextBoxColumn.Width = 150;
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
            // amoutInWarehouseDataGridViewTextBoxColumn
            // 
            this.amoutInWarehouseDataGridViewTextBoxColumn.DataPropertyName = "Amout in warehouse";
            this.amoutInWarehouseDataGridViewTextBoxColumn.HeaderText = "Кількість на складі";
            this.amoutInWarehouseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amoutInWarehouseDataGridViewTextBoxColumn.Name = "amoutInWarehouseDataGridViewTextBoxColumn";
            this.amoutInWarehouseDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDepartmentDataGridViewTextBoxColumn
            // 
            this.nameDepartmentDataGridViewTextBoxColumn.DataPropertyName = "Name department";
            this.nameDepartmentDataGridViewTextBoxColumn.HeaderText = "Назва відділу";
            this.nameDepartmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDepartmentDataGridViewTextBoxColumn.Name = "nameDepartmentDataGridViewTextBoxColumn";
            this.nameDepartmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodsinwarehouseBindingSource
            // 
            this.goodsinwarehouseBindingSource.DataMember = "goods_in_warehouse";
            this.goodsinwarehouseBindingSource.DataSource = this.storeDataSet;
            // 
            // goods_in_warehouseTableAdapter
            // 
            this.goods_in_warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorGIW
            // 
            this.bindingNavigatorGIW.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorGIW.BindingSource = this.goodsinwarehouseBindingSource;
            this.bindingNavigatorGIW.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorGIW.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorGIW.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorGIW.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorGIW.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorGIW.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorGIW.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorGIW.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorGIW.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorGIW.Name = "bindingNavigatorGIW";
            this.bindingNavigatorGIW.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorGIW.Size = new System.Drawing.Size(794, 33);
            this.bindingNavigatorGIW.TabIndex = 1;
            this.bindingNavigatorGIW.Text = "bindingNavigator1";
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
            // buttonReportTotalSum
            // 
            this.buttonReportTotalSum.Location = new System.Drawing.Point(22, 330);
            this.buttonReportTotalSum.Name = "buttonReportTotalSum";
            this.buttonReportTotalSum.Size = new System.Drawing.Size(222, 68);
            this.buttonReportTotalSum.TabIndex = 2;
            this.buttonReportTotalSum.Text = "Сума цін кожного товару на складі";
            this.buttonReportTotalSum.UseVisualStyleBackColor = true;
            this.buttonReportTotalSum.Click += new System.EventHandler(this.buttonReportTotalSum_Click);
            // 
            // FormGoodsInWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 411);
            this.Controls.Add(this.buttonReportTotalSum);
            this.Controls.Add(this.bindingNavigatorGIW);
            this.Controls.Add(this.dataGridViewGoodsInWarehouse);
            this.Name = "FormGoodsInWarehouse";
            this.Text = "Товари на складі";
            this.Load += new System.EventHandler(this.FormGoodsInWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoodsInWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsinwarehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGIW)).EndInit();
            this.bindingNavigatorGIW.ResumeLayout(false);
            this.bindingNavigatorGIW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGoodsInWarehouse;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource goodsinwarehouseBindingSource;
        private storeDataSetTableAdapters.goods_in_warehouseTableAdapter goods_in_warehouseTableAdapter;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private storeDataSetTableAdapters.goodTableAdapter goodTableAdapter;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private storeDataSetTableAdapters.warehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGoodsInWarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Good;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidWarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoutInWarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigatorGIW;
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
        private System.Windows.Forms.Button buttonReportTotalSum;
    }
}