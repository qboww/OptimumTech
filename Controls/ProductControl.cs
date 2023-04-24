using Optimum_Tech.Forms;
using Optimum_Tech.Forms.Dialogs;
using Optimum_Tech.Model;
using Optimum_Tech.View.Resources;

namespace OptimumTech.Controls
{
    public partial class ProductControl : UserControl
    {
        private FormDescription formDescription;

        public bool IsFavorite { get; set; } = false;
        public bool IsSelected { get; set; } = false;

        public ProductControl(Product product)
        {
            InitializeComponent();

            textBoxProductName.Text = product.Name;
            textBoxPrice.Text = $"${product.Price}";
            textBoxResponses.Text = $"{product.Responses} Reviews";

            pictureBoxRating.Image = GetRating(product);
            pictureBoxProduct.Image = GetImage(product);
            GetStatus(product);

            pictureBoxFavorite.Click += (sender, e) => pictureBoxFavorite_Click(sender, e, product);
            pictureBoxCart.Click += (sender, e) => pictureBoxCart_Click(sender, e, product);
            pictureBoxDescription.Click += (sender, e) => pictureBoxDescription_Click(sender, e, product);
        }

        public void GetStatus(Product product)
        {
            if (product.IsAvailable == true)
            {
                this.textBoxAvailable.ForeColor = Color.FromArgb(0, 160, 70);
                this.textBoxAvailable.Text = "Available";
            }
            else if (product.IsAvailable == false)
            {
                this.pictureBoxCart.Image = FormsMedia.basket_blocked;
                this.pictureBoxFavorite.Image = FormsMedia.favorite_blocked;
                this.textBoxAvailable.ForeColor = Color.Red;
                this.textBoxAvailable.Text = "Out of stock";
            }
        }

        public Image GetImage(Product product)
        {
            Dictionary<string, Image> imageDictionary = new Dictionary<string, Image>()
            {
                {"Intel Core i9 13900KF", FormsMedia.Intel_Core_i9_13900K},
                {"AMD Ryzen 9 7950X3D", FormsMedia.AMD_Ryzen_9_7950X3D},
                {"AMD Ryzen 5 7600X", FormsMedia.AMD_Ryzen_5_7600X}
            };

            if (imageDictionary.TryGetValue(product.Name, out Image image))
            {
                return image;
            }

            return null;
        }

        public Image GetRating(Product product)
        {
            switch (product.Rating)
            {
                case 0:
                    return FormsMedia.no_stars;
                case 1:
                    return FormsMedia.one_star;
                case 2:
                    return FormsMedia.two_stars;
                case 3:
                    return FormsMedia.three_stars;
                case 4:
                    return FormsMedia.four_stars;
                case 5:
                    return FormsMedia.five_stars;
            }
            return null;
        }

        #region events

        private void pictureBoxCart_Click(object? sender, EventArgs e, Product product)
        {
            if (product != null)
            {
                if (product.IsAvailable == false)
                {
                    this.pictureBoxCart.Image = FormsMedia.basket_blocked;
                }
                else
                {
                    if (IsSelected == false)
                    {
                        IsSelected = true;
                        this.pictureBoxCart.Image = FormsMedia.basket_filled;
                    }
                    else
                    {
                        IsSelected = false;
                        this.pictureBoxCart.Image = FormsMedia.basket_empty;
                    }
                }
            }
        }

        private void pictureBoxFavorite_Click(object? sender, EventArgs e, Product product)
        {
            if (product != null)
            {
                if (product.IsAvailable == false)
                {
                    this.pictureBoxFavorite.Image = FormsMedia.favorite_blocked;
                }
                else
                {
                    if (IsFavorite == false)
                    {
                        this.IsFavorite = true;
                        this.pictureBoxFavorite.Image = FormsMedia.favorite_filled;
                        
                        UserManager.AddToFavorites(this);
                    }
                    else if (IsFavorite == true)
                    {
                        this.IsFavorite = false;
                        this.pictureBoxFavorite.Image = FormsMedia.favorite_empty;

                        FormFavorites formFavorites = (FormFavorites)this.FindForm();
                        formFavorites.flowLayoutPanel1.Controls.Remove(this);
                        UserManager.RemoveFromFavorites(this);
                    }
                }
            }
        }

        private void pictureBoxDescription_Click(object sender, EventArgs e, Product product)
        {
            if (formDescription == null || formDescription.IsDisposed)
            {
                formDescription = new FormDescription(product);
                formDescription.FormClosed += (s, ev) => formDescription = null;
                formDescription.Show();
            }
            else
            {
                formDescription.BringToFront();
            }
        }

        #endregion
    }
}
