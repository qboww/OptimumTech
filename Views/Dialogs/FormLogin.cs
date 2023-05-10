using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Model;

namespace Optimum_Tech.Forms.Dialogs
{
    public partial class FormLogin : Form
    {
        private FormRegister formRegister;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (formRegister == null || formRegister.IsDisposed)
            {
                formRegister = new FormRegister(formAccount, formMain);
                formRegister.FormClosed += (s, ev) => formRegister = null;
                this.Close();
                formRegister.Show();
            }
            else
            {
                formRegister.BringToFront();
            }
        }

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

                this.Close();
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region textboxes

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxPassword.UseSystemPasswordChar = true;
        }
        private void textBoxLogin_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
        }

        #endregion

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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

                    this.Close();
                }

                UserManager.UpdateStatus(formAccount.textBoxStatus);
            }
        }
    }
}
