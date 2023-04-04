namespace OptimumTech.Controls
{
    partial class Product
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
            pictureBoxProduct = new PictureBox();
            pictureBoxCart = new PictureBox();
            pictureBoxRating = new PictureBox();
            textBoxProductName = new TextBox();
            pictureBoxFavorite = new PictureBox();
            panelProduct = new Panel();
            textBoxResponses = new TextBox();
            textBoxAvailable = new TextBox();
            textBoxPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavorite).BeginInit();
            panelProduct.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.Dock = DockStyle.Top;
            pictureBoxProduct.Location = new Point(7, 7);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(231, 202);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxProduct.TabIndex = 0;
            pictureBoxProduct.TabStop = false;
            // 
            // pictureBoxCart
            // 
            pictureBoxCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxCart.Location = new Point(200, 298);
            pictureBoxCart.Name = "pictureBoxCart";
            pictureBoxCart.Size = new Size(38, 38);
            pictureBoxCart.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxCart.TabIndex = 3;
            pictureBoxCart.TabStop = false;
            // 
            // pictureBoxRating
            // 
            pictureBoxRating.ErrorImage = null;
            pictureBoxRating.Location = new Point(7, 247);
            pictureBoxRating.Name = "pictureBoxRating";
            pictureBoxRating.Size = new Size(85, 17);
            pictureBoxRating.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxRating.TabIndex = 4;
            pictureBoxRating.TabStop = false;
            // 
            // textBoxProductName
            // 
            textBoxProductName.BackColor = Color.White;
            textBoxProductName.BorderStyle = BorderStyle.None;
            textBoxProductName.Font = new Font("Poppins", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductName.Location = new Point(7, 215);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.ReadOnly = true;
            textBoxProductName.Size = new Size(229, 26);
            textBoxProductName.TabIndex = 5;
            textBoxProductName.Text = "Product name";
            // 
            // pictureBoxFavorite
            // 
            pictureBoxFavorite.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxFavorite.Location = new Point(200, 10);
            pictureBoxFavorite.Name = "pictureBoxFavorite";
            pictureBoxFavorite.Size = new Size(35, 35);
            pictureBoxFavorite.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFavorite.TabIndex = 6;
            pictureBoxFavorite.TabStop = false;
            // 
            // panelProduct
            // 
            panelProduct.Controls.Add(textBoxResponses);
            panelProduct.Controls.Add(textBoxAvailable);
            panelProduct.Controls.Add(textBoxPrice);
            panelProduct.Controls.Add(pictureBoxRating);
            panelProduct.Controls.Add(pictureBoxFavorite);
            panelProduct.Controls.Add(pictureBoxProduct);
            panelProduct.Controls.Add(textBoxProductName);
            panelProduct.Controls.Add(pictureBoxCart);
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(0, 0);
            panelProduct.Name = "panelProduct";
            panelProduct.Padding = new Padding(7);
            panelProduct.Size = new Size(245, 350);
            panelProduct.TabIndex = 7;
            // 
            // textBoxResponses
            // 
            textBoxResponses.BackColor = Color.White;
            textBoxResponses.BorderStyle = BorderStyle.None;
            textBoxResponses.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResponses.ForeColor = Color.FromArgb(43, 43, 43);
            textBoxResponses.Location = new Point(98, 247);
            textBoxResponses.Name = "textBoxResponses";
            textBoxResponses.Size = new Size(135, 18);
            textBoxResponses.TabIndex = 10;
            textBoxResponses.Text = "Responses";
            // 
            // textBoxAvailable
            // 
            textBoxAvailable.BackColor = Color.White;
            textBoxAvailable.BorderStyle = BorderStyle.None;
            textBoxAvailable.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAvailable.ForeColor = Color.FromArgb(0, 160, 70);
            textBoxAvailable.Location = new Point(7, 270);
            textBoxAvailable.Name = "textBoxAvailable";
            textBoxAvailable.Size = new Size(85, 18);
            textBoxAvailable.TabIndex = 9;
            textBoxAvailable.Text = "Available";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.White;
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("Poppins", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(7, 298);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(187, 38);
            textBoxPrice.TabIndex = 8;
            textBoxPrice.Text = "000.00$";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelProduct);
            Margin = new Padding(5);
            Name = "Product";
            Size = new Size(245, 350);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavorite).EndInit();
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxProduct;
        private PictureBox pictureBoxCart;
        private PictureBox pictureBoxRating;
        private TextBox textBoxProductName;
        private PictureBox pictureBoxFavorite;
        private Panel panelProduct;
        private TextBox textBoxPrice;
        private TextBox textBoxResponses;
        private TextBox textBoxAvailable;
    }
}
