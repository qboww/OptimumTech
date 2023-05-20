using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Forms;
using Optimum_Tech.Forms.Dialogs;
using Optimum_Tech.Model;
using Optimum_Tech.Views.Dialogs;
using OptimumTech.Controls;
using System.Drawing.Text;

namespace Optimum_Tech.View.Forms
{
    public partial class FormSelections : Form
    {
        private readonly FormMain formMain;
        private FormLogin formLogin;
        private readonly FormAccount formAccount;
        private FormOrder formOrder;

        public FormSelections(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"..\..\Repository\Poppins-Regular.ttf");
        }

        private void FormSelections_Load(object sender, EventArgs e)
        {
            RefreshSelections();
        }

        private void RefreshSelections()
        {
            this.flowLayoutPanel1.Controls.Clear();

            if (UserManager.CurrentUser != null && UserManager.CurrentUser.Selections != null)
            {
                foreach (ProductControl control in UserManager.CurrentUser.Selections)
                {
                    if (control.IsSelected)
                    {
                        control.IsSelectionChanged += ProductControl_IsSelectedChanged;
                        this.flowLayoutPanel1.Controls.Add(control);
                    }
                }
            }

            UpdateSelectionsTotal();
        }

        private void ProductControl_IsSelectedChanged(object sender, EventArgs e)
        {
            var control = sender as ProductControl;
            if (!control.IsSelected)
            {
                control.IsSelectionChanged -= ProductControl_IsSelectedChanged;
                this.flowLayoutPanel1.Controls.Remove(control);
            }

            UpdateSelectionsTotal();
        }

        private void UpdateSelectionsTotal()
        {
            decimal totalPrice = 0;
            int itemCount = 0;

            foreach (ProductControl control in this.flowLayoutPanel1.Controls)
            {
                if (control.IsSelected)
                {
                    totalPrice += control.ProductPrice;
                    itemCount++;
                }
            }

            this.textBoxPrice.Text = $"Price: ${totalPrice}";
            this.textBoxAmount.Text = $"Amount: {itemCount} pcs";
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            if (UserManager.CurrentUser.Access is Access.Guest)
            {
                MessageBox.Show("You should log in first!");
            }
            else
            {
                if (formOrder == null || formOrder.IsDisposed)
                {
                    formOrder = new FormOrder(formMain);
                    formOrder.Show();
                }
            }
        }
    }
}
