using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_peoples_pension_insert : Form
    {
        DBConnection conn = new DBConnection();

        public string id;

        public frm_peoples_pension_insert()
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
                string sqlExpression = "INSERT INTO peoples_pension(id_peoples, pensie_numerar) VALUES ((SELECT id_peoples FROM peoples WHERE idnp = '" + id + "') , '" + txtMoney.Text + "')";

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
