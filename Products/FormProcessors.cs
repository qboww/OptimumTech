using OptimumTech.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimum_Tech.Forms
{
    public partial class FormProcessors : Form
    {
        //Form? childForm;
        public MDIMain? _parent { get; set; }

        public FormProcessors(MDIMain parent)
        {
            InitializeComponent();

            for (int i = 0; i < 30; i++)
            {
                Product product = new();
                flowLayoutPanel1.Controls.Add(product);
            }
        }
    }
}
