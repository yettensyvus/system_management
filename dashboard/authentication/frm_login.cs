using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_login : Form
    {
        #region main
        DBConnection conn = new DBConnection();

        public frm_login()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            lbForgot.Hide();
        }

        public void Alert(string msg, frm_alert.alertTypeEnum type)
        {
            frm_alert f = new frm_alert();
            f.setAlert(msg, type);
        }

        #endregion

        #region control_events
        private void btnLogin_Click(object sender, EventArgs e)
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

            try
            {

                conn.ConnectionOpen();

                string query = "SELECT * FROM users WHERE username = '" + txtName.Text.Trim() + "' AND password = '" + AesCrypt.Encrypt(txtPassword.Text.Trim()) + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn.connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1 && txtName.Text == "admin")
                {
                    Program.FrmState = "Admin";
                    Program.UserName = txtName.Text.ToString();

                    this.Hide();
                    dashboard obj = new dashboard();
                    obj.Show();
                }
                else if (dtbl.Rows.Count == 1)
                {
                    Program.FrmState = "User";
                    Program.UserName = txtName.Text.ToString();

                    this.Hide();
                    dashboard obj = new dashboard();
                    obj.Show();
                }
                else
                {
                    this.Alert("Check your username and password", frm_alert.alertTypeEnum.Error);
                    lbForgot.Show();
                }
                conn.ConnectionClose();


            }

            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_database obj = new frm_database();
            obj.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_register obj = new frm_register();
            obj.Show();
        }

        private void lbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_pass_forgot obj = new frm_pass_forgot();
            obj.Show();
        }
        #endregion

        #region methodes
        private void input_check(object sender, KeyPressEventArgs e)
        {
            string NotAllowed = "~`@%^&+={[}]()!:,;'><?/|\\-#+";

            //Allowed letters numbers and ( _ $ * . )

            if (e.KeyChar != ControlChars.Back == true)
            {
                if (NotAllowed.IndexOf(e.KeyChar) == -1 == false)
                {
                    e.Handled = true;
                }
            }
        }

        #endregion


    }
}
