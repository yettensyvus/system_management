using dashboard.Class;
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
        }

        #endregion

        #region control_events

        private void frm_pass_forgot_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            DoubleBuffering.SetDoubleBuffering(label_form_name, true);
            DoubleBuffering.SetDoubleBuffering(pnlHeader, true);
            DoubleBuffering.SetDoubleBuffering(btnClose, true);
            DoubleBuffering.SetDoubleBuffering(label2, true);
            DoubleBuffering.SetDoubleBuffering(label3, true);
            DoubleBuffering.SetDoubleBuffering(txtName, true);
            DoubleBuffering.SetDoubleBuffering(txtSecretW, true);
            DoubleBuffering.SetDoubleBuffering(btnRestore, true);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Please Enter Username", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                txtName.Focus();
                return;
            }
            else if (txtName.Text.Length < 5)
            {
                Bunifu.Snackbar.Show(this, "Minimum 5 Characters Long", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                txtName.Focus();
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
                    Bunifu.Snackbar.Show(this, "Invalid Credentials", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
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
