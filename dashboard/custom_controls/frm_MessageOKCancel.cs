﻿using System.Drawing;
using System.Windows.Forms;

namespace dashboard.custom_controls
{
    public partial class frm_MessageOKCancel : Form
    {
        public frm_MessageOKCancel()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return icon.Image; }
            set { icon.Image = value; }
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }
    }
}
