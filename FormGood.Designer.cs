namespace CourseDataBase
{
    partial class FormGood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGood));
            this.dataGridViewGood = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingNavigatorGood = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.buttonReportGood = new System.Windows.Forms.Button();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.idGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producingCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodTableAdapter = new CourseDataBase.storeDataSetTableAdapters.goodTableAdapter();
            this.categoryTableAdapter = new CourseDataBase.storeDataSetTableAdapters.categoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGood)).BeginInit();
            this.bindingNavigatorGood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGood
            // 
            this.dataGridViewGood.AutoGenerateColumns = false;
            this.dataGridViewGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGoodDataGridViewTextBoxColumn,
            this.goodNameDataGridViewTextBoxColumn,
            this.fKidCategoryDataGridViewTextBoxColumn,
            this.Category,
            this.producingCountryDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.currentPriceDataGridViewTextBoxColumn});
            this.dataGridViewGood.DataSource = this.goodBindingSource;
            this.dataGridViewGood.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewGood.Name = "dataGridViewGood";
            this.dataGridViewGood.RowHeadersWidth = 62;
            this.dataGridViewGood.RowTemplate.Height = 28;
            this.dataGridViewGood.Size = new System.Drawing.Size(852, 297);
            this.dataGridViewGood.TabIndex = 0;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "FK_idCategory";
            this.Category.DataSource = this.categoryBindingSource;
            this.Category.DisplayMember = "name";
            this.Category.HeaderText = "Категорія";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.ValueMember = "idCategory";
            this.Category.Width = 150;
            // 
            // bindingNavigatorGood
            // 
            this.bindingNavigatorGood.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorGood.BindingSource = this.goodBindingSource;
            this.bindingNavigatorGood.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorGood.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorGood.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorGood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorGood.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorGood.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorGood.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorGood.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorGood.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorGood.Name = "bindingNavigatorGood";
            this.bindingNavigatorGood.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorGood.Size = new System.Drawing.Size(870, 38);
            this.bindingNavigatorGood.TabIndex = 1;
            this.bindingNavigatorGood.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(34, 33);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // buttonReportGood
            // 
            this.buttonReportGood.Location = new System.Drawing.Point(12, 362);
            this.buttonReportGood.Name = "buttonReportGood";
            this.buttonReportGood.Size = new System.Drawing.Size(188, 62);
            this.buttonReportGood.TabIndex = 2;
            this.buttonReportGood.Text = "Товари заданої країни-виробника";
            this.buttonReportGood.UseVisualStyleBackColor = true;
            this.buttonReportGood.Click += new System.EventHandler(this.buttonReportGood_Click);
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
            // idGoodDataGridViewTextBoxColumn
            // 
            this.idGoodDataGridViewTextBoxColumn.DataPropertyName = "idGood";
            this.idGoodDataGridViewTextBoxColumn.HeaderText = "idGood";
            this.idGoodDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idGoodDataGridViewTextBoxColumn.Name = "idGoodDataGridViewTextBoxColumn";
            this.idGoodDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGoodDataGridViewTextBoxColumn.Visible = false;
            this.idGoodDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "good name";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "Назва товару";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKidCategoryDataGridViewTextBoxColumn
            // 
            this.fKidCategoryDataGridViewTextBoxColumn.DataPropertyName = "FK_idCategory";
            this.fKidCategoryDataGridViewTextBoxColumn.HeaderText = "FK_idCategory";
            this.fKidCategoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidCategoryDataGridViewTextBoxColumn.Name = "fKidCategoryDataGridViewTextBoxColumn";
            this.fKidCategoryDataGridViewTextBoxColumn.Visible = false;
            this.fKidCategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.storeDataSet;
            // 
            // producingCountryDataGridViewTextBoxColumn
            // 
            this.producingCountryDataGridViewTextBoxColumn.DataPropertyName = "producing country";
            this.producingCountryDataGridViewTextBoxColumn.HeaderText = "Країна-виробник";
            this.producingCountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.producingCountryDataGridViewTextBoxColumn.Name = "producingCountryDataGridViewTextBoxColumn";
            this.producingCountryDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Одн. виміру";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 150;
            // 
            // currentPriceDataGridViewTextBoxColumn
            // 
            this.currentPriceDataGridViewTextBoxColumn.DataPropertyName = "current price";
            this.currentPriceDataGridViewTextBoxColumn.HeaderText = "Поточна ціна";
            this.currentPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currentPriceDataGridViewTextBoxColumn.Name = "currentPriceDataGridViewTextBoxColumn";
            this.currentPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // FormGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 436);
            this.Controls.Add(this.buttonReportGood);
            this.Controls.Add(this.bindingNavigatorGood);
            this.Controls.Add(this.dataGridViewGood);
            this.Name = "FormGood";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.FormGood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGood)).EndInit();
            this.bindingNavigatorGood.ResumeLayout(false);
            this.bindingNavigatorGood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGood;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private storeDataSetTableAdapters.goodTableAdapter goodTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigatorGood;
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
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private storeDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn producingCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonReportGood;
    }
}