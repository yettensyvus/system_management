using dashboard.Class;
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
        }
        #endregion

        #region control_events
        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Please Enter Username", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                txtUsername.Focus();
                return;
            }
            else if (txtUsername.Text.Length < 5)
            {
                Bunifu.Snackbar.Show(this, "Minimum 5 Characters Long", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                txtUsername.Focus();
                return;
            }


            if (txtPassword.Text.Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Please Enter Password", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                txtPassword.Focus();
                return;
            }
            else if (txtPassword.Text.Length < 5)
            {
                Bunifu.Snackbar.Show(this, "Minimum 5 Characters Long", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                txtPassword.Focus();
                return;
            }


            if (txtSecretW.Text.Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Please Enter Secret Word", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                txtSecretW.Focus();
                return;
            }
            else if (txtSecretW.Text.Length < 5)
            {
                Bunifu.Snackbar.Show(this, "Minimum 5 Characters Long", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
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

                Bunifu.Snackbar.Show(this, "SUCCESS!", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
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