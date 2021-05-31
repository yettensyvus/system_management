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
    public partial class frm_cote_harvest_insert : Form
    {
        DBConnection conn = new DBConnection();

        public string nr_pamant;
        public string year;

        public frm_cote_harvest_insert()
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

        private void frm_cote_harvest_insert_Load(object sender, EventArgs e)
        {
            txtKG.Text = txtKG.Text.Replace(",", ".");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtKG.Text.Length == 0)
            {
                this.Alert("Please Enter KG", frm_alert.alertTypeEnum.Warning);
                txtKG.Focus();
                return;
            }

            try
            {
                conn.ConnectionOpen();

                txtKG.Text = txtKG.Text.Replace(",", ".");

                string sqlExpression = " INSERT INTO cote_recolta(id_semanat, tone_recolta)" +
                                       " VALUES((SELECT id_semanat FROM cote_semanat WHERE an_semanat = " + year +
                                       " AND id_cote = (SELECT id_cote FROM cote WHERE nr_pamant = " + nr_pamant +
                                       " )) , " + txtKG.Text + ");";

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
    }
}
