namespace CourseDataBase
{
    partial class FormDeliveryService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeliveryService));
            this.dataGridViewDeliveryService = new System.Windows.Forms.DataGridView();
            this.idDeliveryServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryserviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.bindingNavigatorDeliveryService = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.buttonAveragePrice = new System.Windows.Forms.Button();
            this.delivery_serviceTableAdapter = new CourseDataBase.storeDataSetTableAdapters.delivery_serviceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveryService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryserviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDeliveryService)).BeginInit();
            this.bindingNavigatorDeliveryService.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDeliveryService
            // 
            this.dataGridViewDeliveryService.AutoGenerateColumns = false;
            this.dataGridViewDeliveryService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeliveryService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDeliveryServiceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDeliveryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewDeliveryService.DataSource = this.deliveryserviceBindingSource;
            this.dataGridViewDeliveryService.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewDeliveryService.Name = "dataGridViewDeliveryService";
            this.dataGridViewDeliveryService.RowHeadersWidth = 62;
            this.dataGridViewDeliveryService.RowTemplate.Height = 28;
            this.dataGridViewDeliveryService.Size = new System.Drawing.Size(754, 263);
            this.dataGridViewDeliveryService.TabIndex = 0;
            // 
            // idDeliveryServiceDataGridViewTextBoxColumn
            // 
            this.idDeliveryServiceDataGridViewTextBoxColumn.DataPropertyName = "idDeliveryService";
            this.idDeliveryServiceDataGridViewTextBoxColumn.HeaderText = "idDeliveryService";
            this.idDeliveryServiceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDeliveryServiceDataGridViewTextBoxColumn.Name = "idDeliveryServiceDataGridViewTextBoxColumn";
            this.idDeliveryServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDeliveryServiceDataGridViewTextBoxColumn.Visible = false;
            this.idDeliveryServiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDeliveryDataGridViewTextBoxColumn
            // 
            this.typeDeliveryDataGridViewTextBoxColumn.DataPropertyName = "type delivery";
            this.typeDeliveryDataGridViewTextBoxColumn.HeaderText = "Тип доставки";
            this.typeDeliveryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDeliveryDataGridViewTextBoxColumn.Name = "typeDeliveryDataGridViewTextBoxColumn";
            this.typeDeliveryDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliveryserviceBindingSource
            // 
            this.deliveryserviceBindingSource.DataMember = "delivery_service";
            this.deliveryserviceBindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeliveryService
            // 
            this.bindingNavigatorDeliveryService.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorDeliveryService.BindingSource = this.deliveryserviceBindingSource;
            this.bindingNavigatorDeliveryService.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorDeliveryService.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorDeliveryService.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeliveryService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeliveryService.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorDeliveryService.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorDeliveryService.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorDeliveryService.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorDeliveryService.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorDeliveryService.Name = "bindingNavigatorDeliveryService";
            this.bindingNavigatorDeliveryService.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorDeliveryService.Size = new System.Drawing.Size(776, 33);
            this.bindingNavigatorDeliveryService.TabIndex = 1;
            this.bindingNavigatorDeliveryService.Text = "bindingNavigator1";
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
            // buttonAveragePrice
            // 
            this.buttonAveragePrice.Location = new System.Drawing.Point(22, 342);
            this.buttonAveragePrice.Name = "buttonAveragePrice";
            this.buttonAveragePrice.Size = new System.Drawing.Size(216, 70);
            this.buttonAveragePrice.TabIndex = 2;
            this.buttonAveragePrice.Text = "Середня ціна доставки";
            this.buttonAveragePrice.UseVisualStyleBackColor = true;
            this.buttonAveragePrice.Click += new System.EventHandler(this.buttonAveragePrice_Click);
            // 
            // delivery_serviceTableAdapter
            // 
            this.delivery_serviceTableAdapter.ClearBeforeFill = true;
            // 
            // FormDeliveryService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 429);
            this.Controls.Add(this.buttonAveragePrice);
            this.Controls.Add(this.bindingNavigatorDeliveryService);
            this.Controls.Add(this.dataGridViewDeliveryService);
            this.Name = "FormDeliveryService";
            this.Text = "Служба доставки";
            this.Load += new System.EventHandler(this.FormDeliveryService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveryService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryserviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDeliveryService)).EndInit();
            this.bindingNavigatorDeliveryService.ResumeLayout(false);
            this.bindingNavigatorDeliveryService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDeliveryService;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource deliveryserviceBindingSource;
        private storeDataSetTableAdapters.delivery_serviceTableAdapter delivery_serviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeliveryServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDeliveryService;
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
        private System.Windows.Forms.Button buttonAveragePrice;
    }
}