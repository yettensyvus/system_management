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
    public partial class frm_cote_insert : Form
    {
        DBConnection conn = new DBConnection();

        public string idnp;

        public frm_cote_insert()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
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

                string sqlExpression = "INSERT INTO cote(id_peoples, nr_pamant, suprafata_h)" +
                                        "VALUES ((SELECT id_peoples FROM peoples WHERE idnp = '" + idnp + "') , " + txtGroundNumber.Text+ " , " + txtArea.Text + ");";

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
