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
    public partial class frm_user_info : Form
    {

        DBConnection conn = new DBConnection();

        public frm_user_info()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frm_alert.alertTypeEnum type)
        {
            frm_alert f = new frm_alert();
            f.setAlert(msg, type);
        }

        private void frm_user_info_Load(object sender, EventArgs e)
        {

            try
            {
                conn.ConnectionOpen();

                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand();

                command.CommandText = "SELECT username, password, secret_word FROM users WHERE username = '" + Program.UserName + "'";
                command.Connection = conn.connection;
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtUsername.Text = reader[0].ToString();
                    txtPassword.Text = AesCrypt.Decrypt(reader[1].ToString());
                    txtSecretW.Text = reader[2].ToString();
                }
                reader.Close();
                conn.ConnectionClose();
            }

            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                this.Alert("Please Enter Password", frm_alert.alertTypeEnum.Warning);
                txtPassword.Focus();
                return;
            }
            else if (txtSecretW.Text.Length < 5)
            {
                this.Alert("Minimum 5 Characters Long", frm_alert.alertTypeEnum.Info);
                txtPassword.Focus();
                return;
            }
            try
            {
                conn.ConnectionOpen();
                string sqlExpression = "UPDATE users SET username = '" + txtUsername.Text + "' , password = '" + AesCrypt.Encrypt(txtPassword.Text) + "' , secret_word = '" + txtSecretW.Text + "' WHERE username = '" + Program.UserName + "'";

                SqlCommand interogation = new SqlCommand(sqlExpression, conn.connection);
                SqlDataReader reader = interogation.ExecuteReader();

                Program.UserName = txtUsername.Text.ToString();

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
