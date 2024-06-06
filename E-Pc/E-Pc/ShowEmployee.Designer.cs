namespace E_Pc
{
    partial class ShowEmployee
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.PictureBox();
            this.EmpImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpImage)).BeginInit();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.Black;
            this.IdLabel.Location = new System.Drawing.Point(5, 165);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(163, 26);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "empid empid empid empid";
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(4, 191);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(163, 50);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name name name name name name";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.BackgroundImage = global::E_Pc.Properties.Resources.image_Photoroom;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Location = new System.Drawing.Point(147, 4);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(24, 20);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.TabStop = false;
            // 
            // EmpImage
            // 
            this.EmpImage.BackColor = System.Drawing.Color.Transparent;
            this.EmpImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpImage.Location = new System.Drawing.Point(0, 0);
            this.EmpImage.Margin = new System.Windows.Forms.Padding(4);
            this.EmpImage.Name = "EmpImage";
            this.EmpImage.Size = new System.Drawing.Size(174, 160);
            this.EmpImage.TabIndex = 1;
            this.EmpImage.TabStop = false;
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EmpImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowEmployee";
            this.Size = new System.Drawing.Size(172, 241);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox EmpImage;
        public System.Windows.Forms.PictureBox DeleteBtn;
        public System.Windows.Forms.Label IdLabel;
        public System.Windows.Forms.Label NameLabel;
    }
}
