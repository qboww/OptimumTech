using System.Diagnostics;
using System.Drawing.Text;

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
