using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Model;
using System.Drawing.Text;

namespace Optimum_Tech.Forms.Dialogs
{
    public partial class FormRegister : Form
    {
        private FormAccount formAccount;
        private FormMain formMain;
        public FormRegister(FormAccount formAccount, FormMain formMain)
        {
            InitializeComponent();

            this.formAccount = formAccount;
            this.formMain = formMain;

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"..\..\Fonts\Poppins-Regular.ttf");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (UserManager.Register(textBoxLogin.Text, textBoxPassword.Text))
            {
                UserManager.Login(textBoxLogin, textBoxPassword);
                UserManager.CurrentUser.Access = Access.User;
                MessageBox.Show("Account has been created!");
                UserManager.UpdateStatus(formAccount.textBoxStatus);
                this.Close();
            }
            else
            {
                textBoxLogin.Clear();
                textBoxPassword.Clear();
            }
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Text = "";
        }

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
    }
}
