using Optimum_Tech.View.Displays;
using System.Drawing.Text;

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
            var form = new FormProcessors();
            formMain.OpenChildForm(form);;        
        }

        private void pictureBoxGraphicsCards_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormGraphicsCards();
            formMain.OpenChildForm(form);
        }
    }
}
