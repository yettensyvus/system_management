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
    public partial class frm_cote_upd : Form
    {
        DBConnection conn = new DBConnection();

        public int id;

        public frm_cote_upd()
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

        private void frm_cote_upd_Load(object sender, EventArgs e)
        {
            txtArea.Text = txtArea.Text.Replace(",", ".");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIDPeople.Text.Length == 0)
            {
                this.Alert("Please Enter People ID", frm_alert.alertTypeEnum.Warning);
                txtIDPeople.Focus();
                return;
            }
            else if (txtIDPeople.Text.Length < 3)
            {
                this.Alert("Minimum 3 Characters Long", frm_alert.alertTypeEnum.Info);
                txtIDPeople.Focus();
                return;
            }

            if (txtGroundNumber.Text.Length == 0)
            {
                this.Alert("Please Enter Ground Number", frm_alert.alertTypeEnum.Warning);
                txtGroundNumber.Focus();
                return;
            }
            else if (txtGroundNumber.Text.Length < 6)
            {
                this.Alert("6 Characters Long", frm_alert.alertTypeEnum.Info);
                txtGroundNumber.Focus();
                return;
            }

            if (txtArea.Text.Length == 0)
            {
                this.Alert("Please Enter Area", frm_alert.alertTypeEnum.Warning);
                txtArea.Focus();
                return;
            }
            else if (txtArea.Text.Length < 2)
            {
                this.Alert("2 Characters Long", frm_alert.alertTypeEnum.Info);
                txtArea.Focus();
                return;
            }

            try
            {
                conn.ConnectionOpen();

                txtArea.Text = txtArea.Text.Replace(",", ".");

                string sqlExpression = "UPDATE cote SET id_peoples = " + txtIDPeople.Text + " , nr_pamant = " + txtGroundNumber.Text + " , suprafata_h = '" + txtArea.Text + "' WHERE id_cote = " + id;

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
