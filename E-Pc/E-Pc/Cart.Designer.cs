namespace E_Pc
{
    partial class Cart
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
            this.DateLabel = new System.Windows.Forms.Label();
            this.CartIdLabel = new System.Windows.Forms.Label();
            this.CartImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CartImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.Black;
            this.DateLabel.Location = new System.Drawing.Point(3, 164);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(129, 33);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "Date date date date";
            // 
            // CartIdLabel
            // 
            this.CartIdLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartIdLabel.ForeColor = System.Drawing.Color.Black;
            this.CartIdLabel.Location = new System.Drawing.Point(0, 131);
            this.CartIdLabel.Name = "CartIdLabel";
            this.CartIdLabel.Size = new System.Drawing.Size(134, 33);
            this.CartIdLabel.TabIndex = 10;
            this.CartIdLabel.Text = "Cart ID ID ID ID ID ID ID ID ID ID";
            // 
            // CartImage
            // 
            this.CartImage.BackColor = System.Drawing.Color.Transparent;
            this.CartImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CartImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartImage.Location = new System.Drawing.Point(0, 0);
            this.CartImage.Name = "CartImage";
            this.CartImage.Size = new System.Drawing.Size(135, 128);
            this.CartImage.TabIndex = 5;
            this.CartImage.TabStop = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CartIdLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CartImage);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(135, 197);
            ((System.ComponentModel.ISupportInitialize)(this.CartImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.Label CartIdLabel;
        public System.Windows.Forms.PictureBox CartImage;
    }
}
