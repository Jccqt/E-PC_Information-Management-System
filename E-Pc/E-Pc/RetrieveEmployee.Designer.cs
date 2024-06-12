namespace E_Pc
{
    partial class RetrieveEmployee
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
            this.ContactLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.RetrieveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemQuantity = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmpImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactLabel
            // 
            this.ContactLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.ForeColor = System.Drawing.Color.Black;
            this.ContactLabel.Location = new System.Drawing.Point(516, 47);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(75, 15);
            this.ContactLabel.TabIndex = 24;
            this.ContactLabel.Text = "<contact>";
            // 
            // PositionLabel
            // 
            this.PositionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.ForeColor = System.Drawing.Color.Black;
            this.PositionLabel.Location = new System.Drawing.Point(279, 78);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(75, 15);
            this.PositionLabel.TabIndex = 23;
            this.PositionLabel.Text = "<position>";
            // 
            // IdLabel
            // 
            this.IdLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.Black;
            this.IdLabel.Location = new System.Drawing.Point(310, 47);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(75, 15);
            this.IdLabel.TabIndex = 22;
            this.IdLabel.Text = "<id>";
            // 
            // RetrieveBtn
            // 
            this.RetrieveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RetrieveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RetrieveBtn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrieveBtn.ForeColor = System.Drawing.Color.White;
            this.RetrieveBtn.Location = new System.Drawing.Point(543, 117);
            this.RetrieveBtn.Name = "RetrieveBtn";
            this.RetrieveBtn.Size = new System.Drawing.Size(126, 30);
            this.RetrieveBtn.TabIndex = 21;
            this.RetrieveBtn.Text = "Retrieve";
            this.RetrieveBtn.UseVisualStyleBackColor = false;
            this.RetrieveBtn.Click += new System.EventHandler(this.RetrieveBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(211, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Position:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(211, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Employee ID:";
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantity.ForeColor = System.Drawing.Color.Black;
            this.ItemQuantity.Location = new System.Drawing.Point(428, 47);
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(96, 15);
            this.ItemQuantity.TabIndex = 17;
            this.ItemQuantity.Text = "Contact #:";
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(200, 4);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(431, 28);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Employee Name";
            // 
            // EmpImage
            // 
            this.EmpImage.BackColor = System.Drawing.Color.DarkGray;
            this.EmpImage.Location = new System.Drawing.Point(0, 0);
            this.EmpImage.Name = "EmpImage";
            this.EmpImage.Size = new System.Drawing.Size(193, 150);
            this.EmpImage.TabIndex = 15;
            this.EmpImage.TabStop = false;
            // 
            // RetrieveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.RetrieveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemQuantity);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmpImage);
            this.Name = "RetrieveEmployee";
            this.Size = new System.Drawing.Size(670, 148);
            this.Load += new System.EventHandler(this.RetrieveEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label ContactLabel;
        public System.Windows.Forms.Label PositionLabel;
        public System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button RetrieveBtn;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label ItemQuantity;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.PictureBox EmpImage;
    }
}
