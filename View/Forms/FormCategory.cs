using Optimum_Tech.View.Displays;

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
            var form = new FormDisplayProcessors();
            formMain.OpenChildForm(form);
        }

        private void pictureBoxGraphicsCards_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormDisplayGraphicsCards();
            formMain.OpenChildForm(form);
        }
    }
}
