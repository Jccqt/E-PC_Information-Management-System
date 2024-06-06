namespace E_Pc
{
    partial class AddEmployee
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectImageBtn = new System.Windows.Forms.Button();
            this.EmpImage = new System.Windows.Forms.PictureBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PositionBox = new System.Windows.Forms.ComboBox();
            this.SelectImage = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.PositionBox);
            this.panel2.Controls.Add(this.BirthDatePicker);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.SelectImageBtn);
            this.panel2.Controls.Add(this.EmpImage);
            this.panel2.Controls.Add(this.PasswordBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.UsernameBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ContactBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.AddressBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ClearBtn);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Controls.Add(this.AgeBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.QuantityLabel);
            this.panel2.Controls.Add(this.LastNameBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FirstNameBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 447);
            this.panel2.TabIndex = 30;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(328, 181);
            this.BirthDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(263, 22);
            this.BirthDatePicker.TabIndex = 45;
            this.BirthDatePicker.ValueChanged += new System.EventHandler(this.BirthDatePicker_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(416, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 42);
            this.label8.TabIndex = 44;
            this.label8.Text = "Add Employee";
            // 
            // SelectImageBtn
            // 
            this.SelectImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectImageBtn.Location = new System.Drawing.Point(947, 309);
            this.SelectImageBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectImageBtn.Name = "SelectImageBtn";
            this.SelectImageBtn.Size = new System.Drawing.Size(137, 25);
            this.SelectImageBtn.TabIndex = 36;
            this.SelectImageBtn.Text = "Select Image";
            this.SelectImageBtn.UseVisualStyleBackColor = true;
            this.SelectImageBtn.Click += new System.EventHandler(this.SelectImageBtn_Click);
            // 
            // EmpImage
            // 
            this.EmpImage.BackColor = System.Drawing.Color.Gray;
            this.EmpImage.Location = new System.Drawing.Point(881, 106);
            this.EmpImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpImage.Name = "EmpImage";
            this.EmpImage.Size = new System.Drawing.Size(253, 191);
            this.EmpImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmpImage.TabIndex = 35;
            this.EmpImage.TabStop = false;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Location = new System.Drawing.Point(623, 236);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(227, 34);
            this.PasswordBox.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(619, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Password*";
            // 
            // UsernameBox
            // 
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameBox.Location = new System.Drawing.Point(621, 171);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameBox.Multiline = true;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(227, 34);
            this.UsernameBox.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(619, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Username*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(327, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Position*";
            // 
            // ContactBox
            // 
            this.ContactBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactBox.Location = new System.Drawing.Point(329, 106);
            this.ContactBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactBox.Multiline = true;
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(227, 34);
            this.ContactBox.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(327, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Contact number*";
            // 
            // AddressBox
            // 
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Location = new System.Drawing.Point(328, 299);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(522, 50);
            this.AddressBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(324, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address* (250 max characters)";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Animated = true;
            this.ClearBtn.AutoRoundedCorners = true;
            this.ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn.BorderRadius = 19;
            this.ClearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearBtn.FillColor = System.Drawing.Color.Red;
            this.ClearBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(143, 305);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(116, 41);
            this.ClearBtn.TabIndex = 24;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Animated = true;
            this.AddBtn.AutoRoundedCorners = true;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BorderRadius = 19;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(21, 305);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(116, 41);
            this.AddBtn.TabIndex = 23;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AgeBox
            // 
            this.AgeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeBox.Enabled = false;
            this.AgeBox.Location = new System.Drawing.Point(623, 106);
            this.AgeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgeBox.Multiline = true;
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.ReadOnly = true;
            this.AgeBox.Size = new System.Drawing.Size(227, 34);
            this.AgeBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(620, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Age*";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.ForeColor = System.Drawing.Color.Black;
            this.QuantityLabel.Location = new System.Drawing.Point(327, 150);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(65, 16);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Birthdate*";
            // 
            // LastNameBox
            // 
            this.LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameBox.Location = new System.Drawing.Point(31, 172);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameBox.Multiline = true;
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(227, 34);
            this.LastNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name*";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameBox.Location = new System.Drawing.Point(31, 106);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameBox.Multiline = true;
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(227, 34);
            this.FirstNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name*";
            // 
            // PositionBox
            // 
            this.PositionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionBox.FormattingEnabled = true;
            this.PositionBox.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.PositionBox.Location = new System.Drawing.Point(329, 238);
            this.PositionBox.Margin = new System.Windows.Forms.Padding(4);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(227, 32);
            this.PositionBox.TabIndex = 46;
            // 
            // SelectImage
            // 
            this.SelectImage.FileName = "openFileDialog1";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(1165, 482);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectImageBtn;
        private System.Windows.Forms.PictureBox EmpImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        public System.Windows.Forms.ComboBox PositionBox;
        private System.Windows.Forms.OpenFileDialog SelectImage;
    }
}
