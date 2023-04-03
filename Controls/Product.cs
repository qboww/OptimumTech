using Optimum_Tech.Model;
using Optimum_Tech.Properties;

namespace OptimumTech.Controls
{
    public partial class Product : UserControl
    {
        public Product(Category product)
        {
            InitializeComponent();

            textBoxProductName.Text = product.Name;
            textBoxPrice.Text = $"{product.Price}$";
            textBoxResponses.Text = $"{product.Responses} Reviews";
            textBoxAvailable.Text = GetStatus(product.Available);
            pictureBoxRating.Image = GetRating(product);
            pictureBoxProduct.Image = GetImage(product);

            pictureBoxFavorite.Click += (sender, e) => pictureBoxFavorite_Click(sender, e, product);
            pictureBoxCart.Click += (sender, e) => pictureBoxCart_Click(sender, e, product);
        }

        public Image GetImage(Category product)
        {
            Dictionary<string, Image> imageDictionary = new Dictionary<string, Image>()
            {
                {"Intel Core i9 13900KF", Resources.Intel_Core_i9_13900K},
                {"AMD Ryzen 9 7950X3D", Resources.AMD_Ryzen_9_7950X3D},
            };

            if (imageDictionary.TryGetValue(product.Name, out Image image))
            {
                return image;
            }

            return null;
        }

        public string GetStatus(bool available)
        {
            if (available == true) return "Available";
            else return "Out of stock";
        }

        public Image GetRating(Category product)
        {
            switch (product.Rating)
            {
                case 0:
                    return Resources.no_stars;
                case 1:
                    return Resources.one_star;
                case 2:
                    return Resources.two_stars;
                case 3:
                    return Resources.three_stars;
                case 4:
                    return Resources.four_stars;
                case 5:
                    return Resources.five_stars;
            }
            return Resources.no_stars;
        }

        private void pictureBoxCart_Click(object? sender, EventArgs e, Category product)
        {
            if (product != null)
            {
                if (product.IsSelected == false)
                {
                    product.IsSelected = true;
                    this.pictureBoxCart.Image = Resources.basket_filled;
                }
                else
                {
                    product.IsSelected = false;
                    this.pictureBoxCart.Image = Resources.basket_empty;
                }
            }
        }

        private void pictureBoxFavorite_Click(object? sender, EventArgs e, Category product)
        {
            if (product != null)
            {
                if (product.IsFavorite == false)
                {
                    product.IsFavorite = true;
                    this.pictureBoxFavorite.Image = Resources.favorite_filled;
                }
                else
                {
                    product.IsFavorite = false;
                    this.pictureBoxFavorite.Image = Resources.favorite_empty;
                }
            }
        }
    }
}
