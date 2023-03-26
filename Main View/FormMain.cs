
using OptimumTech.Controls;
using OptimumTech.Controls.Products;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace OptimumTech
{
    public partial class FormMain : Form
    {
        #region properties

        private int maximizeCount;
        private int tempWidth;
        private int tempHeight;
        private int panelWidth;
        private bool hidden;

        private int mov;
        private int movX;
        private int movY;

        #endregion

        private static FormMain? instance;
        internal static FormMain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormMain();
                }
                return instance;
            }
        }

        public FormMain()
        {
            InitializeComponent();

            panelWidth = panelSlide.Width;
            hidden = true;
            panelSlide.Width = 0;
            maximizeCount = 0;

            tempWidth = this.Width - panelSlide.Width;
            tempHeight = this.Height - panelSlide.Height;


        }

        #region timers_events

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
            movX = e.X;
            movY = e.Y;
        }
        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        #endregion

        #region buttons_events

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
            if (maximizeCount % 2 == 0)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(tempWidth, tempHeight);
                this.CenterToScreen();
            }

            maximizeCount++;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Visible)
            {
                labelSearch.Visible = true;
                textBoxSearch.Visible = false;
            }
            else
            {
                labelSearch.Visible = false;
                textBoxSearch.Visible = true;
                textBoxSearch.Focus();
            }

            textBoxSearch.Clear();
        }
        private void buttonCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();

            category.Size = panelMain.Size;
            category.Location = panelMain.Location;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(category);

            category.Parent = this.panelMain;
            category.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            category.Left = (panelMain.Width - category.Width) / 2;
            category.Top = (panelMain.Height - category.Height) / 2;
        }

        private void pictureBoxProcessors_Click(object sender, EventArgs e)
        {
            // handle the button click event here
        }

        #endregion

        #region textbox_events

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        #endregion
    }
}