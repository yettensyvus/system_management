﻿using System;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_peoples_management : Form
    {
        public frm_peoples_management()
        {
            InitializeComponent();
        }


        //form load 
        private void open_form(object form)
        {
            if (this.panel_Child.Controls.Count > 0)
                this.panel_Child.Controls.Clear();
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel_Child.Controls.Add(fh);
            this.panel_Child.Tag = fh;
            fh.Show();
        }

        private void btnPeoples_Click(object sender, EventArgs e)
        {
            frm_peoples fm = new frm_peoples();
            open_form(fm);
        }

        private void btnPension_Click(object sender, EventArgs e)
        {
            frm_peoples_pension fm = new frm_peoples_pension();
            open_form(fm);
        }
    }
}
