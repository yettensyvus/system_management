using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_peoples_pension_upd : Form
    {
        DBConnection conn = new DBConnection();

        public string id;

        public frm_peoples_pension_upd()
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
            if (txtMoney.Text.Length == 0)
            {
                this.Alert("Please Enter Money", frm_alert.alertTypeEnum.Warning);
                txtMoney.Focus();
                return;
            }
            try
            {
                conn.ConnectionOpen();
                string sqlExpression = "UPDATE peoples_pension SET pensie_numerar = '" + txtMoney.Text + "' WHERE id_pensionar = " + id;

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
