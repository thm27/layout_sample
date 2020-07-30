using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace GenericLayout.Components
{
    public partial class Card : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );


        public Card()
        {
            InitializeComponent();
        }

        private void btnTag_Paint(object sender, PaintEventArgs e)
        {
            btnTag.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTag.Width, btnTag.Height, 30, 100));
            base.OnPaint(e);
        }
    }
}
