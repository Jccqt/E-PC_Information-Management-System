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
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.DeleteBtn = new System.Windows.Forms.PictureBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemImage
            // 
            this.ItemImage.BackColor = System.Drawing.Color.Transparent;
            this.ItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemImage.Location = new System.Drawing.Point(0, 0);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(131, 130);
            this.ItemImage.TabIndex = 1;
            this.ItemImage.TabStop = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.BackgroundImage = global::E_Pc.Properties.Resources.image_Photoroom;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.Location = new System.Drawing.Point(110, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(18, 16);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.TabStop = false;
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.ForeColor = System.Drawing.Color.Black;
            this.ItemName.Location = new System.Drawing.Point(4, 134);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(127, 33);
            this.ItemName.TabIndex = 3;
            this.ItemName.Text = "Name name name name name";
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantity.ForeColor = System.Drawing.Color.Black;
            this.ItemQuantity.Location = new System.Drawing.Point(4, 166);
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(134, 36);
            this.ItemQuantity.TabIndex = 4;
            this.ItemQuantity.Text = "Position position position position";
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ItemQuantity);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ItemImage);
            this.Name = "ShowEmployee";
            this.Size = new System.Drawing.Size(131, 198);
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox ItemImage;
        public System.Windows.Forms.PictureBox DeleteBtn;
        public System.Windows.Forms.Label ItemName;
        public System.Windows.Forms.Label ItemQuantity;
    }
}
