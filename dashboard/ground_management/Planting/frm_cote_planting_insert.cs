﻿using System;
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
    public partial class frm_cote_planting_insert : Form
    {
        DBConnection conn = new DBConnection();

        public string id;

        public frm_cote_planting_insert()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAn.Text.Length == 0)
            {
                this.Alert("Please Select the Year", frm_alert.alertTypeEnum.Warning);
                txtAn.Focus();
                return;
            }

            if (txtPlant.Text.Length == 0)
            {
                this.Alert("Please Select the Plant", frm_alert.alertTypeEnum.Warning);
                txtPlant.Focus();
                return;
            }

            try
            {
                conn.ConnectionOpen();

                string sqlExpression = "INSERT INTO cote_semanat(id_cote, an_semanat, tip_planta) " +
                                       "VALUES ((SELECT id_cote FROM cote WHERE nr_pamant = " + id + ") ," + txtAn.Text + ", N'" + txtPlant.Text + "');";

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
