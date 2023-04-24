using Optimum_Tech.Model;
using Optimum_Tech.Model.Products;

namespace Optimum_Tech.Forms.Dialogs
{
    public partial class FormDescription : Form
    {
        Product product;
        public FormDescription(Product product)
        {
            InitializeComponent();

            this.product = product;
        }


        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDescription_Load(object sender, EventArgs e)
        {
            this.Text = $"{product.Name}";
            this.textBoxId.Text = $"Id: {Convert.ToString(product.Id)}";
            this.textBoxName.Text = $"Name: {product.Name}";
            this.textBoxPrice.Text = $"Price: {Convert.ToString(product.Price)}$";
            this.textBoxResponses.Text = $"Responses: {Convert.ToString(product.Responses)}";
            this.textBoxRating.Text = $"Rating: {Convert.ToString(product.Rating)} stars";

            if (product is Processor)
            {
                this.textBoxManufacturer.Text = $"Manufacturer: {product.Manufacturer}";
                this.textBoxSocket.Text = $"Socket: {product.Socket}";
                this.textBoxCores.Text = $"Cores: {product.Cores}";
                this.textBoxThreads.Text = $"Threads: {product.Threads}";
                this.textBoxDefaultSpeed.Text = $"Default speed: {product.ClockSpeedDefault} GHz";
                this.textBoxBoostSpeed.Text = $"Boost speed: {product.ClockSpeedBoost} GHz";
            }
        }
    }
}
