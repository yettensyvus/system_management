using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_register : Form
    {

        #region main
        DBConnection conn = new DBConnection();

        public frm_register()
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

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Length == 0)
            {
                this.Alert("Please Enter Username", frm_alert.alertTypeEnum.Warning);
                txtUsername.Focus();
                return;
            }
            else if (txtUsername.Text.Length < 5)
            {
                this.Alert("Minimum 5 Characters Long", frm_alert.alertTypeEnum.Info);
                txtUsername.Focus();
                return;
            }


            if (txtPassword.Text.Length == 0)
            {
                this.Alert("Please Enter Password", frm_alert.alertTypeEnum.Warning);
                txtPassword.Focus();
                return;
            }
            else if (txtPassword.Text.Length < 5)
            {
                this.Alert("Minimum 5 Characters Long", frm_alert.alertTypeEnum.Info);
                txtPassword.Focus();
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
                string sqlExpression = "INSERT INTO users (username, password, secret_word) VALUES('" + txtUsername.Text + "' , '" + AesCrypt.Encrypt(txtPassword.Text) + "' , '" + txtSecretW.Text + "');";

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
            this.Dispose();
            frm_login obj = new frm_login();
            obj.Show();
        }
        #endregion


    }
}