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
            RefreshFavorites();
        }

        private void RefreshFavorites()
        {
            this.flowLayoutPanel1.Controls.Clear();

            if (UserManager.currentUser != null && UserManager.currentUser.Favorites != null)
            {
                foreach (ProductControl control in UserManager.currentUser.Favorites)
                {
                    if (control.IsFavorite)
                    {
                        control.IsFavoriteChanged += ProductControl_IsFavoriteChanged;
                        this.flowLayoutPanel1.Controls.Add(control);
                    }
                }
            }
        }

        private void ProductControl_IsFavoriteChanged(object sender, EventArgs e)
        {
            var control = sender as ProductControl;
            if (!control.IsFavorite)
            {
                control.IsFavoriteChanged -= ProductControl_IsFavoriteChanged;
                this.flowLayoutPanel1.Controls.Remove(control);
            }
        }
    }
}
