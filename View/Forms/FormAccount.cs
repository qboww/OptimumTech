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
        }

        #endregion
    }
}
