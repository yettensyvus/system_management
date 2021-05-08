using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_peoples_add : Form
    {
        DBConnection conn = new DBConnection();

        public frm_peoples_add()
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
            if (txtFullName.Text.Length == 0)
            {
                this.Alert("Please Enter Name", frm_alert.alertTypeEnum.Warning);
                txtFullName.Focus();
                return;
            }
            else if (txtFullName.Text.Length < 5)
            {
                this.Alert("Minimum 5 Characters Long", frm_alert.alertTypeEnum.Info);
                txtFullName.Focus();
                return;
            }

            if (txtIDNP.Text.Length == 0)
            {
                this.Alert("Please Enter IDNP", frm_alert.alertTypeEnum.Warning);
                txtIDNP.Focus();
                return;
            }
            else if (txtIDNP.Text.Length < 13)
            {
                this.Alert("13 Characters Long", frm_alert.alertTypeEnum.Info);
                txtIDNP.Focus();
                return;
            }

            try
            {
                conn.ConnectionOpen();
                string sqlExpression = "INSERT INTO peoples (full_name, date_of_birth, idnp) VALUES (N'" + txtFullName.Text + "' , '" + date_of_birth.Value.ToString("yyyy/MM/dd") + "' , '" + txtIDNP.Text + "')";

                SqlCommand interogation = new SqlCommand(sqlExpression, conn.connection);
                SqlDataReader reader = interogation.ExecuteReader();

                reader.Close();
                conn.ConnectionClose();

                this.Alert("SUCCESS!", frm_alert.alertTypeEnum.Success);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
