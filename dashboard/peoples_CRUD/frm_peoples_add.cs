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
