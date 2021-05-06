using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_pass_forgot : Form
    {

        #region main
        DBConnection conn = new DBConnection();
        frm_your_password form = new frm_your_password();

        public frm_pass_forgot()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #endregion

        #region control_events

        public void Alert(string msg, frm_alert.alertTypeEnum type)
        {
            frm_alert f = new frm_alert();
            f.setAlert(msg, type);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                this.Alert("Please Enter Username", frm_alert.alertTypeEnum.Warning);
                txtName.Focus();
                return;
            }
            else if (txtName.Text.Length < 5)
            {
                this.Alert("Minimum 5 Characters Long", frm_alert.alertTypeEnum.Info);
                txtName.Focus();
                return;
            }

            if (txtSecretW.Text.Length == 0)
            {
                this.Alert("Please Enter Secret Word", frm_alert.alertTypeEnum.Warning);
                txtSecretW.Focus();
                return;
            }
            else if (txtSecretW.Text.Length < 5)
            {
                this.Alert("Minimum 5 Characters Long", frm_alert.alertTypeEnum.Info);
                txtSecretW.Focus();
                return;
            }

            try
            {
                conn.ConnectionOpen();

                string query = "SELECT password FROM users WHERE username = '" + txtName.Text.Trim() + "' AND secret_word = '" + txtSecretW.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn.connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {

                    form.txtPass.Text = AesCrypt.Decrypt(dtbl.Rows[0]["password"].ToString());
                    this.Hide();
                    form.ShowDialog();

                }
                else
                {
                    this.Alert("Invalid Credentials", frm_alert.alertTypeEnum.Error);
                }
                conn.ConnectionClose();
            }

            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm_login obj = new frm_login();
            obj.Show();
        }

        #endregion

        
    }
}
