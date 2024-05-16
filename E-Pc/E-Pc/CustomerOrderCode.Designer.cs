namespace E_Pc
{
    partial class CustomerOrderCode
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CodeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.VerifyButton = new Guna.UI2.WinForms.Guna2Button();
            this.VerifiedLogo = new System.Windows.Forms.PictureBox();
            this.ContinueButton = new Guna.UI2.WinForms.Guna2Button();
            this.VerifyPopup = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerifiedLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::E_Pc.Properties.Resources.Unique_code_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(249, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(960, 33);
            this.guna2Panel1.TabIndex = 3;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.AutoRoundedCorners = true;
            this.CodeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CodeTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.CodeTextBox.BorderRadius = 30;
            this.CodeTextBox.BorderThickness = 0;
            this.CodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeTextBox.DefaultText = "Enter Code";
            this.CodeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CodeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CodeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CodeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CodeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CodeTextBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.CodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CodeTextBox.Location = new System.Drawing.Point(299, 265);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.PasswordChar = '\0';
            this.CodeTextBox.PlaceholderText = "";
            this.CodeTextBox.SelectedText = "";
            this.CodeTextBox.Size = new System.Drawing.Size(361, 62);
            this.CodeTextBox.TabIndex = 4;
            this.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodeTextBox.TextChanged += new System.EventHandler(this.CodeTextBox_TextChanged);
            // 
            // VerifyButton
            // 
            this.VerifyButton.Animated = true;
            this.VerifyButton.AutoRoundedCorners = true;
            this.VerifyButton.BackColor = System.Drawing.Color.Transparent;
            this.VerifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerifyButton.BorderRadius = 36;
            this.VerifyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.VerifyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.VerifyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VerifyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.VerifyButton.FillColor = System.Drawing.Color.White;
            this.VerifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.VerifyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(74)))), ((int)(((byte)(125)))));
            this.VerifyButton.Image = global::E_Pc.Properties.Resources.VERIFY_CODE;
            this.VerifyButton.ImageSize = new System.Drawing.Size(120, 10);
            this.VerifyButton.Location = new System.Drawing.Point(391, 354);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(180, 74);
            this.VerifyButton.TabIndex = 12;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // VerifiedLogo
            // 
            this.VerifiedLogo.BackColor = System.Drawing.Color.White;
            this.VerifiedLogo.Image = global::E_Pc.Properties.Resources.Verification;
            this.VerifiedLogo.Location = new System.Drawing.Point(419, 254);
            this.VerifiedLogo.Name = "VerifiedLogo";
            this.VerifiedLogo.Size = new System.Drawing.Size(124, 73);
            this.VerifiedLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VerifiedLogo.TabIndex = 14;
            this.VerifiedLogo.TabStop = false;
            this.VerifiedLogo.Visible = false;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Animated = true;
            this.ContinueButton.AutoRoundedCorners = true;
            this.ContinueButton.BackColor = System.Drawing.Color.White;
            this.ContinueButton.BorderColor = System.Drawing.Color.Transparent;
            this.ContinueButton.BorderRadius = 10;
            this.ContinueButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ContinueButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ContinueButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ContinueButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ContinueButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(11)))), ((int)(((byte)(33)))));
            this.ContinueButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ContinueButton.ForeColor = System.Drawing.Color.Transparent;
            this.ContinueButton.Image = global::E_Pc.Properties.Resources.Continue_removebg_preview;
            this.ContinueButton.ImageSize = new System.Drawing.Size(100, 20);
            this.ContinueButton.Location = new System.Drawing.Point(391, 407);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(180, 65);
            this.ContinueButton.TabIndex = 15;
            this.ContinueButton.Visible = false;
            // 
            // VerifyPopup
            // 
            this.VerifyPopup.AutoRoundedCorners = true;
            this.VerifyPopup.BackColor = System.Drawing.Color.Transparent;
            this.VerifyPopup.BorderColor = System.Drawing.Color.Transparent;
            this.VerifyPopup.BorderRadius = 178;
            this.VerifyPopup.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.VerifyPopup.BorderThickness = 0;
            this.VerifyPopup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VerifyPopup.DefaultText = "Code Verified!";
            this.VerifyPopup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VerifyPopup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VerifyPopup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VerifyPopup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VerifyPopup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VerifyPopup.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.VerifyPopup.ForeColor = System.Drawing.Color.Black;
            this.VerifyPopup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VerifyPopup.Location = new System.Drawing.Point(135, 177);
            this.VerifyPopup.Margin = new System.Windows.Forms.Padding(7);
            this.VerifyPopup.Name = "VerifyPopup";
            this.VerifyPopup.PasswordChar = '\0';
            this.VerifyPopup.PlaceholderForeColor = System.Drawing.Color.White;
            this.VerifyPopup.PlaceholderText = "";
            this.VerifyPopup.SelectedText = "";
            this.VerifyPopup.Size = new System.Drawing.Size(677, 358);
            this.VerifyPopup.TabIndex = 13;
            this.VerifyPopup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VerifyPopup.Visible = false;
            // 
            // CustomerOrderCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Pc.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.VerifiedLogo);
            this.Controls.Add(this.VerifyPopup);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrderCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOrderCode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerifiedLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox CodeTextBox;
        private Guna.UI2.WinForms.Guna2Button VerifyButton;
        private System.Windows.Forms.PictureBox VerifiedLogo;
        private Guna.UI2.WinForms.Guna2Button ContinueButton;
        private Guna.UI2.WinForms.Guna2TextBox VerifyPopup;
    }
}