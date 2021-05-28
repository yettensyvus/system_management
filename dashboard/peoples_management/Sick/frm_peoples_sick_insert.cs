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
    public partial class frm_peoples_sick_insert : Form
    {

        DBConnection conn = new DBConnection();

        public string id;

        public frm_peoples_sick_insert()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frm_alert.alertTypeEnum type)
        {
            frm_alert f = new frm_alert();
            f.setAlert(msg, type);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDiagnoz.Text.Length == 0)
            {
                this.Alert("Please Enter Diagnoz", frm_alert.alertTypeEnum.Warning);
                txtDiagnoz.Focus();
                return;
            }

            try
            {
                conn.ConnectionOpen();
                string sqlExpression = "INSERT INTO peoples_bolnav(id_peoples, tip_evidenta, diagnoza) VALUES  ((SELECT id_peoples FROM peoples WHERE idnp = '" + id + "')  , N'" + cmbList.Text + "' , N'" + txtDiagnoz.Text + "');";

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
