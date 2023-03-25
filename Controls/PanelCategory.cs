using OptimumTech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimum_Tech.Controls
{
    public partial class PanelCategory : UserControl
    {
        public PanelCategory()
        {
            InitializeComponent();
        }

        private void pictureBoxProcessors_Click(object sender, EventArgs e)
        {
            FormMainScreen.Instance.Controls.Clear();

            this.Anchor = AnchorStyles.None;
            this.Left = (FormMainScreen.Instance.Width - this.Width) / 2;
            this.Top = (FormMainScreen.Instance.Height - this.Height) / 2;

            FormMainScreen.Instance.Controls.Add(this);
        }
    }
}