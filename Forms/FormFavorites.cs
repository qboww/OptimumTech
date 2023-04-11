using Optimum_Tech.Model;
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
    public partial class FormFavorites : Form
    {
        private readonly FormMain formMain;

        public FormFavorites(FormMain formMain)
        {
            InitializeComponent();

            this.formMain = formMain;
        }

        private void FormFavorites_Load(object sender, EventArgs e)
        {

        }
    }
}
