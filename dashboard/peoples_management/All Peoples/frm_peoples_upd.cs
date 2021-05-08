using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_peoples_edit : Form
    {


        DBConnection conn = new DBConnection();

        public int id;

        public frm_peoples_edit()
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

        private void btnUpdate_Click(object sender, EventArgs e)
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
                string sqlExpression = "UPDATE peoples SET full_name = N'" + txtFullName.Text + "' , date_of_birth = '" + date_of_birth.Value.ToString("yyyy/MM/dd") + "' , idnp = '" + txtIDNP.Text + "' WHERE id_peoples = " + id;

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
    }
}
