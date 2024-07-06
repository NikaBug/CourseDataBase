namespace CourseDataBase
{
    partial class FormCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.idCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.categoryTableAdapter = new CourseDataBase.storeDataSetTableAdapters.categoryTableAdapter();
            this.bindingNavigatorCategory = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataGridViewGood = new System.Windows.Forms.DataGridView();
            this.idGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producingCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKgoodFKidCateg5B78929EBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodTableAdapter = new CourseDataBase.storeDataSetTableAdapters.goodTableAdapter();
            this.buttonCountGood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCategory)).BeginInit();
            this.bindingNavigatorCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKgoodFKidCateg5B78929EBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AutoGenerateColumns = false;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoryDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewCategory.DataSource = this.categoryBindingSource;
            this.dataGridViewCategory.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 62;
            this.dataGridViewCategory.RowTemplate.Height = 28;
            this.dataGridViewCategory.Size = new System.Drawing.Size(762, 308);
            this.dataGridViewCategory.TabIndex = 0;
            // 
            // idCategoryDataGridViewTextBoxColumn
            // 
            this.idCategoryDataGridViewTextBoxColumn.DataPropertyName = "idCategory";
            this.idCategoryDataGridViewTextBoxColumn.HeaderText = "idCategory";
            this.idCategoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCategoryDataGridViewTextBoxColumn.Name = "idCategoryDataGridViewTextBoxColumn";
            this.idCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategoryDataGridViewTextBoxColumn.Visible = false;
            this.idCategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва категорії";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorCategory
            // 
            this.bindingNavigatorCategory.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorCategory.BindingSource = this.categoryBindingSource;
            this.bindingNavigatorCategory.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorCategory.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorCategory.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorCategory.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorCategory.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorCategory.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorCategory.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorCategory.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorCategory.Name = "bindingNavigatorCategory";
            this.bindingNavigatorCategory.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorCategory.Size = new System.Drawing.Size(804, 33);
            this.bindingNavigatorCategory.TabIndex = 1;
            this.bindingNavigatorCategory.Text = "bindingNavigator1";
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
            // dataGridViewGood
            // 
            this.dataGridViewGood.AllowUserToAddRows = false;
            this.dataGridViewGood.AllowUserToDeleteRows = false;
            this.dataGridViewGood.AutoGenerateColumns = false;
            this.dataGridViewGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGoodDataGridViewTextBoxColumn,
            this.goodNameDataGridViewTextBoxColumn,
            this.fKidCategoryDataGridViewTextBoxColumn,
            this.producingCountryDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.currentPriceDataGridViewTextBoxColumn});
            this.dataGridViewGood.DataSource = this.fKgoodFKidCateg5B78929EBindingSource;
            this.dataGridViewGood.Location = new System.Drawing.Point(12, 382);
            this.dataGridViewGood.Name = "dataGridViewGood";
            this.dataGridViewGood.ReadOnly = true;
            this.dataGridViewGood.RowHeadersWidth = 62;
            this.dataGridViewGood.RowTemplate.Height = 28;
            this.dataGridViewGood.Size = new System.Drawing.Size(762, 223);
            this.dataGridViewGood.TabIndex = 2;
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
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKidCategoryDataGridViewTextBoxColumn
            // 
            this.fKidCategoryDataGridViewTextBoxColumn.DataPropertyName = "FK_idCategory";
            this.fKidCategoryDataGridViewTextBoxColumn.HeaderText = "FK_idCategory";
            this.fKidCategoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fKidCategoryDataGridViewTextBoxColumn.Name = "fKidCategoryDataGridViewTextBoxColumn";
            this.fKidCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.fKidCategoryDataGridViewTextBoxColumn.Visible = false;
            this.fKidCategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // producingCountryDataGridViewTextBoxColumn
            // 
            this.producingCountryDataGridViewTextBoxColumn.DataPropertyName = "producing country";
            this.producingCountryDataGridViewTextBoxColumn.HeaderText = "Країна-виробник";
            this.producingCountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.producingCountryDataGridViewTextBoxColumn.Name = "producingCountryDataGridViewTextBoxColumn";
            this.producingCountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.producingCountryDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Одн. виміру";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 150;
            // 
            // currentPriceDataGridViewTextBoxColumn
            // 
            this.currentPriceDataGridViewTextBoxColumn.DataPropertyName = "current price";
            this.currentPriceDataGridViewTextBoxColumn.HeaderText = "Поточна ціна";
            this.currentPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currentPriceDataGridViewTextBoxColumn.Name = "currentPriceDataGridViewTextBoxColumn";
            this.currentPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKgoodFKidCateg5B78929EBindingSource
            // 
            this.fKgoodFKidCateg5B78929EBindingSource.DataMember = "FK__good__FK_idCateg__5B78929E";
            this.fKgoodFKidCateg5B78929EBindingSource.DataSource = this.categoryBindingSource;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // buttonCountGood
            // 
            this.buttonCountGood.Location = new System.Drawing.Point(12, 618);
            this.buttonCountGood.Name = "buttonCountGood";
            this.buttonCountGood.Size = new System.Drawing.Size(276, 54);
            this.buttonCountGood.TabIndex = 3;
            this.buttonCountGood.Text = "Кількість товарів в категоріях \r\nта ціна найдорожчого товару";
            this.buttonCountGood.UseVisualStyleBackColor = true;
            this.buttonCountGood.Click += new System.EventHandler(this.buttonCountGood_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 684);
            this.Controls.Add(this.buttonCountGood);
            this.Controls.Add(this.dataGridViewGood);
            this.Controls.Add(this.bindingNavigatorCategory);
            this.Controls.Add(this.dataGridViewCategory);
            this.Name = "FormCategory";
            this.Text = "Категорія";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCategory)).EndInit();
            this.bindingNavigatorCategory.ResumeLayout(false);
            this.bindingNavigatorCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKgoodFKidCateg5B78929EBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private storeDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCategory;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewGood;
        private System.Windows.Forms.BindingSource fKgoodFKidCateg5B78929EBindingSource;
        private storeDataSetTableAdapters.goodTableAdapter goodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producingCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCountGood;
    }
}