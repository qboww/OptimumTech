using OptimumTech.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimum_Tech.Forms
{
    public partial class FormProcessors : Form
    {
        Form? childForm;
        public MDIMain? _parent { get; set; }

        public FormProcessors(MDIMain parent)
        {
            InitializeComponent();
        }

        private void FormProcessors_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                Product product = new Product();

                flowLayoutPanel1.Controls.Add(product);
            }

            int totalChildWidth = flowLayoutPanel1.Controls.OfType<Control>().Sum(control => control.Width + control.Margin.Horizontal);
            int marginValue = (flowLayoutPanel1.Width - totalChildWidth) / 2;
            flowLayoutPanel1.Margin = new Padding(0, 0, 0, 0) { Left = marginValue, Right = marginValue };
        }
    }
}
