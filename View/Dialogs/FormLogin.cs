using Optimum_Tech.Model;

namespace Optimum_Tech.Forms.Dialogs
{
    public partial class FormLogin : Form
    {
        private FormAccount formAccount;
        private FormMain formMain;

        #region constructors

        public FormLogin(FormAccount formAccount, FormMain formMain)
        {
            InitializeComponent();

            this.formAccount = formAccount;
            this.formMain = formMain;

            textBoxLogin.Click += textBoxLogin_Click;
            buttonLogin.Click += buttonLogin_Click;
        }

        #endregion

        #region events

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (UserManager.Login(textBoxLogin, textBoxPassword))
            {
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

                UserManager.UpdateStatus(formAccount.textBoxStatus);
                this.Close();
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region textboxes

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Text = "";
        }

        #endregion

        private void textBoxLogin_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
        }
    }
}
