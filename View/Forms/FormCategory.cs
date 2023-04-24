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
    public partial class FormCategory : Form
    {
        private readonly FormMain formMain;

        public FormCategory(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void pictureBoxProcessors_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormDisplay();
            formMain.OpenChildForm(form);
        }
    }
}
