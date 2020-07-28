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
using FontAwesome.Sharp;

namespace GenericLayout
{
    public partial class MainForm : Form
    {
        #region Properties
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentForm;
        #endregion

        #region Struct
        private struct Colors
        {
            public static Color primaryColor = Color.FromArgb(54, 56, 46);
            public static Color secondaryColor = Color.FromArgb(246, 174, 45);

            public static Color primaryColorClick = Color.FromArgb(32, 34, 28);
            public static Color secondaryColorClick = Color.FromArgb(235, 237, 233);
        }
        #endregion

        #region ctor
        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelSide.Controls.Add(leftBorderBtn);
            BindingEvents();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #endregion


        #region Events
        private void BindingEvents()
        {
            buttonTruck.Click += ButtonSelect_Click;
            buttonContact.Click += ButtonSelect_Click;
            buttonDash.Click += ButtonSelect_Click;
            buttonExit.Click += ButtonExit_Click; ;
            buttonProducts.Click += ButtonSelect_Click;
            buttonSettings.Click += ButtonSelect_Click;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Application.Exit();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Colors.primaryColorClick;
                currentBtn.ForeColor = Colors.secondaryColorClick;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Colors.secondaryColorClick;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = Colors.secondaryColorClick;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                currentChildIcon.IconChar = currentBtn.IconChar;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Colors.primaryColor;
                currentBtn.ForeColor = Colors.secondaryColor;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Colors.secondaryColor;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void logoPicture_Click(object sender, EventArgs e)
        {
            currentForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentChildIcon.IconChar = IconChar.Home;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Private Methods
        private void OpenChildForm(Form childForm)
        {
            currentForm?.Close();

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        #endregion


    }
}
