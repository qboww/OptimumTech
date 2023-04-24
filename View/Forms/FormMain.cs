using Optimum_Tech.Model;
using Optimum_Tech.View.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Optimum_Tech.Forms
{
    public partial class FormMain : Form
    {
        #region fields

        private int tempWidth;
        private short tempHeight;
        private short panelWidth;
        private bool hidden;

        private short mov;
        private short movX;
        private short movY;

        private FormCategory formCategory;
        private FormAccount formAccount;
        private FormHome formHome;
        private FormFavoritesEmpty formFavoritesEmpty;

        #endregion


        #region props

        public Button AdminButton
        {
            get { return buttonAdmin; }
            set { buttonAdmin = value; }
        }

        public TextBox AdminTextBox
        {
            get { return textBoxAdmin; }
            set { textBoxAdmin = value; }
        }

        #endregion

        public FormMain()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            panelWidth = (short)panelSlide.Width;
            hidden = true;
            panelSlide.Width = 0;
            tempWidth = this.Width - panelSlide.Width;
            tempHeight = (short)(this.Height - panelSlide.Height);
            buttonCategory.Click += buttonCategory_Click;
            buttonAccount.Click += buttonAccount_Click;
            buttonHome.Click += buttonHome_Click;
        }

        #region timer_events

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                panelSlide.Width = panelSlide.Width + 50;

                if (panelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    hidden = false;
                    panelMain.Width = tempWidth;
                    this.Refresh();
                }
            }
            else
            {
                panelSlide.Width = panelSlide.Width - 50;

                if (panelSlide.Width <= 0)
                {
                    timer1.Stop();
                    hidden = true;
                    panelMain.Width = this.Width;
                    this.Refresh();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            this.Close();
        }

        #endregion

        #region panel_events

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = (short)e.X;
            movY = (short)e.Y;
        }
        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        #endregion

        #region button_events

        private void buttonDrawer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(tempWidth, tempHeight);
                this.CenterToScreen();
            }

            if (this.Tag == null)
            {
                this.Tag = 1;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(tempWidth, tempHeight);
                this.CenterToScreen();
                this.Tag = null;
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Tag == null)
            {
                textBoxSearch.Tag = 1;

                textBoxSearch.Clear();
                textBoxSearch.ReadOnly = false;
                textBoxSearch.BackColor = Color.White;
                textBoxSearch.BringToFront();
                textBoxSearchText.SendToBack();
            }
            else
            {
                textBoxSearch.Clear();
                textBoxSearch.SendToBack();
                textBoxSearchText.BringToFront();

                textBoxSearch.Tag = null;
            }
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            CloseAllForms();

            if (formCategory == null || formCategory.IsDisposed)
            {
                formCategory = new FormCategory(this);
            }

            OpenChildForm(formCategory);
        }
        private void buttonAccount_Click(object sender, EventArgs e)
        {
            CloseAllForms();

            if (formAccount == null || formAccount.IsDisposed)
            {
                formAccount = new FormAccount(this);
            }

            OpenChildForm(formAccount);
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            CloseAllForms();

            if (formHome == null || formHome.IsDisposed)
            {
                formHome = new FormHome(this);
            }

            OpenChildForm(formHome);
        }
        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            CloseAllForms();

            FormFavorites formFavorites = new FormFavorites(this);


            if (UserManager.currentUser.Favorites.Count > 0)
            {
                if (formFavorites == null || formFavorites.IsDisposed)
                {
                    formFavorites = new FormFavorites(this);
                }
                OpenChildForm(formFavorites);
            }
            else
            {
                if (formFavoritesEmpty == null || formFavoritesEmpty.IsDisposed)
                {
                    formFavoritesEmpty = new FormFavoritesEmpty();
                }
                OpenChildForm(formFavoritesEmpty);
            }
        }

        #endregion

        #region textbox_events

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            CloseAllForms();

            if (formHome == null || formHome.IsDisposed)
            {
                formHome = new FormHome(this);
            }

            OpenChildForm(formHome);

            UserManager.LoginAsGuest();
        }
        internal void OpenChildForm(Form childForm)
        {
            panelMain.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.Show();
        }
        internal void CloseAllForms()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }
    }
}
