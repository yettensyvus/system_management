using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_ground_management : Form
    {
        public frm_ground_management()
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

        private void btnCote_Click(object sender, EventArgs e)
        {
            frm_cote fm = new frm_cote();
            open_form(fm);
        }

        private void btnPlanting_Click(object sender, EventArgs e)
        {
            frm_cote_planting fm = new frm_cote_planting();
            open_form(fm);
        }

        private void btnHarvest_Click(object sender, EventArgs e)
        {
            frm_cote_harvest fm = new frm_cote_harvest();
            open_form(fm);
        }
    }
}
