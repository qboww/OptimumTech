using Optimum_Tech.Model;
using OptimumTech.Controls;

namespace Optimum_Tech.Forms
{
    public partial class FormProduct : Form
    {
        private readonly FormMain formMain;

        public FormProduct(FormMain form)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void FormProcessors_Load(object sender, EventArgs e)
        {
            foreach (Processor processor in Processor.Storage)
            {
                Product product = new Product(processor);
                flowLayoutPanel1.Controls.Add(product);
            }
        }
    }
}