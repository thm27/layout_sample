using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericLayout.Components
{
    public partial class TextInput : UserControl
    {
        private string placeHolder = string.Empty;
        private bool inputTouched = false;

        public string PlaceHolder
        {
            get { return placeHolder; }
            set
            {
                placeHolder = value;
                inputText.Text = value;
            }
        }

        public TextInput()
        {
            InitializeComponent();
        }


        private void inputText_Enter(object sender, EventArgs e)
        {
            if (!inputTouched)
            {
                inputTouched = true;
                inputText.Text = string.Empty;
            }
            panelUnderline.BackColor = Theme.detailColor;
            inputText.ForeColor = Theme.detailColor;
        }

        private void inputText_Leave(object sender, EventArgs e)
        {
            if (inputTouched && string.IsNullOrEmpty(inputText.Text))
            {
                inputTouched = false;
                PlaceHolder = placeHolder;
            }

            panelUnderline.BackColor = Theme.accentColor;
            inputText.ForeColor = Theme.accentColor;
        }
    }
}
