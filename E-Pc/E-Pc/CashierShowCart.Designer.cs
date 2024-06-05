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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.AutoRoundedCorners = true;
            this.CheckoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckoutBtn.BorderRadius = 28;
            this.CheckoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckoutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CheckoutBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.CheckoutBtn.ForeColor = System.Drawing.Color.White;
            this.CheckoutBtn.Location = new System.Drawing.Point(707, 475);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(204, 59);
            this.CheckoutBtn.TabIndex = 35;
            this.CheckoutBtn.Text = "Proceed to checkout";
            this.CheckoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total items:";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CodeLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLabel.ForeColor = System.Drawing.Color.White;
            this.CodeLabel.Location = new System.Drawing.Point(133, 20);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(76, 23);
            this.CodeLabel.TabIndex = 33;
            this.CodeLabel.Text = "<code>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Cart code:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(133, 43);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(88, 23);
            this.StatusLabel.TabIndex = 31;
            this.StatusLabel.Text = "<status>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Status:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(133, 66);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(72, 23);
            this.DateLabel.TabIndex = 29;
            this.DateLabel.Text = "<date>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date:";
            // 
            // TotalQuantityLabel
            // 
            this.TotalQuantityLabel.AutoSize = true;
            this.TotalQuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalQuantityLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalQuantityLabel.ForeColor = System.Drawing.Color.White;
            this.TotalQuantityLabel.Location = new System.Drawing.Point(133, 88);
            this.TotalQuantityLabel.Name = "TotalQuantityLabel";
            this.TotalQuantityLabel.Size = new System.Drawing.Size(176, 23);
            this.TotalQuantityLabel.TabIndex = 27;
            this.TotalQuantityLabel.Text = "<number of items>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(449, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 45);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CartPanel
            // 
            this.CartPanel.AutoScroll = true;
            this.CartPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CartPanel.Location = new System.Drawing.Point(25, 113);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(886, 321);
            this.CartPanel.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImage = global::E_Pc.Properties.Resources.image_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::E_Pc.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(856, 488);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 33);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoRoundedCorners = true;
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderRadius = 28;
            this.BackBtn.BorderThickness = 2;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.FillColor = System.Drawing.Color.Tomato;
            this.BackBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(25, 475);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(204, 59);
            this.BackBtn.TabIndex = 40;
            this.BackBtn.Text = "Go back to order page";
            this.BackBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TotalAmountLabel);
            this.panel1.Location = new System.Drawing.Point(619, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 38);
            this.panel1.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Amount:";
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmountLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountLabel.ForeColor = System.Drawing.Color.White;
            this.TotalAmountLabel.Location = new System.Drawing.Point(139, 8);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(145, 23);
            this.TotalAmountLabel.TabIndex = 13;
            this.TotalAmountLabel.Text = "<total amount>";
            // 
            // CashierShowCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Pc.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "CashierShowCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierShowCart";
            this.Load += new System.EventHandler(this.CashierShowCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label TotalQuantityLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel CartPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalAmountLabel;
    }
}