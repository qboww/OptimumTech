using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Forms;
using Optimum_Tech.Model.Products;
using OptimumTech.Controls;

namespace Optimum_Tech.View.Displays
{
    public partial class FormGraphicsCards : Form
    {
        FormMain formMain;
        FormCategory formCategory;

        public FormGraphicsCards()
        {
            InitializeComponent();
        }

        private void FormDisplayGraphicsCards_Load(object sender, EventArgs e)
        {
            // Add the controls to the flowLayoutPanel
            foreach (GraphicsCard product in ProductManager.graphicsCards)
            {
                ProductControl control = new ProductControl(product);
                flowLayoutPanel1.Controls.Add(control);
            }
        }
    }
}
