namespace CourseDataBase
{
    partial class FormWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarehouse));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.warehouseTableAdapter = new CourseDataBase.storeDataSetTableAdapters.warehouseTableAdapter();
            this.bindingNavigatorWarehouse = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fKgoodsinFKid67DE6983BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goods_in_warehouseTableAdapter = new CourseDataBase.storeDataSetTableAdapters.goods_in_warehouseTableAdapter();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodTableAdapter = new CourseDataBase.storeDataSetTableAdapters.goodTableAdapter();
            this.idGoodsInWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fKidWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoutInWarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorWarehouse)).BeginInit();
            this.bindingNavigatorWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKgoodsinFKid67DE6983BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWarehouseDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.warehouseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(888, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // idWarehouseDataGridViewTextBoxColumn
            // 
            this.idWarehouseDataGridViewTextBoxColumn.DataPropertyName = "idWarehouse";
            this.idWarehouseDataGridViewTextBoxColumn.HeaderText = "idWarehouse";
            this.idWarehouseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idWarehouseDataGridViewTextBoxColumn.Name = "idWarehouseDataGridViewTextBoxColumn";
            this.idWarehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idWarehouseDataGridViewTextBoxColumn.Visible = false;
            this.idWarehouseDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Клас приміщення";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 150;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Площа";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 150;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "warehouse";
            this.warehouseBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorWarehouse
            // 
            this.bindingNavigatorWarehouse.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorWarehouse.BindingSource = this.warehouseBindingSource;
            this.bindingNavigatorWarehouse.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorWarehouse.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorWarehouse.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorWarehouse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorWarehouse.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorWarehouse.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorWarehouse.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorWarehouse.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorWarehouse.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorWarehouse.Name = "bindingNavigatorWarehouse";
            this.bindingNavigatorWarehouse.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorWarehouse.Size = new System.Drawing.Size(912, 38);
            this.bindingNavigatorWarehouse.TabIndex = 1;
            this.bindingNavigatorWarehouse.Text = "bindingNavigator1";
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGoodsInWarehouseDataGridViewTextBoxColumn,
            this.fKidGoodDataGridViewTextBoxColumn,
            this.Good,
            this.fKidWarehouseDataGridViewTextBoxColumn,
            this.amoutInWarehouseDataGridViewTextBoxColumn,
            this.nameDepartmentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKgoodsinFKid67DE6983BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 360);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(888, 241);
            this.dataGridView2.TabIndex = 2;
            // 
            // fKgoodsinFKid67DE6983BindingSource
            // 
            this.fKgoodsinFKid67DE6983BindingSource.DataMember = "FK__goods_in___FK_id__67DE6983";
            this.fKgoodsinFKid67DE6983BindingSource.DataSource = this.warehouseBindingSource;
            // 
            // goods_in_warehouseTableAdapter
            // 
            this.goods_in_warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "good";
            this.goodBindingSource.DataSource = this.storeDataSet;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
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
            // fKidWarehouseDataGridViewTextBoxColumn
            // 
            this.fKidWarehouseDataGridViewTextBoxColumn.DataPropertyName = "FK_idWarehouse";
            this.fKidWarehouseDataGridViewTextBoxColumn.HeaderText = "FK_idWarehouse";
            this.fKidWarehouseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidWarehouseDataGridViewTextBoxColumn.Name = "fKidWarehouseDataGridViewTextBoxColumn";
            this.fKidWarehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKidWarehouseDataGridViewTextBoxColumn.Visible = false;
            this.fKidWarehouseDataGridViewTextBoxColumn.Width = 150;
            // 
            // amoutInWarehouseDataGridViewTextBoxColumn
            // 
            this.amoutInWarehouseDataGridViewTextBoxColumn.DataPropertyName = "Amout in warehouse";
            this.amoutInWarehouseDataGridViewTextBoxColumn.HeaderText = "Кількість на складі";
            this.amoutInWarehouseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amoutInWarehouseDataGridViewTextBoxColumn.Name = "amoutInWarehouseDataGridViewTextBoxColumn";
            this.amoutInWarehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.amoutInWarehouseDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDepartmentDataGridViewTextBoxColumn
            // 
            this.nameDepartmentDataGridViewTextBoxColumn.DataPropertyName = "Name department";
            this.nameDepartmentDataGridViewTextBoxColumn.HeaderText = "Назва відділу";
            this.nameDepartmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDepartmentDataGridViewTextBoxColumn.Name = "nameDepartmentDataGridViewTextBoxColumn";
            this.nameDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDepartmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 613);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bindingNavigatorWarehouse);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormWarehouse";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.FormWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorWarehouse)).EndInit();
            this.bindingNavigatorWarehouse.ResumeLayout(false);
            this.bindingNavigatorWarehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKgoodsinFKid67DE6983BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private storeDataSetTableAdapters.warehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigatorWarehouse;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKgoodsinFKid67DE6983BindingSource;
        private storeDataSetTableAdapters.goods_in_warehouseTableAdapter goods_in_warehouseTableAdapter;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private storeDataSetTableAdapters.goodTableAdapter goodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGoodsInWarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Good;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidWarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoutInWarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDepartmentDataGridViewTextBoxColumn;
    }
}