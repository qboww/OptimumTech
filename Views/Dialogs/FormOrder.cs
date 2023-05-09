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
                string productData = $"{product.ProductName} [${product.ProductPrice}] [1pcs]";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Operator will call you in 5 minutes");

            this.Close();
        }
    }
}
