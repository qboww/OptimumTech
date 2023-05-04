using Optimum_Tech.Model;
using Optimum_Tech.View.Displays;
using Optimum_Tech.View.Forms;
using Optimum_Tech.View.Screens;

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
        private FormAdmin formAdmin;
        private FormContact formContact;
        private FormSettings formSettings;
        private FormFavoritesEmpty formFavoritesEmpty;
        private FormSelectionsEmpty formSelectionsEmpty;
        private FormSearchEmpty formSearchEmpty;

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
            CloseAllForms();

            FormSearch formSearch = new FormSearch(this);

            if (formSearch.searchControls.Count > 0)
            {
                if (formSearch == null || formSearch.IsDisposed)
                {
                    formSearch = new FormSearch(this);
                }
                OpenChildForm(formSearch);
            }
            else
            {
                if (formSearchEmpty == null || formSearchEmpty.IsDisposed)
                {
                    formSearchEmpty = new FormSearchEmpty();
                }
                OpenChildForm(formSearchEmpty);
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
        private void buttonCart_Click(object sender, EventArgs e)
        {
            CloseAllForms();

            FormSelections formSelections = new FormSelections(this);


            if (UserManager.currentUser.Selections.Count > 0)
            {
                if (formSelections == null || formSelections.IsDisposed)
                {
                    formSelections = new FormSelections(this);
                }
                OpenChildForm(formSelections);
            }
            else
            {
                if (formSelectionsEmpty == null || formSelectionsEmpty.IsDisposed)
                {
                    formSelectionsEmpty = new FormSelectionsEmpty();
                }
                OpenChildForm(formSelectionsEmpty);
            }
        }
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            CloseAllForms();

            if (formAdmin == null || formAdmin.IsDisposed)
            {
                formAdmin = new FormAdmin(this);
            }

            OpenChildForm(formAdmin);
        }
        private void buttonContact_Click(object sender, EventArgs e)
        {
            CloseAllForms();

            if (formContact == null || formContact.IsDisposed)
            {
                formContact = new FormContact();
            }

            OpenChildForm(formContact);
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            CloseAllForms();

            if (formSettings == null || formSettings.IsDisposed)
            {
                formSettings = new FormSettings(formHome);
            }

            OpenChildForm(formSettings);
        }

        #endregion

        #region textbox_events

        private void textBoxSearchText_Enter(object sender, EventArgs e)
        {
            textBoxSearchText.Text = string.Empty;
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

            ProductManager.LoadProducts();

            UserManager.LoadUsers();

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
