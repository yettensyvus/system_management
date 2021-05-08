using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_peoples_death_insert : Form
    {
        DBConnection conn = new DBConnection();

        public string id;

        public frm_peoples_death_insert()
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

                string begin = "BEGIN TRANSACTION;";
                string query1 = "INSERT INTO peoples_deces (full_name, date_of_birth, idnp, date_of_death) VALUES ((SELECT full_name FROM peoples WHERE id_peoples = " + id + " ), (SELECT date_of_birth FROM peoples WHERE id_peoples = " + id + " ), (SELECT idnp FROM peoples WHERE id_peoples = " + id + " ), ' " + date_of_death.Value.ToString("yyyy/MM/dd") + "');";
                string query2 = "DELETE FROM peoples WHERE id_peoples = " + id + ";";
                string query3 = "DELETE FROM peoples_pension WHERE id_peoples = " + id + ";";
                string query4 = "DELETE FROM peoples_bolnav WHERE id_peoples = " + id + ";";
                string commit = "COMMIT TRANSACTION;";

                string sqlExpression = begin + query1 + query2 + query3 + query4 + commit;

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
