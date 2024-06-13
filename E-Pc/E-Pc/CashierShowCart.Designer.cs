namespace E_Pc
{
    partial class CashierShowCart
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
            this.CheckoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalQuantityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CartPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.checkoutArrowBtn = new System.Windows.Forms.PictureBox();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CancelOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutArrowBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.AutoRoundedCorners = true;
            this.CheckoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckoutBtn.BorderRadius = 35;
            this.CheckoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckoutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CheckoutBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.CheckoutBtn.ForeColor = System.Drawing.Color.White;
            this.CheckoutBtn.Location = new System.Drawing.Point(956, 574);
            this.CheckoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(272, 73);
            this.CheckoutBtn.TabIndex = 35;
            this.CheckoutBtn.Text = "Proceed to checkout";
            this.CheckoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total items:";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CodeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLabel.ForeColor = System.Drawing.Color.White;
            this.CodeLabel.Location = new System.Drawing.Point(188, 52);
            this.CodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(80, 24);
            this.CodeLabel.TabIndex = 33;
            this.CodeLabel.Text = "<code>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "Cart code:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(188, 80);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(93, 24);
            this.StatusLabel.TabIndex = 31;
            this.StatusLabel.Text = "<status>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(39, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Status:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(188, 108);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(75, 24);
            this.DateLabel.TabIndex = 29;
            this.DateLabel.Text = "<date>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date:";
            // 
            // TotalQuantityLabel
            // 
            this.TotalQuantityLabel.AutoSize = true;
            this.TotalQuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalQuantityLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalQuantityLabel.ForeColor = System.Drawing.Color.White;
            this.TotalQuantityLabel.Location = new System.Drawing.Point(188, 140);
            this.TotalQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalQuantityLabel.Name = "TotalQuantityLabel";
            this.TotalQuantityLabel.Size = new System.Drawing.Size(188, 24);
            this.TotalQuantityLabel.TabIndex = 27;
            this.TotalQuantityLabel.Text = "<number of items>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(609, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 56);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CartPanel
            // 
            this.CartPanel.AutoScroll = true;
            this.CartPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CartPanel.Location = new System.Drawing.Point(47, 167);
            this.CartPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(1181, 342);
            this.CartPanel.TabIndex = 23;
            // 
            // checkoutArrowBtn
            // 
            this.checkoutArrowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkoutArrowBtn.BackgroundImage = global::E_Pc.Properties.Resources.image_removebg_preview;
            this.checkoutArrowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkoutArrowBtn.Image = global::E_Pc.Properties.Resources.image_removebg_preview;
            this.checkoutArrowBtn.Location = new System.Drawing.Point(1155, 590);
            this.checkoutArrowBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutArrowBtn.Name = "checkoutArrowBtn";
            this.checkoutArrowBtn.Size = new System.Drawing.Size(64, 41);
            this.checkoutArrowBtn.TabIndex = 36;
            this.checkoutArrowBtn.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoRoundedCorners = true;
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderRadius = 35;
            this.BackBtn.BorderThickness = 2;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.FillColor = System.Drawing.Color.SteelBlue;
            this.BackBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(47, 574);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(272, 73);
            this.BackBtn.TabIndex = 40;
            this.BackBtn.Text = "      Go back to order page";
            this.BackBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TotalAmountLabel);
            this.panel1.Location = new System.Drawing.Point(839, 512);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 47);
            this.panel1.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Amount:";
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmountLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountLabel.ForeColor = System.Drawing.Color.White;
            this.TotalAmountLabel.Location = new System.Drawing.Point(185, 10);
            this.TotalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(177, 28);
            this.TotalAmountLabel.TabIndex = 13;
            this.TotalAmountLabel.Text = "<total amount>";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.BackgroundImage = global::E_Pc.Properties.Resources.image_removebg_preview__1_2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(52, 592);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::E_Pc.Properties.Resources.image_removebg_preview__2_;
            this.pictureBox3.Location = new System.Drawing.Point(44, 9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::E_Pc.Properties.Resources.image_removebg_preview__1_;
            this.pictureBox4.Location = new System.Drawing.Point(1233, 9);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.pictureBox3);
            this.guna2Panel1.Controls.Add(this.pictureBox4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1273, 41);
            this.guna2Panel1.TabIndex = 44;
            // 
            // CancelOrderBtn
            // 
            this.CancelOrderBtn.AutoRoundedCorners = true;
            this.CancelOrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelOrderBtn.BorderColor = System.Drawing.Color.Transparent;
            this.CancelOrderBtn.BorderRadius = 35;
            this.CancelOrderBtn.BorderThickness = 2;
            this.CancelOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelOrderBtn.FillColor = System.Drawing.Color.Red;
            this.CancelOrderBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.CancelOrderBtn.ForeColor = System.Drawing.Color.White;
            this.CancelOrderBtn.Location = new System.Drawing.Point(757, 574);
            this.CancelOrderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelOrderBtn.Name = "CancelOrderBtn";
            this.CancelOrderBtn.Size = new System.Drawing.Size(176, 73);
            this.CancelOrderBtn.TabIndex = 45;
            this.CancelOrderBtn.Text = "Cancel order";
            this.CancelOrderBtn.Click += new System.EventHandler(this.CancelOrderBtn_Click);
            // 
            // CashierShowCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Pc.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 672);
            this.Controls.Add(this.CancelOrderBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.checkoutArrowBtn);
            this.Controls.Add(this.CheckoutBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalQuantityLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CartPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CashierShowCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierShowCart";
            this.Load += new System.EventHandler(this.CashierShowCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkoutArrowBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button CheckoutBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel CartPanel;
        private System.Windows.Forms.PictureBox checkoutArrowBtn;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button CancelOrderBtn;
        public System.Windows.Forms.Label TotalQuantityLabel;
    }
}