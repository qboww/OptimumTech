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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            pictureBoxProduct = new PictureBox();
            labelProductResponses = new Label();
            labelProductPrice = new Label();
            pictureBoxCart = new PictureBox();
            pictureBoxRating = new PictureBox();
            textBoxProductName = new TextBox();
            pictureBoxFavorite = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavorite).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.Dock = DockStyle.Top;
            pictureBoxProduct.Image = (Image)resources.GetObject("pictureBoxProduct.Image");
            pictureBoxProduct.Location = new Point(0, 0);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(278, 236);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxProduct.TabIndex = 0;
            pictureBoxProduct.TabStop = false;
            // 
            // labelProductResponses
            // 
            labelProductResponses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelProductResponses.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductResponses.ForeColor = Color.FromArgb(64, 64, 64);
            labelProductResponses.Location = new Point(111, 280);
            labelProductResponses.Name = "labelProductResponses";
            labelProductResponses.Size = new Size(164, 20);
            labelProductResponses.TabIndex = 1;
            labelProductResponses.Text = "43 Responses";
            labelProductResponses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelProductPrice
            // 
            labelProductPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelProductPrice.Font = new Font("Poppins", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductPrice.Location = new Point(5, 318);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(224, 40);
            labelProductPrice.TabIndex = 2;
            labelProductPrice.Text = "$592.99";
            labelProductPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxCart
            // 
            pictureBoxCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxCart.Image = (Image)resources.GetObject("pictureBoxCart.Image");
            pictureBoxCart.Location = new Point(235, 318);
            pictureBoxCart.Name = "pictureBoxCart";
            pictureBoxCart.Size = new Size(40, 40);
            pictureBoxCart.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxCart.TabIndex = 3;
            pictureBoxCart.TabStop = false;
            // 
            // pictureBoxRating
            // 
            pictureBoxRating.ErrorImage = null;
            pictureBoxRating.Image = Optimum_Tech.Properties.Resources.four_stars;
            pictureBoxRating.Location = new Point(5, 280);
            pictureBoxRating.Name = "pictureBoxRating";
            pictureBoxRating.Size = new Size(100, 20);
            pictureBoxRating.TabIndex = 4;
            pictureBoxRating.TabStop = false;
            // 
            // textBoxProductName
            // 
            textBoxProductName.BackColor = Color.White;
            textBoxProductName.BorderStyle = BorderStyle.None;
            textBoxProductName.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductName.Location = new Point(5, 242);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.ReadOnly = true;
            textBoxProductName.Size = new Size(270, 32);
            textBoxProductName.TabIndex = 5;
            textBoxProductName.Text = "Intel Core i9-13900K";
            // 
            // pictureBoxFavorite
            // 
            pictureBoxFavorite.Image = (Image)resources.GetObject("pictureBoxFavorite.Image");
            pictureBoxFavorite.Location = new Point(235, 3);
            pictureBoxFavorite.Name = "pictureBoxFavorite";
            pictureBoxFavorite.Size = new Size(40, 40);
            pictureBoxFavorite.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFavorite.TabIndex = 6;
            pictureBoxFavorite.TabStop = false;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBoxFavorite);
            Controls.Add(textBoxProductName);
            Controls.Add(pictureBoxRating);
            Controls.Add(pictureBoxCart);
            Controls.Add(labelProductPrice);
            Controls.Add(labelProductResponses);
            Controls.Add(pictureBoxProduct);
            Name = "Product";
            Size = new Size(278, 368);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFavorite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxProduct;
        private Label labelProductResponses;
        private Label labelProductPrice;
        private PictureBox pictureBoxCart;
        private PictureBox pictureBoxRating;
        private TextBox textBoxProductName;
        private PictureBox pictureBoxFavorite;
    }
}
