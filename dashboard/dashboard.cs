using System;
using System.Drawing;
using System.Windows.Forms;

namespace dashboard
{


    public partial class dashboard : Form
    {
        #region main
        public dashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            hideSubMenu();
        }
        #endregion

        #region methodes

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


        private void btn_clear()
        {
            pictureBox1.Hide();
            label1.Hide();
        }

        private void btn_text()
        {
            pictureBox1.Show();
            label1.Show();
        }


        //max, min and normal form state

        int lx, ly;
        int sw, sh;
        private void max_size()
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMax.Visible = false;
            btnNormal.Visible = true;
        }

        private void normal_size()
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMax.Visible = true;
        }

        private void min_size()
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void hideSubMenu()
        {
            panelManagementSub.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

        #region control_events
        //buttons click events

        //toggle menu drawer click
        private void btnToggleDrawer_Click(object sender, EventArgs e)
        {

            if (pnlDrawer.Width == 200)
            {
                //Drawer Close
                pnlDrawer.Width = 50;
                panelToggle.BackColor = Color.FromArgb(10, 10, 10);
                btn_clear();

            }
            else
            {
                //Drawer Open
                pnlDrawer.Width = 200;
                panelToggle.BackColor = Color.FromArgb(32, 32, 36);
                btn_text();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            max_size();
        }


        private void btnNormal_Click(object sender, EventArgs e)
        {
            normal_size();
        }


        private void btnMin_Click(object sender, EventArgs e)
        {
            min_size();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panelManagementSub);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            frm_user_info fm = new frm_user_info();
            open_form(fm);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            frm_about fm = new frm_about();
            open_form(fm);
        }

        private void btnPeoples_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            frm_peoples_management fm = new frm_peoples_management();
            open_form(fm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.ShowMessage("Do you want to logout?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frm_login fm = new frm_login();
                fm.Show();
            }
        }


        //exit
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.ShowMessage("Do you want to exit?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        #endregion
    }
}
