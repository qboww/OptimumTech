using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Forms;
using Optimum_Tech.Views.Controls;

namespace Optimum_Tech.Views.Dialogs
{
    public partial class FormOrder : Form
    {
        private FormMain formMain;
        private UserControl currentControl;

        public FormOrder(FormMain formMain)
        {
            InitializeComponent();

            this.formMain = formMain;
            this.BringToFront();
            radioButtonAtAddress.Checked = true;
            this.textBoxId.Text = $"Order ID: {Guid.NewGuid().ToString()}";
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (var product in UserManager.currentUser.Selections)
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
                UserManager.currentUser.Email = this.textBoxEmail.Text;
                UserManager.currentUser.PhoneNumber = this.textBoxPhone.Text;

                MessageBox.Show("Operator will call you in 5 minutes");
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
                var selectedProduct = UserManager.currentUser.Selections[selectedIndex];
                var clonedProduct = selectedProduct;
                UserManager.currentUser.Selections.Insert(selectedIndex, clonedProduct);

                listBoxProducts.Items.Insert(selectedIndex + 1, $"{clonedProduct.ProductName} [${clonedProduct.ProductPrice}]");

                UpdateTotalAmountAndPrice();
            }
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxProducts.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < listBoxProducts.Items.Count)
            {
                listBoxProducts.Items.RemoveAt(selectedIndex);
                UserManager.currentUser.Selections.RemoveAt(selectedIndex);

                UpdateTotalAmountAndPrice();
            }
        }

        private void UpdateTotalAmountAndPrice()
        {
            decimal total = 0;
            foreach (var p in UserManager.currentUser.Selections)
            {
                total += p.ProductPrice;
            }
            this.textBoxAmount.Text = $" {listBoxProducts.Items.Count} pcs";
            this.textBoxPrice.Text = $" ${total}";
        }
    }
}
