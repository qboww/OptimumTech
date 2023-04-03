using Optimum_Tech.Model;
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
        public MainForm? _parent { get; set; }

        public FormProcessors(MainForm parent)
        {
            InitializeComponent();

            foreach(Processor processor in Processor.Storage)
            {
                Product product = new(processor);
                flowLayoutPanel1.Controls.Add(product);
            }
        }
    }
}
