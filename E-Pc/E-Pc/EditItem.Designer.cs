namespace E_Pc
{
    partial class EditItem
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
            this.ItemImage = new System.Windows.Forms.PictureBox();
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
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            this.SelectImageBtn = new System.Windows.Forms.Button();
            this.SelectImage = new System.Windows.Forms.OpenFileDialog();
            this.EditBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.BackColor = System.Drawing.Color.White;
            this.ActivityLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityLabel.ForeColor = System.Drawing.Color.Black;
            this.ActivityLabel.Location = new System.Drawing.Point(181, 15);
            this.ActivityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(150, 33);
            this.ActivityLabel.TabIndex = 0;
            this.ActivityLabel.Text = "<Activity>";
            this.ActivityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.Black;
            this.IdLabel.Location = new System.Drawing.Point(181, 241);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(132, 33);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "<ItemId>";
            // 
            // ItemImage
            // 
            this.ItemImage.BackColor = System.Drawing.Color.DarkGray;
            this.ItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemImage.Location = new System.Drawing.Point(139, 74);
            this.ItemImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(222, 163);
            this.ItemImage.TabIndex = 1;
            this.ItemImage.TabStop = false;
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(28, 334);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(298, 34);
            this.NameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name*";
            // 
            // BrandBox
            // 
            this.BrandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrandBox.Enabled = false;
            this.BrandBox.Location = new System.Drawing.Point(344, 332);
            this.BrandBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrandBox.Multiline = true;
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(129, 34);
            this.BrandBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(340, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Item Brand*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(275, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Category*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Item Type*";
            // 
            // PriceBox
            // 
            this.PriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceBox.Enabled = false;
            this.PriceBox.Location = new System.Drawing.Point(28, 498);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriceBox.Multiline = true;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(194, 34);
            this.PriceBox.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Price*";
            // 
            // QuantityBox
            // 
            this.QuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityBox.Enabled = false;
            this.QuantityBox.Location = new System.Drawing.Point(279, 498);
            this.QuantityBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuantityBox.Multiline = true;
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(194, 34);
            this.QuantityBox.TabIndex = 37;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.ForeColor = System.Drawing.Color.Black;
            this.QuantityLabel.Location = new System.Drawing.Point(275, 479);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(60, 16);
            this.QuantityLabel.TabIndex = 36;
            this.QuantityLabel.Text = "Quantity*";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionBox.Enabled = false;
            this.DescriptionBox.Location = new System.Drawing.Point(29, 580);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(443, 80);
            this.DescriptionBox.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(27, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Description (250 max characters)";
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoRoundedCorners = true;
            this.SaveBtn.BorderRadius = 16;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(208, 687);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(125, 34);
            this.SaveBtn.TabIndex = 44;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoRoundedCorners = true;
            this.CancelBtn.BorderRadius = 16;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(341, 687);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(132, 34);
            this.CancelBtn.TabIndex = 45;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Visible = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TypeBox.Enabled = false;
            this.TypeBox.Location = new System.Drawing.Point(28, 415);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeBox.Multiline = true;
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(194, 34);
            this.TypeBox.TabIndex = 46;
            // 
            // CategoryBox
            // 
            this.CategoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryBox.Enabled = false;
            this.CategoryBox.Location = new System.Drawing.Point(279, 415);
            this.CategoryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryBox.Multiline = true;
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(194, 34);
            this.CategoryBox.TabIndex = 47;
            // 
            // SelectImageBtn
            // 
            this.SelectImageBtn.BackColor = System.Drawing.Color.White;
            this.SelectImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectImageBtn.Location = new System.Drawing.Point(180, 278);
            this.SelectImageBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectImageBtn.Name = "SelectImageBtn";
            this.SelectImageBtn.Size = new System.Drawing.Size(149, 28);
            this.SelectImageBtn.TabIndex = 48;
            this.SelectImageBtn.Text = "Select Image";
            this.SelectImageBtn.UseVisualStyleBackColor = false;
            this.SelectImageBtn.Visible = false;
            this.SelectImageBtn.Click += new System.EventHandler(this.SelectImageBtn_Click);
            // 
            // SelectImage
            // 
            this.SelectImage.FileName = "openFileDialog1";
            this.SelectImage.Filter = "Image files | *.png; *.jpeg; *.jpg;";
            // 
            // EditBtn
            // 
            this.EditBtn.Image = global::E_Pc.Properties.Resources.image_removebg_preview__6_;
            this.EditBtn.Location = new System.Drawing.Point(449, 10);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(41, 38);
            this.EditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditBtn.TabIndex = 49;
            this.EditBtn.TabStop = false;
            this.EditBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SelectImageBtn);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
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
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditItem";
            this.Size = new System.Drawing.Size(507, 748);
            this.Load += new System.EventHandler(this.EditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBtn)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        public System.Windows.Forms.TextBox TypeBox;
        public System.Windows.Forms.TextBox CategoryBox;
        private System.Windows.Forms.Button SelectImageBtn;
        private System.Windows.Forms.OpenFileDialog SelectImage;
        private System.Windows.Forms.PictureBox EditBtn;
    }
}
