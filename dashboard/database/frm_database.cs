using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_database : Form
    {

        #region main

        SqlConnection conn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = master; Integrated Security = True");


        public frm_database()
        {
            InitializeComponent();
        }

    #endregion

        #region methodes
        public string get_path;

        private void get_file()
        {
            OpenFileDialog OpenFile = new OpenFileDialog();

            try
            {
                OpenFile.FileName = "";
                OpenFile.Title = "Database:";
                OpenFile.Filter = "Database files: (*.sql)|*.sql|(*.txt)|*.txt";
                DialogResult res = OpenFile.ShowDialog();

                if (res == DialogResult.OK)
                {
                    get_path = Path.GetFullPath(OpenFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void db_from_file()
        {
            try
            {
                conn.Open();

                string script = File.ReadAllText(get_path);
                // split script on GO command
                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                foreach (string commandString in commandStrings)
                {
                    if (!string.IsNullOrWhiteSpace(commandString.Trim()))
                    {
                        using (var command = new SqlCommand(commandString, conn))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }

                Bunifu.Snackbar.Show(this, "SUCCESS!", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                get_path = null;
            }
        }

        private void db_from_root()
        {
            try
            {
                string script = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Database/tables.sql");

                // split script on GO command
                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);


                conn.Open();

                foreach (string commandString in commandStrings)
                {
                    if (!string.IsNullOrWhiteSpace(commandString.Trim()))
                    {
                        using (var command = new SqlCommand(commandString, conn))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }

                Bunifu.Snackbar.Show(this, "SUCCESS!", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region control_events

        private void frm_database_Load(object sender, EventArgs e)
        {
            btnServerList.Clear();
            btnServerList.AddItem(Environment.MachineName);
            btnServerList.AddItem(@".\SQLEXPRESS");
            btnServerList.AddItem(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            btnServerList.selectedIndex = 2;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            get_file();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if(get_path == null)
            {
                db_from_root();
            }
            else
            {
                db_from_file();
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_login form = new frm_login();
            form.Show();
        }

        #endregion
    }
}
