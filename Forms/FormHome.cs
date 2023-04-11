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
    public partial class FormHome : Form
    {
        private readonly FormMain formMain;
        public FormHome(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }
    }
}
