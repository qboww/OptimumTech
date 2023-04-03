using OptimumTech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Optimum_Tech.Forms
{
    public partial class CategoryForm : Form
    {
        Form? childForm;
        public MainForm? _parent { get; set; }

        public CategoryForm(MainForm parent)
        {
            InitializeComponent();
        }

        private void pictureBoxProcessors_Click(object sender, EventArgs e)
        {
            var instance = (MainForm)Application.OpenForms[0];

            childForm = new FormProcessors(instance);

            childForm.MdiParent = instance;
            instance.panelMain.Controls.Add(childForm);

            childForm.Dock = DockStyle.Fill;

            childForm.Show();
            Hide();
        }
    }
}
