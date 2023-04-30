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

            textBoxLogin.Enter += textBoxLogin_Enter;
            textBoxLogin.Leave += textBoxLogin_Leave;
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
                    formMain.textBoxAdmin.Visible = true;
                }
                else
                {
                    formMain.buttonAdmin.Visible = false;
                    formMain.textBoxAdmin.Visible = false;
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

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Login")
            {
                textBoxLogin.Text = "";
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                textBoxLogin.Text = "Login";
            }
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Text = "";
        }

        #endregion
    }
}
