using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Forms.Dialogs;
using Optimum_Tech.Model;

namespace Optimum_Tech.Forms
{
    public partial class FormAccount : Form
    {
        private FormMain formMain;
        private FormLogin formLogin;

        public FormAccount(FormMain formMain)
        {
            InitializeComponent();

            this.formMain = formMain;
            UserManager.UpdateStatus(this.textBoxStatus);
        }

        #region events

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            if (formLogin == null || formLogin.IsDisposed)
            {
                formLogin = new FormLogin(this, formMain);
                formLogin.Show();
            }
        }

        private void pictureBoxRegister_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister(this, formMain);
            form.Show();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            if (!(UserManager.currentUser.Access is Access.Guest))
            {
                UserManager.LoginAsGuest();
                UserManager.UpdateStatus(this.textBoxStatus);
            }

            if (UserManager.currentUser.Access == Access.Admin)
            {
                formMain.buttonAdmin.Visible = true;
                formMain.buttonCart.Visible = false;
                formMain.buttonFavorites.Visible = false;

                formMain.textBoxAdmin.Visible = true;
                formMain.textBoxCart.Visible = false;
                formMain.textBoxFavorites.Visible = false;
            }
            else
            {
                formMain.buttonAdmin.Visible = false;
                formMain.buttonCart.Visible = true;
                formMain.buttonFavorites.Visible = true;

                formMain.textBoxAdmin.Visible = false;
                formMain.textBoxCart.Visible = true;
                formMain.textBoxFavorites.Visible = true;
            }

            #endregion
        }
    }
}
