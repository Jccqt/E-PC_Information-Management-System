namespace Customer
{
    partial class Items
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
            this.ItemPrice = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemPrice
            // 
            this.ItemPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPrice.ForeColor = System.Drawing.Color.Black;
            this.ItemPrice.Location = new System.Drawing.Point(2, 164);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(130, 34);
            this.ItemPrice.TabIndex = 7;
            this.ItemPrice.Text = "Price price price price";
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.ForeColor = System.Drawing.Color.Black;
            this.ItemName.Location = new System.Drawing.Point(2, 131);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(134, 33);
            this.ItemName.TabIndex = 6;
            this.ItemName.Text = "Name name name name name";
            // 
            // ItemImage
            // 
            this.ItemImage.BackColor = System.Drawing.Color.Transparent;
            this.ItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemImage.Location = new System.Drawing.Point(-1, -2);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(136, 130);
            this.ItemImage.TabIndex = 5;
            this.ItemImage.TabStop = false;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ItemImage);
            this.Name = "Items";
            this.Size = new System.Drawing.Size(135, 198);
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label ItemPrice;
        public System.Windows.Forms.Label ItemName;
        public System.Windows.Forms.PictureBox ItemImage;
    }
}
