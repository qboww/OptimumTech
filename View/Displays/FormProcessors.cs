using Optimum_Tech.Model;
using Optimum_Tech.Model.Managers;
using Optimum_Tech.Model.Products;
using OptimumTech.Controls;

namespace Optimum_Tech.Forms
{
    public partial class FormProcessors : Form
    {
        public FormProcessors()
        {
            InitializeComponent();
        }

        private void FormProcessors_Load(object sender, EventArgs e)
        {
            // Add the controls to the flowLayoutPanel
            foreach (Processor product in ProductManager.processors)
            {
                ProductControl control = new ProductControl(product);
                flowLayoutPanel1.Controls.Add(control);
            }
        }
    }
}