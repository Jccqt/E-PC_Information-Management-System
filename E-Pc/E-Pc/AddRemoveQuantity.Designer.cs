namespace E_Pc
{
    partial class AddRemoveQuantity
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddDeleteHeader = new System.Windows.Forms.Label();
            this.AddDeleteLabel = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.Label();
            this.RemarksBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CurrentQuantityBox = new System.Windows.Forms.TextBox();
            this.QuantityToAddRemoveBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(26, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddDeleteHeader
            // 
            this.AddDeleteHeader.AutoSize = true;
            this.AddDeleteHeader.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDeleteHeader.Location = new System.Drawing.Point(228, 13);
            this.AddDeleteHeader.Name = "AddDeleteHeader";
            this.AddDeleteHeader.Size = new System.Drawing.Size(114, 27);
            this.AddDeleteHeader.TabIndex = 1;
            this.AddDeleteHeader.Text = "<Header>";
            // 
            // AddDeleteLabel
            // 
            this.AddDeleteLabel.AutoSize = true;
            this.AddDeleteLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDeleteLabel.Location = new System.Drawing.Point(250, 172);
            this.AddDeleteLabel.Name = "AddDeleteLabel";
            this.AddDeleteLabel.Size = new System.Drawing.Size(70, 16);
            this.AddDeleteLabel.TabIndex = 4;
            this.AddDeleteLabel.Text = "<Label 1>";
            // 
            // Remarks
            // 
            this.Remarks.AutoSize = true;
            this.Remarks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remarks.Location = new System.Drawing.Point(23, 296);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(71, 16);
            this.Remarks.TabIndex = 5;
            this.Remarks.Text = "Remarks *";
            // 
            // RemarksBox
            // 
            this.RemarksBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemarksBox.Location = new System.Drawing.Point(26, 315);
            this.RemarksBox.Multiline = true;
            this.RemarksBox.Name = "RemarksBox";
            this.RemarksBox.Size = new System.Drawing.Size(511, 115);
            this.RemarksBox.TabIndex = 6;
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoRoundedCorners = true;
            this.CancelBtn.BorderRadius = 13;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(429, 472);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(99, 28);
            this.CancelBtn.TabIndex = 47;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoRoundedCorners = true;
            this.SaveBtn.BorderRadius = 13;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(329, 472);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(94, 28);
            this.SaveBtn.TabIndex = 46;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CurrentQuantityBox
            // 
            this.CurrentQuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentQuantityBox.Enabled = false;
            this.CurrentQuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentQuantityBox.Location = new System.Drawing.Point(253, 115);
            this.CurrentQuantityBox.Name = "CurrentQuantityBox";
            this.CurrentQuantityBox.ReadOnly = true;
            this.CurrentQuantityBox.Size = new System.Drawing.Size(180, 31);
            this.CurrentQuantityBox.TabIndex = 48;
            // 
            // QuantityToAddRemoveBox
            // 
            this.QuantityToAddRemoveBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityToAddRemoveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityToAddRemoveBox.Location = new System.Drawing.Point(253, 191);
            this.QuantityToAddRemoveBox.Name = "QuantityToAddRemoveBox";
            this.QuantityToAddRemoveBox.Size = new System.Drawing.Size(180, 31);
            this.QuantityToAddRemoveBox.TabIndex = 49;
            this.QuantityToAddRemoveBox.TextChanged += new System.EventHandler(this.QuantityToAddRemoveBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Current quantity";
            // 
            // AddRemoveQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantityToAddRemoveBox);
            this.Controls.Add(this.CurrentQuantityBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.RemarksBox);
            this.Controls.Add(this.Remarks);
            this.Controls.Add(this.AddDeleteLabel);
            this.Controls.Add(this.AddDeleteHeader);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddRemoveQuantity";
            this.Size = new System.Drawing.Size(566, 526);
            this.Load += new System.EventHandler(this.AddRemoveQuantity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Remarks;
        private System.Windows.Forms.TextBox RemarksBox;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private System.Windows.Forms.TextBox CurrentQuantityBox;
        private System.Windows.Forms.TextBox QuantityToAddRemoveBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label AddDeleteHeader;
        public System.Windows.Forms.Label AddDeleteLabel;
    }
}
