using Optimum_Tech.Model;
using OptimumTech.Controls;

namespace Optimum_Tech.Forms
{
    public partial class FormProcessors : Form
    {
        private readonly MainForm _parent;

        public FormProcessors(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;

            foreach (Processor processor in Processor.Storage)
            {
                Product product = new Product(processor);
                flowLayoutPanel1.Controls.Add(product);
            }
        }
    }
}