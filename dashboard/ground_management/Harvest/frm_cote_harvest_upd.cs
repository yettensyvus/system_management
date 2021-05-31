using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_cote_harvest_upd : Form
    {
        DBConnection conn = new DBConnection();

        public string id;

        public frm_cote_harvest_upd()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frm_alert.alertTypeEnum type)
        {
            frm_alert f = new frm_alert();
            f.setAlert(msg, type);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_cote_harvest_upd_Load(object sender, EventArgs e)
        {
            txtKG.Text = txtKG.Text.Replace(",", ".");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtKG.Text.Length == 0)
            {
                this.Alert("Please Enter KG", frm_alert.alertTypeEnum.Warning);
                txtKG.Focus();
                return;
            }

            try
            {
                conn.ConnectionOpen();

                txtKG.Text = txtKG.Text.Replace(",", ".");

                string sqlExpression = "UPDATE cote_recolta SET tone_recolta = " + txtKG.Text + " WHERE id_recolta = " + id;

                SqlCommand interogation = new SqlCommand(sqlExpression, conn.connection);
                SqlDataReader reader = interogation.ExecuteReader();

                reader.Close();
                conn.ConnectionClose();

                this.Alert("SUCCESS!", frm_alert.alertTypeEnum.Success);
            }
            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
