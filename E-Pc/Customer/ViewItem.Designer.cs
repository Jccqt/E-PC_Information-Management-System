namespace Customer
{
    partial class ViewItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            this.QuantityToOrder = new System.Windows.Forms.Label();
            this.AddToCartBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PlusBtn = new System.Windows.Forms.Label();
            this.MinusBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityLabel.ForeColor = System.Drawing.Color.Black;
            this.ActivityLabel.Location = new System.Drawing.Point(138, 10);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(118, 27);
            this.ActivityLabel.TabIndex = 0;
            this.ActivityLabel.Text = "<Activity>";
            this.ActivityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.Black;
            this.IdLabel.Location = new System.Drawing.Point(141, 196);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(105, 27);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "<ItemId>";
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(21, 271);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(224, 28);
            this.NameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name*";
            // 
            // BrandBox
            // 
            this.BrandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrandBox.Enabled = false;
            this.BrandBox.Location = new System.Drawing.Point(258, 270);
            this.BrandBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrandBox.Multiline = true;
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(97, 28);
            this.BrandBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(255, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item Brand*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(206, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Category*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Item Type*";
            // 
            // PriceBox
            // 
            this.PriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceBox.Enabled = false;
            this.PriceBox.Location = new System.Drawing.Point(21, 405);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceBox.Multiline = true;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(146, 28);
            this.PriceBox.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 389);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Price*";
            // 
            // QuantityBox
            // 
            this.QuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityBox.Enabled = false;
            this.QuantityBox.Location = new System.Drawing.Point(209, 405);
            this.QuantityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuantityBox.Multiline = true;
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(146, 28);
            this.QuantityBox.TabIndex = 37;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.ForeColor = System.Drawing.Color.Black;
            this.QuantityLabel.Location = new System.Drawing.Point(206, 389);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(50, 13);
            this.QuantityLabel.TabIndex = 36;
            this.QuantityLabel.Text = "Quantity*";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionBox.Enabled = false;
            this.DescriptionBox.Location = new System.Drawing.Point(22, 471);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(333, 65);
            this.DescriptionBox.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 455);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Description (250 max characters)";
            // 
            // TypeBox
            // 
            this.TypeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TypeBox.Enabled = false;
            this.TypeBox.Location = new System.Drawing.Point(21, 337);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeBox.Multiline = true;
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(146, 28);
            this.TypeBox.TabIndex = 46;
            // 
            // CategoryBox
            // 
            this.CategoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryBox.Enabled = false;
            this.CategoryBox.Location = new System.Drawing.Point(209, 337);
            this.CategoryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryBox.Multiline = true;
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(146, 28);
            this.CategoryBox.TabIndex = 47;
            // 
            // QuantityToOrder
            // 
            this.QuantityToOrder.AutoSize = true;
            this.QuantityToOrder.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityToOrder.ForeColor = System.Drawing.Color.Black;
            this.QuantityToOrder.Location = new System.Drawing.Point(177, 576);
            this.QuantityToOrder.Name = "QuantityToOrder";
            this.QuantityToOrder.Size = new System.Drawing.Size(25, 27);
            this.QuantityToOrder.TabIndex = 48;
            this.QuantityToOrder.Text = "0";
            this.QuantityToOrder.Click += new System.EventHandler(this.QuantityToOrder_Click);
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.AutoRoundedCorners = true;
            this.AddToCartBtn.BorderRadius = 13;
            this.AddToCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToCartBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddToCartBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddToCartBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddToCartBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddToCartBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddToCartBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartBtn.ForeColor = System.Drawing.Color.White;
            this.AddToCartBtn.Location = new System.Drawing.Point(251, 622);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(112, 28);
            this.AddToCartBtn.TabIndex = 49;
            this.AddToCartBtn.Text = "Add to cart";
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.AutoSize = true;
            this.PlusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusBtn.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.PlusBtn.Location = new System.Drawing.Point(228, 576);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(39, 27);
            this.PlusBtn.TabIndex = 50;
            this.PlusBtn.Text = "[+]";
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.AutoSize = true;
            this.MinusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusBtn.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusBtn.ForeColor = System.Drawing.Color.Red;
            this.MinusBtn.Location = new System.Drawing.Point(122, 576);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(36, 27);
            this.MinusBtn.TabIndex = 51;
            this.MinusBtn.Text = "[–]";
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 27);
            this.label1.TabIndex = 52;
            this.label1.Text = "Quantity to order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ItemImage
            // 
            this.ItemImage.BackColor = System.Drawing.Color.DarkGray;
            this.ItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemImage.Location = new System.Drawing.Point(109, 60);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(167, 133);
            this.ItemImage.TabIndex = 1;
            this.ItemImage.TabStop = false;
            // 
            // ViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.AddToCartBtn);
            this.Controls.Add(this.QuantityToOrder);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.ItemImage);
            this.Controls.Add(this.ActivityLabel);
            this.DoubleBuffered = true;
            this.Name = "ViewItem";
            this.Size = new System.Drawing.Size(380, 657);
            this.Load += new System.EventHandler(this.ViewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox ItemImage;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.Label IdLabel;
        public System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Label QuantityLabel;
        public System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TypeBox;
        public System.Windows.Forms.TextBox CategoryBox;
        private System.Windows.Forms.Label QuantityToOrder;
        private Guna.UI2.WinForms.Guna2Button AddToCartBtn;
        private System.Windows.Forms.Label PlusBtn;
        private System.Windows.Forms.Label MinusBtn;
        private System.Windows.Forms.Label label1;
    }
}
