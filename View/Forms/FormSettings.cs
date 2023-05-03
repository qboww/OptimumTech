using Optimum_Tech.Forms;

namespace Optimum_Tech.View.Forms
{
    public partial class FormSettings : Form
    {
        FormHome formHome;
        public FormSettings(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
        }

        private void buttonBanner_Click(object sender, EventArgs e)
        {
            if (this.textBoxState.Text == "Enabled")
            {
                formHome.panelBanner.Visible = false;
                this.textBoxState.Text = "Disabled";
                this.textBoxState.ForeColor = Color.Red;
            }
            else
            {
                formHome.panelBanner.Visible = true;
                this.textBoxState.Text = "Enabled";
                this.textBoxState.ForeColor = Color.LimeGreen;
            }
        }
    }
}
