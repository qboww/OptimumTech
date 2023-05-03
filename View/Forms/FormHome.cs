using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://savelife.in.ua/en/donate-en/#donate-army-card-monthly";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
