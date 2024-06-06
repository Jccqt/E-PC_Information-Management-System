namespace E_Pc
{
    partial class EditEmployee
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
            this.SelectImage = new System.Windows.Forms.OpenFileDialog();
            this.SelectImageBtn = new System.Windows.Forms.Button();
            this.BirthdateBox = new System.Windows.Forms.TextBox();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PositionBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.EmpImage = new System.Windows.Forms.PictureBox();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectImage
            // 
            this.SelectImage.FileName = "openFileDialog1";
            this.SelectImage.Filter = "Image files | *.png; *.jpeg; *.jpg;";
            // 
            // SelectImageBtn
            // 
            this.SelectImageBtn.BackColor = System.Drawing.Color.White;
            this.SelectImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectImageBtn.Location = new System.Drawing.Point(180, 278);
            this.SelectImageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SelectImageBtn.Name = "SelectImageBtn";
            this.SelectImageBtn.Size = new System.Drawing.Size(149, 28);
            this.SelectImageBtn.TabIndex = 69;
            this.SelectImageBtn.Text = "Select Image";
            this.SelectImageBtn.UseVisualStyleBackColor = false;
            this.SelectImageBtn.Visible = false;
            this.SelectImageBtn.Click += new System.EventHandler(this.SelectImageBtn_Click);
            // 
            // BirthdateBox
            // 
            this.BirthdateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BirthdateBox.Enabled = false;
            this.BirthdateBox.Location = new System.Drawing.Point(204, 421);
            this.BirthdateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirthdateBox.Multiline = true;
            this.BirthdateBox.Name = "BirthdateBox";
            this.BirthdateBox.ReadOnly = true;
            this.BirthdateBox.Size = new System.Drawing.Size(129, 34);
            this.BirthdateBox.TabIndex = 68;
            // 
            // ContactBox
            // 
            this.ContactBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactBox.Enabled = false;
            this.ContactBox.Location = new System.Drawing.Point(28, 422);
            this.ContactBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactBox.Multiline = true;
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(162, 34);
            this.ContactBox.TabIndex = 67;
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
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(132, 34);
            this.CancelBtn.TabIndex = 66;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Visible = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
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
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(125, 34);
            this.SaveBtn.TabIndex = 65;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Enabled = false;
            this.AddressBox.Location = new System.Drawing.Point(28, 576);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(451, 80);
            this.AddressBox.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(27, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 63;
            this.label9.Text = "Address";
            // 
            // PositionBox
            // 
            this.PositionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PositionBox.Enabled = false;
            this.PositionBox.Location = new System.Drawing.Point(351, 421);
            this.PositionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PositionBox.Multiline = true;
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.ReadOnly = true;
            this.PositionBox.Size = new System.Drawing.Size(129, 34);
            this.PositionBox.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(352, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Position*";
            // 
            // UsernameBox
            // 
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameBox.Enabled = false;
            this.UsernameBox.Location = new System.Drawing.Point(28, 498);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameBox.Multiline = true;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(219, 34);
            this.UsernameBox.TabIndex = 59;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.ForeColor = System.Drawing.Color.Black;
            this.QuantityLabel.Location = new System.Drawing.Point(24, 480);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(75, 16);
            this.QuantityLabel.TabIndex = 58;
            this.QuantityLabel.Text = "Username*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(204, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Birthdate*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(200, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Last Name*";
            // 
            // LastNameBox
            // 
            this.LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameBox.Enabled = false;
            this.LastNameBox.Location = new System.Drawing.Point(204, 345);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameBox.Multiline = true;
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(129, 34);
            this.LastNameBox.TabIndex = 54;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameBox.Enabled = false;
            this.FirstNameBox.Location = new System.Drawing.Point(28, 345);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameBox.Multiline = true;
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(162, 34);
            this.FirstNameBox.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "First Name*";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.Black;
            this.IdLabel.Location = new System.Drawing.Point(181, 241);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(129, 33);
            this.IdLabel.TabIndex = 51;
            this.IdLabel.Text = "<EmpId>";
            // 
            // EmpImage
            // 
            this.EmpImage.BackColor = System.Drawing.Color.DarkGray;
            this.EmpImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpImage.Location = new System.Drawing.Point(139, 74);
            this.EmpImage.Margin = new System.Windows.Forms.Padding(4);
            this.EmpImage.Name = "EmpImage";
            this.EmpImage.Size = new System.Drawing.Size(222, 163);
            this.EmpImage.TabIndex = 50;
            this.EmpImage.TabStop = false;
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
            this.ActivityLabel.TabIndex = 49;
            this.ActivityLabel.Text = "<Activity>";
            this.ActivityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Contact Number*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(347, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Age*";
            // 
            // AgeBox
            // 
            this.AgeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeBox.Enabled = false;
            this.AgeBox.Location = new System.Drawing.Point(351, 345);
            this.AgeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgeBox.Multiline = true;
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.ReadOnly = true;
            this.AgeBox.Size = new System.Drawing.Size(129, 34);
            this.AgeBox.TabIndex = 70;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Location = new System.Drawing.Point(275, 498);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(205, 34);
            this.PasswordBox.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(271, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Password*";
            // 
            // EditBtn
            // 
            this.EditBtn.Image = global::E_Pc.Properties.Resources.image_removebg_preview__6_;
            this.EditBtn.Location = new System.Drawing.Point(449, 10);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(41, 38);
            this.EditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditBtn.TabIndex = 74;
            this.EditBtn.TabStop = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.SelectImageBtn);
            this.Controls.Add(this.BirthdateBox);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.EmpImage);
            this.Controls.Add(this.ActivityLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditEmployee";
            this.Size = new System.Drawing.Size(507, 748);
            this.Load += new System.EventHandler(this.EditEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog SelectImage;
        private System.Windows.Forms.Button SelectImageBtn;
        public System.Windows.Forms.TextBox BirthdateBox;
        public System.Windows.Forms.TextBox ContactBox;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        public System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox PositionBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox LastNameBox;
        public System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IdLabel;
        public System.Windows.Forms.PictureBox EmpImage;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox AgeBox;
        public System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox EditBtn;
    }
}
