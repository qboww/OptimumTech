using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Model.Products;
using OptimumTech.Controls;
using System.Drawing.Text;

namespace Optimum_Tech.Forms
{
    public partial class FormProcessors : Form
    {
        FormMain formMain;

        public FormProcessors()
        {
            InitializeComponent();
        }

        private void FormProcessors_Load(object sender, EventArgs e)
        {
            foreach (Processor product in ProductManager.Processors)
            {
                ProductControl control = new ProductControl(product);

                flowLayoutPanel1.Controls.Add(control);
            }
        }
    }
}