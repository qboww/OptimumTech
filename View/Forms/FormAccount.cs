using Optimum_Tech.Forms.Dialogs;
using Optimum_Tech.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimum_Tech.Forms
{
    public partial class FormAccount : Form
    {
        private FormMain formMain;
        private FormLogin formLogin;

        public TextBox _textBoxStatus
        {
            get { return textBoxStatus; }
            set { textBoxStatus = value; }
        }

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
            if (!(UserManager.currentUser.Access is Status.Guest))
            {
                UserManager.LoginAsGuest();
                UserManager.UpdateStatus(this.textBoxStatus);
            }
        }

        #endregion
    }
}
