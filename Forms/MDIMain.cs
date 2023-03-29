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
    public partial class MDIMain : Form
    {
        #region properties

        private int tempWidth;
        private short tempHeight;
        private short panelWidth;
        private bool hidden;

        private short mov;
        private short movX;
        private short movY;

        #endregion

        public MDIMain()
        {
            InitializeComponent();

            this.IsMdiContainer = true;

            panelWidth = (short)panelSlide.Width;
            hidden = true;
            panelSlide.Width = 0;

            tempWidth = this.Width - panelSlide.Width;
            tempHeight = (short)(this.Height - panelSlide.Height);
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
            if (textBoxSearch.ReadOnly == true)
            {
                textBoxSearch.Clear();
                textBoxSearch.ReadOnly = false;
                textBoxSearch.BringToFront();
                textBoxSearchText.SendToBack();
            }
            else
            {
                textBoxSearch.Clear();
                textBoxSearchText.BringToFront();
                textBoxSearch.SendToBack();
            }

            if (textBoxSearch.Tag == null)
            {
                textBoxSearch.Tag = 1;
            }
            else
            {
                textBoxSearch.Clear();
                textBoxSearchText.BringToFront();
                textBoxSearchText.SendToBack();
                textBoxSearch.Tag = null;
            }
        }
        private void buttonCategory_Click(object sender, EventArgs e)
        {
            Form childForm = new FormCategory(this) { _parent = this };

            childForm.MdiParent = this;
            panelMain.Controls.Add(childForm);

            childForm.Anchor = AnchorStyles.None;
            childForm.Left = (panelMain.Width - childForm.Width) / 2;
            childForm.Top = (panelMain.Height - childForm.Height) / 2;

            childForm.Show();
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
