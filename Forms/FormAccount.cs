using Optimum_Tech.Forms.Dialogs;
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
        public readonly FormMain formMain;
        private FormLogin formLogin;

        public string TextBoxStatus
        {
            get { return textBoxStatus.Text; }
            set { textBoxStatus.Text = value; }
        }

        public FormAccount(FormMain formMain)
        {
            InitializeComponent();

            this.formMain = formMain;
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
            FormRegister form = new FormRegister();
            form.Show();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
