using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericLayout
{
    public partial class MainUI : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region ctor
        public MainUI()
        {
            InitializeComponent();
            InitialConfiguration();
        }
        #endregion

        #region Private Methods
        private void InitialConfiguration()
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Colors
            panelHeader.BackColor = Theme.panelHeader;
            panelSide.BackColor = Theme.primaryColor;
            iconHome.IconColor = Theme.detailColor;

            BindEvents();
        }

        private void BindEvents()
        {
            btnProcurar.MouseEnter += BtnHeader_MouseEnter;
            btnProcurar.MouseLeave += BtnHeader_MouseLeave;
            btnSeguindo.MouseEnter += BtnHeader_MouseEnter;
            btnSeguindo.MouseLeave += BtnHeader_MouseLeave;
            btnMusica.MouseEnter += BtnHeader_MouseEnter;
            btnMusica.MouseLeave += BtnHeader_MouseLeave;
            btnEsports.MouseEnter += BtnHeader_MouseEnter;
            btnEsports.MouseLeave += BtnHeader_MouseLeave;
            iconHome.MouseEnter += 
                (sender, args) =>
                {
                    var btn = sender as IconButton;
                    btn.IconColor = Theme.accentColor;
                };
            iconHome.MouseLeave +=
                (sender, args) =>
                {
                    var btn = sender as IconButton;
                    btn.IconColor = Theme.detailColor;
                };
            Resize += MainUI_Resize;
        }
        #endregion

        #region Events

        private void BtnHeader_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.ForeColor = Theme.accentColor;
        }

        private void BtnHeader_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.ForeColor = Theme.detailHoverColor;

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainUI_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion        

    }
}
