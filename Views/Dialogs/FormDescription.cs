using Optimum_Tech.Model.Products;
using Optimum_Tech.Models;
using System.Drawing.Text;

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
                Processor processor = (Processor)product;

                this.textBox1.Text = $"Manufacturer: {processor.Manufacturer}";
                this.textBox2.Text = $"Socket: {processor.Socket}";
                this.textBox3.Text = $"Cores: {processor.Cores}";
                this.textBox4.Text = $"Threads: {processor.Threads}";
                this.textBox5.Text = $"Default speed: {processor.ClockSpeedDefault} GHz";
                this.textBox6.Text = $"Boost speed: {processor.ClockSpeedBoost} GHz";
            }
            else if (product is GraphicsCard)
            {
                GraphicsCard graphicsCard = (GraphicsCard)product;

                this.textBox1.Text = $"Manufacturer: {graphicsCard.Manufacturer}";
                this.textBox2.Text = $"Memory size: {graphicsCard.VRAM} Gb";
                this.textBox3.Text = $"Memory interface: {graphicsCard.MemoryInterface} bit";
                this.textBox4.Text = $"Memory type: {graphicsCard.MemoryType}";
                this.textBox5.Text = $"Default speed: {graphicsCard.ClockSpeed} GHz";
                this.textBox6.Text = $"Minimum wattage: {graphicsCard.MinimumWattage}W";
            }
        }
    }
}
