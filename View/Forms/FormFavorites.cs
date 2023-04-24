using Optimum_Tech.Model;
using Optimum_Tech.View;
using OptimumTech.Controls;
using System.Windows.Forms.VisualStyles;

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
            this.flowLayoutPanel1.Controls.Clear();

            if (UserManager.currentUser != null && UserManager.currentUser.Favorites != null)
            {
                foreach (ProductControl control in UserManager.currentUser.Favorites)
                {
                    this.flowLayoutPanel1.Controls.Add(control);
                }
            }
        }
    }
}
