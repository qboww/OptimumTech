using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimum_Tech.Views.Controls
{
    public partial class SetAddress : UserControl
    {
        public SetAddress()
        {
            InitializeComponent();

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"..\..\Fonts\Poppins-Regular.ttf");
        }
    }
}
