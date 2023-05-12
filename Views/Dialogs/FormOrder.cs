using Newtonsoft.Json;
using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Forms;
using Optimum_Tech.Model;
using Optimum_Tech.Model.Products;
using Optimum_Tech.Models;
using Optimum_Tech.Views.Controls;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Optimum_Tech.Views.Dialogs
{
    public partial class FormOrder : Form
    {
        private FormMain formMain;
        private UserControl currentControl;

        private static readonly string ordersFilePath = @"..\..\Repository\orders.json";
        private static readonly string usersFilePath = @"..\..\Repository\users.json";

        public FormOrder(FormMain formMain)
        {
            InitializeComponent();

            this.formMain = formMain;
            this.BringToFront();
            radioButtonAtAddress.Checked = true;

            this.textBoxId.Text = Guid.NewGuid().ToString();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (var product in UserManager.CurrentUser.Selections)
            {
                string productData = $"{product.ProductName} [${product.ProductPrice}]";
                listBoxProducts.Items.Add(productData);
                total += product.ProductPrice;
            }

            this.textBoxAmount.Text = $" {listBoxProducts.Items.Count} pcs";
            this.textBoxPrice.Text = $" ${total}";
        }
        private void radioButtonAtPost_CheckedChanged(object sender, EventArgs e)
        {
            if (currentControl != null)
            {
                panel2.Controls.Remove(currentControl);
            }

            SetPostOffice control = new SetPostOffice();
            panel2.Controls.Add(control);
            control.Dock = DockStyle.Left;
            currentControl = control;
        }
        private void radioButtonAtAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (currentControl != null)
            {
                panel2.Controls.Remove(currentControl);
            }

            SetAddress control = new SetAddress();
            panel2.Controls.Add(control);
            control.Dock = DockStyle.Left;
            currentControl = control;
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string deliveryAddress = "";
                DeliverType deliveryType;

                if (radioButtonAtAddress.Checked)
                {
                    SetAddress control = (SetAddress)currentControl;
                    deliveryAddress = control.textBoxAddress.Text;
                    deliveryType = DeliverType.AtTheAddress;
                }
                else
                {
                    SetPostOffice control = (SetPostOffice)currentControl;
                    deliveryAddress = control.listBoxAddresses.SelectedItem.ToString();
                    deliveryType = DeliverType.LocalPostOffice;
                }

                Order order = new Order(
                    this.textBoxEmail.Text,
                    deliveryAddress,
                    this.textBoxPhone.Text,
                    decimal.Parse(this.textBoxPrice.Text.Replace("$", "")),
                    int.Parse(Regex.Match(this.textBoxAmount.Text, @"\d+").Value),
                    deliveryType);

                foreach (string line in listBoxProducts.Items)
                {
                    foreach (Product product in ProductManager.Products)
                    {
                        if (line.Contains(product.Name))
                        {
                            order.Products.Add(product);
                        }
                    }
                }

                order.Username = UserManager.CurrentUser.Login;

                UserManager.CurrentUser.Orders.Add(order);

                string json = JsonConvert.SerializeObject(UserManager.CurrentUser.Orders, Formatting.Indented);

                using (StreamWriter writer = File.AppendText(ordersFilePath))
                {
                    writer.WriteLine(json);
                }

                UserManager.CurrentUser.Orders.Add(order);

                List<User> usersToSave = UserManager.LoadUsers().ToList();
                string json1 = JsonConvert.SerializeObject(usersToSave, Formatting.Indented);
                File.WriteAllText(usersFilePath, json1);

                MessageBox.Show("Your order is received. Operator will call you in 5 minutes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxProducts.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < listBoxProducts.Items.Count)
            {
                var selectedProduct = UserManager.CurrentUser.Selections[selectedIndex];
                var clonedProduct = selectedProduct;
                UserManager.CurrentUser.Selections.Insert(selectedIndex, clonedProduct);

                listBoxProducts.Items.Insert(selectedIndex, $"{clonedProduct.ProductName} [${clonedProduct.ProductPrice}]");

                UpdateTotalAmountAndPrice();
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxProducts.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < listBoxProducts.Items.Count)
            {
                listBoxProducts.Items.RemoveAt(selectedIndex);
                UserManager.CurrentUser.Selections.RemoveAt(selectedIndex);

                UpdateTotalAmountAndPrice();
            }

            if (listBoxProducts.Items.Count == 0)
            {
                MessageBox.Show("Add some products to cart first!");
                UserManager.CurrentUser.Selections.Clear();
                this.Close();
            }
        }

        private void UpdateTotalAmountAndPrice()
        {
            decimal total = 0;
            foreach (var p in UserManager.CurrentUser.Selections)
            {
                total += p.ProductPrice;
            }
            this.textBoxAmount.Text = $" {listBoxProducts.Items.Count} pcs";
            this.textBoxPrice.Text = $" ${total}";

            if (listBoxProducts.Items.Count == 0)
            {
                this.Close();
            }
        }
    }
}
