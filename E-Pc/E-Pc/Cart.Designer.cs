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
            this.OutOfStockPic = new System.Windows.Forms.PictureBox();
            this.DeleteBtn = new System.Windows.Forms.PictureBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OutOfStockPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OutOfStockPic
            // 
            this.OutOfStockPic.BackColor = System.Drawing.Color.Transparent;
            this.OutOfStockPic.BackgroundImage = global::E_Pc.Properties.Resources.image_removebg_preview__1_1;
            this.OutOfStockPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OutOfStockPic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutOfStockPic.Location = new System.Drawing.Point(3, 25);
            this.OutOfStockPic.Name = "OutOfStockPic";
            this.OutOfStockPic.Size = new System.Drawing.Size(129, 75);
            this.OutOfStockPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OutOfStockPic.TabIndex = 8;
            this.OutOfStockPic.TabStop = false;
            this.OutOfStockPic.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.BackgroundImage = global::E_Pc.Properties.Resources.image_Photoroom;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.Location = new System.Drawing.Point(113, 1);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(18, 16);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.TabStop = false;
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.ForeColor = System.Drawing.Color.Black;
            this.ItemName.Location = new System.Drawing.Point(1, 168);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date date date date";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "<Code> <Code> <Code> <Code>";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutOfStockPic);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ItemImage);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(135, 238);
            ((System.ComponentModel.ISupportInitialize)(this.OutOfStockPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox OutOfStockPic;
        public System.Windows.Forms.PictureBox DeleteBtn;
        public System.Windows.Forms.Label ItemName;
        public System.Windows.Forms.PictureBox ItemImage;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}
