using Newtonsoft.Json;
using Optimum_Tech.Controls;
using Optimum_Tech.Forms;
using Optimum_Tech.Model;
using Optimum_Tech.Model.Products;

namespace Optimum_Tech.View.Forms
{
    public partial class FormAdmin : Form
    {
        private readonly FormMain formMain;
        private Control currentControl;

        public FormAdmin(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;

            listBoxProducts.Items.AddRange(ProductManager.processors.Select(p => p.Name).OrderBy(n => n).ToArray());
            listBoxProducts.Items.AddRange(ProductManager.graphicsCards.Select(p => p.Name).OrderBy(n => n).ToArray());
            listBoxProducts.Sorted = true;
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentControl != null)
            {
                panelProduct.Controls.Remove(currentControl);
            }

            string selectedProduct = listBoxProducts.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedProduct))
            {
                Product product = ProductManager.products.FirstOrDefault(p => p.Name == selectedProduct);

                if (product is GraphicsCard graphicsCard)
                {
                    currentControl = new EditGraphicsCard(graphicsCard);
                }
                else if (product is Processor processor)
                {
                    currentControl = new EditProcessor(processor);
                }

                if (currentControl != null)
                {
                    panelProduct.Controls.Add(currentControl);
                    currentControl.Dock = DockStyle.Bottom;
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string productName = textBoxSearch.Text.Trim();

            if (!string.IsNullOrEmpty(productName))
            {
                string selectedProduct = listBoxProducts.Items.Cast<string>().FirstOrDefault(name => name.StartsWith(productName, StringComparison.OrdinalIgnoreCase));

                if (selectedProduct != null)
                {
                    listBoxProducts.SelectedItem = selectedProduct;
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (currentControl != null)
            {
                if (currentControl is EditProcessor editProcessor)
                {
                    foreach (Processor product in ProductManager.processors)
                    {
                        if (product.Id == Guid.Parse(editProcessor.textBoxId.Text))
                        {
                            product.Name = editProcessor.textBoxName.Text;
                            product.Price = decimal.Parse(editProcessor.textBoxPrice.Text);
                            product.Responses = int.Parse(editProcessor.textBoxResponses.Text);
                            product.Rating = int.Parse(editProcessor.textBoxRating.Text);
                            product.IsAvailable = bool.Parse(editProcessor.textBoxAvailable.Text);

                            product.Manufacturer = editProcessor.textBoxManufacturer.Text;
                            product.Socket = editProcessor.textBoxSocket.Text;
                            product.Threads = int.Parse(editProcessor.textBoxThreads.Text);
                            product.ClockSpeedDefault = double.Parse(editProcessor.textBoxClockSpeedDefault.Text);
                            product.ClockSpeedBoost = double.Parse(editProcessor.textBoxClockSpeedBoost.Text);
                        }
                    }

                    string processorsJson = JsonConvert.SerializeObject(ProductManager.processors);
                    File.WriteAllText("processors.json", processorsJson);
                }
                else if (currentControl is EditGraphicsCard editGraphicsCard)
                {
                    foreach (GraphicsCard product in ProductManager.graphicsCards)
                    {
                        if (product.Id == Guid.Parse(editGraphicsCard.textBoxId.Text))
                        {
                            product.Name = editGraphicsCard.textBoxName.Text;
                            product.Price = decimal.Parse(editGraphicsCard.textBoxPrice.Text);
                            product.Responses = int.Parse(editGraphicsCard.textBoxResponses.Text);
                            product.Rating = int.Parse(editGraphicsCard.textBoxRating.Text);
                            product.IsAvailable = bool.Parse(editGraphicsCard.textBoxAvailable.Text);

                            product.Manufacturer = editGraphicsCard.textBoxManufacturer.Text;
                            product.VRAM = int.Parse(editGraphicsCard.textBoxVRAM.Text);
                            product.MemoryInterface = int.Parse(editGraphicsCard.textBoxMemoryInterface.Text);
                            product.MemoryType = editGraphicsCard.textBoxMemoryType.Text;
                            product.MinimumWattage = int.Parse(editGraphicsCard.textBoxMinimumWattage.Text);
                        }
                    }

                    string graphicsCardsJson = JsonConvert.SerializeObject(ProductManager.graphicsCards);
                    File.WriteAllText("graphicsCards.json", graphicsCardsJson);
                }
            }
        }
    }
}