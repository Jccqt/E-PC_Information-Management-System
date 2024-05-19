namespace E_Pc
{
    partial class Inventory
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
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.LogoutLogo = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.EmployeeLogo = new System.Windows.Forms.PictureBox();
            this.EmployeeManagementButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.OrderLogo = new System.Windows.Forms.PictureBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SalesLogo = new System.Windows.Forms.PictureBox();
            this.salesButton = new System.Windows.Forms.Button();
            this.inventoryLogo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InventoryGrid = new System.Windows.Forms.DataGridView();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemMemoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._E_PCdbDataSet_Products = new E_Pc._E_PCdbDataSet_Products();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.productsTableAdapter = new E_Pc._E_PCdbDataSet_ProductsTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutLogo)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeLogo)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderLogo)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryLogo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_PCdbDataSet_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 1;
            // 
            // LogoutLogo
            // 
            this.LogoutLogo.BackColor = System.Drawing.Color.Transparent;
            this.LogoutLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutLogo.Image = global::E_Pc.Properties.Resources.LogOut;
            this.LogoutLogo.Location = new System.Drawing.Point(4, 16);
            this.LogoutLogo.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutLogo.Name = "LogoutLogo";
            this.LogoutLogo.Size = new System.Drawing.Size(83, 53);
            this.LogoutLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoutLogo.TabIndex = 15;
            this.LogoutLogo.TabStop = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(-9, 0);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(323, 84);
            this.LogoutButton.TabIndex = 14;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LogoutLogo);
            this.panel7.Controls.Add(this.LogoutButton);
            this.panel7.Location = new System.Drawing.Point(4, 470);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(305, 84);
            this.panel7.TabIndex = 19;
            // 
            // EmployeeLogo
            // 
            this.EmployeeLogo.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeLogo.Image = global::E_Pc.Properties.Resources.Employee_managemen;
            this.EmployeeLogo.Location = new System.Drawing.Point(4, 9);
            this.EmployeeLogo.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeLogo.Name = "EmployeeLogo";
            this.EmployeeLogo.Size = new System.Drawing.Size(83, 66);
            this.EmployeeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeeLogo.TabIndex = 15;
            this.EmployeeLogo.TabStop = false;
            // 
            // EmployeeManagementButton
            // 
            this.EmployeeManagementButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeManagementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeManagementButton.Location = new System.Drawing.Point(-9, 0);
            this.EmployeeManagementButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeManagementButton.Name = "EmployeeManagementButton";
            this.EmployeeManagementButton.Size = new System.Drawing.Size(323, 84);
            this.EmployeeManagementButton.TabIndex = 14;
            this.EmployeeManagementButton.Text = "                        Employee Management";
            this.EmployeeManagementButton.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.EmployeeLogo);
            this.panel6.Controls.Add(this.EmployeeManagementButton);
            this.panel6.Location = new System.Drawing.Point(4, 378);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(305, 84);
            this.panel6.TabIndex = 18;
            // 
            // OrderLogo
            // 
            this.OrderLogo.BackColor = System.Drawing.Color.Transparent;
            this.OrderLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderLogo.Image = global::E_Pc.Properties.Resources.orderIcon;
            this.OrderLogo.Location = new System.Drawing.Point(4, 9);
            this.OrderLogo.Margin = new System.Windows.Forms.Padding(4);
            this.OrderLogo.Name = "OrderLogo";
            this.OrderLogo.Size = new System.Drawing.Size(83, 66);
            this.OrderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrderLogo.TabIndex = 15;
            this.OrderLogo.TabStop = false;
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderButton.Location = new System.Drawing.Point(-9, 0);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(323, 84);
            this.OrderButton.TabIndex = 14;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.OrderLogo);
            this.panel5.Controls.Add(this.OrderButton);
            this.panel5.Location = new System.Drawing.Point(4, 286);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 84);
            this.panel5.TabIndex = 17;
            // 
            // SalesLogo
            // 
            this.SalesLogo.BackColor = System.Drawing.Color.Transparent;
            this.SalesLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesLogo.Image = global::E_Pc.Properties.Resources.sales;
            this.SalesLogo.Location = new System.Drawing.Point(4, 9);
            this.SalesLogo.Margin = new System.Windows.Forms.Padding(4);
            this.SalesLogo.Name = "SalesLogo";
            this.SalesLogo.Size = new System.Drawing.Size(83, 66);
            this.SalesLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalesLogo.TabIndex = 15;
            this.SalesLogo.TabStop = false;
            // 
            // salesButton
            // 
            this.salesButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.Location = new System.Drawing.Point(-9, 0);
            this.salesButton.Margin = new System.Windows.Forms.Padding(4);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(323, 84);
            this.salesButton.TabIndex = 14;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            // 
            // inventoryLogo
            // 
            this.inventoryLogo.BackColor = System.Drawing.Color.Transparent;
            this.inventoryLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryLogo.Image = global::E_Pc.Properties.Resources.InventoryManagement;
            this.inventoryLogo.Location = new System.Drawing.Point(4, 14);
            this.inventoryLogo.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryLogo.Name = "inventoryLogo";
            this.inventoryLogo.Size = new System.Drawing.Size(83, 52);
            this.inventoryLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inventoryLogo.TabIndex = 15;
            this.inventoryLogo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SalesLogo);
            this.panel4.Controls.Add(this.salesButton);
            this.panel4.Location = new System.Drawing.Point(4, 194);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 84);
            this.panel4.TabIndex = 16;
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.DarkGray;
            this.inventoryButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.Location = new System.Drawing.Point(-9, 0);
            this.inventoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(323, 84);
            this.inventoryButton.TabIndex = 14;
            this.inventoryButton.Text = " Inventory";
            this.inventoryButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.inventoryLogo);
            this.panel3.Controls.Add(this.inventoryButton);
            this.panel3.Location = new System.Drawing.Point(4, 102);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 84);
            this.panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::E_Pc.Properties.Resources.user_removebg_preview;
            this.menuButton.Location = new System.Drawing.Point(17, 17);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(69, 58);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 90);
            this.panel1.TabIndex = 0;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 41);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar.MaximumSize = new System.Drawing.Size(309, 679);
            this.sidebar.MinimumSize = new System.Drawing.Size(104, 679);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(309, 679);
            this.sidebar.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::E_Pc.Properties.Resources.image_removebg_preview__2_;
            this.pictureBox2.Location = new System.Drawing.Point(44, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = global::E_Pc.Properties.Resources.image_removebg_preview__1_;
            this.ExitBtn.Location = new System.Drawing.Point(1233, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(27, 26);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.ExitBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1280, 41);
            this.guna2Panel1.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::E_Pc.Properties.Resources.inventory_removebg_preview1;
            this.pictureBox3.Location = new System.Drawing.Point(568, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(491, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // InventoryGrid
            // 
            this.InventoryGrid.AutoGenerateColumns = false;
            this.InventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemBrandDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.itemQuantityDataGridViewTextBoxColumn,
            this.itemTypeDataGridViewTextBoxColumn,
            this.itemMemoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.InventoryGrid.DataSource = this.productsBindingSource;
            this.InventoryGrid.Location = new System.Drawing.Point(325, 169);
            this.InventoryGrid.Name = "InventoryGrid";
            this.InventoryGrid.ReadOnly = true;
            this.InventoryGrid.RowHeadersWidth = 51;
            this.InventoryGrid.RowTemplate.Height = 24;
            this.InventoryGrid.Size = new System.Drawing.Size(943, 386);
            this.InventoryGrid.TabIndex = 21;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemBrandDataGridViewTextBoxColumn
            // 
            this.itemBrandDataGridViewTextBoxColumn.DataPropertyName = "ItemBrand";
            this.itemBrandDataGridViewTextBoxColumn.HeaderText = "ItemBrand";
            this.itemBrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemBrandDataGridViewTextBoxColumn.Name = "itemBrandDataGridViewTextBoxColumn";
            this.itemBrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemBrandDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemQuantityDataGridViewTextBoxColumn
            // 
            this.itemQuantityDataGridViewTextBoxColumn.DataPropertyName = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.HeaderText = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemQuantityDataGridViewTextBoxColumn.Name = "itemQuantityDataGridViewTextBoxColumn";
            this.itemQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            this.itemTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemMemoDataGridViewTextBoxColumn
            // 
            this.itemMemoDataGridViewTextBoxColumn.DataPropertyName = "ItemMemo";
            this.itemMemoDataGridViewTextBoxColumn.HeaderText = "ItemMemo";
            this.itemMemoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemMemoDataGridViewTextBoxColumn.Name = "itemMemoDataGridViewTextBoxColumn";
            this.itemMemoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemMemoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this._E_PCdbDataSet_Products;
            // 
            // _E_PCdbDataSet_Products
            // 
            this._E_PCdbDataSet_Products.DataSetName = "_E_PCdbDataSet_Products";
            this._E_PCdbDataSet_Products.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddBtn
            // 
            this.AddBtn.Animated = true;
            this.AddBtn.AutoRoundedCorners = true;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BorderRadius = 35;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(503, 586);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(180, 73);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Animated = true;
            this.UpdateBtn.AutoRoundedCorners = true;
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.BorderRadius = 35;
            this.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtn.FillColor = System.Drawing.Color.White;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateBtn.Location = new System.Drawing.Point(739, 586);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(180, 73);
            this.UpdateBtn.TabIndex = 23;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Animated = true;
            this.DeleteBtn.AutoRoundedCorners = true;
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BorderRadius = 35;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(972, 586);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(180, 73);
            this.DeleteBtn.TabIndex = 24;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Pc.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.InventoryGrid);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryPage";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoutLogo)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeLogo)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderLogo)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryLogo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_PCdbDataSet_Products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.PictureBox LogoutLogo;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox EmployeeLogo;
        private System.Windows.Forms.Button EmployeeManagementButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox OrderLogo;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox SalesLogo;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.PictureBox inventoryLogo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ExitBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        public System.Windows.Forms.DataGridView InventoryGrid;
        private _E_PCdbDataSet_Products _E_PCdbDataSet_Products;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _E_PCdbDataSet_ProductsTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemMemoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}