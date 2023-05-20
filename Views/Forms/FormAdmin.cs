using Newtonsoft.Json;
using Optimum_Tech.Controls;
using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Forms;
using Optimum_Tech.Model;
using Optimum_Tech.Model.Products;
using Optimum_Tech.Models;
using Timer = System.Windows.Forms.Timer;

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

            listBoxProducts.Items.AddRange(ProductManager.Processors.Select(p => p.Name).OrderBy(n => n).ToArray());
            listBoxProducts.Items.AddRange(ProductManager.GraphicsCards.Select(p => p.Name).OrderBy(n => n).ToArray());
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
                Product product = ProductManager.Products.FirstOrDefault(p => p.Name == selectedProduct);

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
                    currentControl.Dock = DockStyle.Left;
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
                    foreach (Processor product in ProductManager.Processors)
                    {
                        try
                        {
                            if (product.Id == Guid.Parse(editProcessor.textBoxId.Text))
                            {
                                product.Name = editProcessor.textBoxName.Text;
                                product.Price = Convert.ToDecimal(editProcessor.textBoxPrice.Text);
                                product.Responses = Convert.ToInt32(editProcessor.textBoxResponses.Text);
                                product.Rating = Convert.ToInt32(editProcessor.textBoxRating.Text);
                                product.IsAvailable = Convert.ToBoolean(editProcessor.textBoxAvailable.Text);

                                product.Manufacturer = editProcessor.textBoxManufacturer.Text;
                                product.Socket = editProcessor.textBoxSocket.Text;
                                product.Cores = Convert.ToInt32(editProcessor.textBoxCores.Text);
                                product.Threads = Convert.ToInt32(editProcessor.textBoxThreads.Text);
                                product.ClockSpeedDefault = Convert.ToDouble(editProcessor.textBoxClockSpeedDefault.Text);
                                product.ClockSpeedBoost = Convert.ToDouble(editProcessor.textBoxClockSpeedBoost.Text);

                                ProductManager.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            break;
                        }
                    }

                    string processorsJson = JsonConvert.SerializeObject(ProductManager.Processors);
                    File.WriteAllText("processors.json", processorsJson);
                }
                else if (currentControl is EditGraphicsCard editGraphicsCard)
                {
                    foreach (GraphicsCard product in ProductManager.GraphicsCards)
                    {
                        try
                        {
                            if (product.Id == Guid.Parse(editGraphicsCard.textBoxId.Text))
                            {
                                product.Name = editGraphicsCard.textBoxName.Text;
                                product.Price = Convert.ToDecimal(editGraphicsCard.textBoxPrice.Text);
                                product.Responses = Convert.ToInt32(editGraphicsCard.textBoxResponses.Text);
                                product.Rating = Convert.ToInt32(editGraphicsCard.textBoxRating.Text);
                                product.IsAvailable = Convert.ToBoolean(editGraphicsCard.textBoxAvailable.Text);

                                product.Manufacturer = editGraphicsCard.textBoxManufacturer.Text;
                                product.VRAM = Convert.ToInt32(editGraphicsCard.textBoxVRAM.Text);
                                product.MemoryInterface = Convert.ToInt32(editGraphicsCard.textBoxMemoryInterface.Text);
                                product.MemoryType = editGraphicsCard.textBoxMemoryType.Text;
                                product.ClockSpeed = Convert.ToDouble(editGraphicsCard.textBoxClockSpeedDefault.Text);
                                product.MinimumWattage = Convert.ToInt32(editGraphicsCard.textBoxMinimumWattage.Text);

                                ProductManager.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            break;
                        }
                    }

                    string graphicsCardsJson = JsonConvert.SerializeObject(ProductManager.GraphicsCards);
                    File.WriteAllText("graphicsCards.json", graphicsCardsJson);
                }
            }
        }
        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            string userLogin = textBoxSearchUserText.Text.Trim();

            if (!string.IsNullOrEmpty(userLogin))
            {
                List<User> users = UserManager.LoadUsers();
                bool userExists = users.Any(user => user.Login == userLogin);

                if (userExists)
                {
                    textBoxState.Text = "exists";
                    textBoxState.ForeColor = Color.Aquamarine;
                }
                else
                {
                    Timer timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += (s, ev) =>
                    {
                        textBoxState.Text = "isn't selected";
                        textBoxState.ForeColor = Color.White;

                        timer.Stop();
                        timer.Dispose();
                    };

                    textBoxState.Text = "does not exist";
                    textBoxState.ForeColor = Color.Red;

                    timer.Start();
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string userLogin = textBoxSearchUserText.Text.Trim();

            if (!string.IsNullOrEmpty(userLogin))
            {
                List<User> users = UserManager.LoadUsers();
                User userToRemove = users.FirstOrDefault(u => u.Login == userLogin);

                if (userToRemove != null)
                {
                    userToRemove.Dispose();
                    users.Remove(userToRemove);

                    textBoxState.Text = "is deleted";
                    textBoxState.ForeColor = Color.LimeGreen;

                    MessageBox.Show($"User is deleted successfully");
                }
            }
        }
        private void buttonDelSave_Click(object sender, EventArgs e)
        {
            UserManager.SaveUsers();
        }
        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }
        private void textBoxSearchUserText_Click(object sender, EventArgs e)
        {
            textBoxSearchUserText.Clear();
        }
        private void buttonRepository_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", ProductManager.repositoryPath);
        }
    }
}