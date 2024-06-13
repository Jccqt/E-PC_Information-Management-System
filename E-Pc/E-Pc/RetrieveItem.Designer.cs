namespace E_Pc
{
    partial class RetrieveItem
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
            this.ItemQuantity = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RetrieveBtn = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.DeletionDateLabel = new System.Windows.Forms.Label();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantity.ForeColor = System.Drawing.Color.Black;
            this.ItemQuantity.Location = new System.Drawing.Point(521, 58);
            this.ItemQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(128, 18);
            this.ItemQuantity.TabIndex = 6;
            this.ItemQuantity.Text = "Item Quantity:";
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(267, 5);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(575, 34);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(281, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item ID:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(281, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Type:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(521, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Deletion Date:";
            // 
            // RetrieveBtn
            // 
            this.RetrieveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RetrieveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RetrieveBtn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrieveBtn.ForeColor = System.Drawing.Color.White;
            this.RetrieveBtn.Location = new System.Drawing.Point(724, 144);
            this.RetrieveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RetrieveBtn.Name = "RetrieveBtn";
            this.RetrieveBtn.Size = new System.Drawing.Size(168, 37);
            this.RetrieveBtn.TabIndex = 10;
            this.RetrieveBtn.Text = "Retrieve";
            this.RetrieveBtn.UseVisualStyleBackColor = false;
            this.RetrieveBtn.Click += new System.EventHandler(this.RetrieveBtn_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.Black;
            this.IdLabel.Location = new System.Drawing.Point(348, 58);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(100, 18);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "<id>";
            // 
            // TypeLabel
            // 
            this.TypeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.Color.Black;
            this.TypeLabel.Location = new System.Drawing.Point(372, 96);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(100, 18);
            this.TypeLabel.TabIndex = 12;
            this.TypeLabel.Text = "<type>";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.ForeColor = System.Drawing.Color.Black;
            this.QuantityLabel.Location = new System.Drawing.Point(639, 58);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(100, 18);
            this.QuantityLabel.TabIndex = 13;
            this.QuantityLabel.Text = "<quantity>";
            // 
            // DeletionDateLabel
            // 
            this.DeletionDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletionDateLabel.ForeColor = System.Drawing.Color.Black;
            this.DeletionDateLabel.Location = new System.Drawing.Point(639, 96);
            this.DeletionDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeletionDateLabel.Name = "DeletionDateLabel";
            this.DeletionDateLabel.Size = new System.Drawing.Size(100, 18);
            this.DeletionDateLabel.TabIndex = 14;
            this.DeletionDateLabel.Text = "<date>";
            // 
            // ItemImage
            // 
            this.ItemImage.BackColor = System.Drawing.Color.DarkGray;
            this.ItemImage.Location = new System.Drawing.Point(0, 0);
            this.ItemImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(257, 185);
            this.ItemImage.TabIndex = 4;
            this.ItemImage.TabStop = false;
            // 
            // QuantityBox
            // 
            this.QuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityBox.Location = new System.Drawing.Point(500, 144);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(182, 34);
            this.QuantityBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(259, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Retrieve Quantity:";
            // 
            // RetrieveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.DeletionDateLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.RetrieveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemQuantity);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ItemImage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RetrieveItem";
            this.Size = new System.Drawing.Size(893, 182);
            this.Load += new System.EventHandler(this.RetrieveItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label ItemQuantity;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.PictureBox ItemImage;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RetrieveBtn;
        public System.Windows.Forms.Label IdLabel;
        public System.Windows.Forms.Label TypeLabel;
        public System.Windows.Forms.Label QuantityLabel;
        public System.Windows.Forms.Label DeletionDateLabel;
        private System.Windows.Forms.TextBox QuantityBox;
        public System.Windows.Forms.Label label4;
    }
}
