namespace E_Pc
{
    partial class PaymentPage
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.ReturnBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PaymentBox = new System.Windows.Forms.TextBox();
            this.ExchangeBox = new System.Windows.Forms.TextBox();
            this.PrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CartPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalAmountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalQuantityLabel = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.ExitBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(960, 33);
            this.guna2Panel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::E_Pc.Properties.Resources.image_removebg_preview__2_;
            this.pictureBox2.Location = new System.Drawing.Point(33, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = global::E_Pc.Properties.Resources.image_removebg_preview__1_;
            this.ExitBtn.Location = new System.Drawing.Point(925, 7);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 21);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.TabStop = false;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReturnBtn.FillColor = System.Drawing.Color.Transparent;
            this.ReturnBtn.Image = global::E_Pc.Properties.Resources.Back_removebg_preview;
            this.ReturnBtn.ImageRotate = 0F;
            this.ReturnBtn.Location = new System.Drawing.Point(897, 44);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(38, 41);
            this.ReturnBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReturnBtn.TabIndex = 19;
            this.ReturnBtn.TabStop = false;
            this.ReturnBtn.UseTransparentBackground = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // PaymentBox
            // 
            this.PaymentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBox.Location = new System.Drawing.Point(664, 335);
            this.PaymentBox.Name = "PaymentBox";
            this.PaymentBox.Size = new System.Drawing.Size(262, 38);
            this.PaymentBox.TabIndex = 24;
            this.PaymentBox.TextChanged += new System.EventHandler(this.PaymentBox_TextChanged);
            // 
            // ExchangeBox
            // 
            this.ExchangeBox.Enabled = false;
            this.ExchangeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeBox.Location = new System.Drawing.Point(664, 418);
            this.ExchangeBox.Name = "ExchangeBox";
            this.ExchangeBox.Size = new System.Drawing.Size(262, 38);
            this.ExchangeBox.TabIndex = 27;
            // 
            // PrintBtn
            // 
            this.PrintBtn.AutoRoundedCorners = true;
            this.PrintBtn.BackColor = System.Drawing.Color.Transparent;
            this.PrintBtn.BorderRadius = 21;
            this.PrintBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintBtn.FillColor = System.Drawing.Color.White;
            this.PrintBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrintBtn.ForeColor = System.Drawing.Color.Green;
            this.PrintBtn.Location = new System.Drawing.Point(664, 511);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(124, 45);
            this.PrintBtn.TabIndex = 29;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button2.Location = new System.Drawing.Point(802, 511);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(124, 45);
            this.guna2Button2.TabIndex = 30;
            this.guna2Button2.Text = "Clear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(429, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 50);
            this.label2.TabIndex = 32;
            this.label2.Text = "Payment\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(659, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "Enter amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(659, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "Exchange";
            // 
            // CartPanel
            // 
            this.CartPanel.BackColor = System.Drawing.Color.White;
            this.CartPanel.Location = new System.Drawing.Point(42, 172);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(612, 393);
            this.CartPanel.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(659, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 30);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total amount";
            // 
            // TotalAmountBox
            // 
            this.TotalAmountBox.Enabled = false;
            this.TotalAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountBox.Location = new System.Drawing.Point(664, 209);
            this.TotalAmountBox.Name = "TotalAmountBox";
            this.TotalAmountBox.Size = new System.Drawing.Size(262, 38);
            this.TotalAmountBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Total items:";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CodeLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLabel.ForeColor = System.Drawing.Color.White;
            this.CodeLabel.Location = new System.Drawing.Point(146, 90);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(76, 23);
            this.CodeLabel.TabIndex = 41;
            this.CodeLabel.Text = "<code>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(38, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 40;
            this.label10.Text = "Cart code:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(147, 116);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(72, 23);
            this.DateLabel.TabIndex = 39;
            this.DateLabel.Text = "<date>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Date:";
            // 
            // TotalQuantityLabel
            // 
            this.TotalQuantityLabel.AutoSize = true;
            this.TotalQuantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalQuantityLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalQuantityLabel.ForeColor = System.Drawing.Color.White;
            this.TotalQuantityLabel.Location = new System.Drawing.Point(146, 139);
            this.TotalQuantityLabel.Name = "TotalQuantityLabel";
            this.TotalQuantityLabel.Size = new System.Drawing.Size(176, 23);
            this.TotalQuantityLabel.TabIndex = 37;
            this.TotalQuantityLabel.Text = "<number of items>";
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Pc.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalQuantityLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalAmountBox);
            this.Controls.Add(this.CartPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.ExchangeBox);
            this.Controls.Add(this.PaymentBox);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentPage";
            this.Load += new System.EventHandler(this.PaymentPage_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox ReturnBtn;
        private System.Windows.Forms.TextBox PaymentBox;
        private System.Windows.Forms.TextBox ExchangeBox;
        private Guna.UI2.WinForms.Guna2Button PrintBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel CartPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalAmountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalQuantityLabel;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.Label DateLabel;
    }
}