﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.DataViz.WinForms;

namespace dashboard
{
    public partial class frm_peoples_graph : Form
    {
        DBConnection conn = new DBConnection();

        int peoples_total = 0;
        int deces_total = 0;

        public frm_peoples_graph()
        {
            InitializeComponent();
        }

        //form load 
        private void open_form(object form)
        {
            if (this.panel_Child.Controls.Count > 0)
                this.panel_Child.Controls.Clear();
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel_Child.Controls.Add(fh);
            this.panel_Child.Tag = fh;
            fh.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frm_peoples_management fm = new frm_peoples_management();
            open_form(fm);
        }

        private void frm_peoples_graph_Load(object sender, EventArgs e)
        {
            death_table();
        }

        private void peoples_count()
        {
            try
            {
                conn.ConnectionOpen();

                string query = "SELECT COUNT(id_peoples) AS total FROM peoples";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn.connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                peoples_total = Int32.Parse(dtbl.Rows[0]["total"].ToString());

                conn.ConnectionClose();
            }
            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
                conn.ConnectionOpen();

                string query = "SELECT COUNT(id_deces) AS total FROM peoples_deces";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn.connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                deces_total = Int32.Parse(dtbl.Rows[0]["total"].ToString());

                conn.ConnectionClose();
            }
            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void death_table()
        {
          
            peoples_count();


            //lets get a canvas to paint graphs on
            Canvas Charts = new Canvas();

            //graph dataPoint
            DataPoint graph = new DataPoint(BunifuDataViz._type.Bunifu_splineArea);

            try
            {
                conn.ConnectionOpen();

                string query = "SELECT COUNT(id_deces) AS TOTAL, DATEPART(yyyy, date_of_death) AS YEAR FROM peoples_deces GROUP BY DATEPART(yyyy, date_of_death) ORDER BY YEAR";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn.connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    //sample data for datapoint
                    graph.addLabely(dtbl.Rows[i]["YEAR"].ToString(), dtbl.Rows[i]["TOTAL"].ToString());
                }

                //add datapoints to one canvas
                Charts.addData(graph);

                //render canvas through bunifu dataviz component.
                dataViz.Render(Charts);

                conn.ConnectionClose();

            }
            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            label_name.Text = "NUMĂRUL DECESELOR DUPĂ ANI";

            label_1.Text = "TOTAL";
            progress_1.Value = peoples_total;
            label_num_1.Text = progress_1.Value.ToString();
            //round_1.Value = 15000 - ((deces_total * 100) / (peoples_total + deces_total));

            label_2.Text = "DECES";
            progress_2.Value = deces_total;
            label_num_2.Text = progress_2.Value.ToString();
            //round_2.Value = ((deces_total * 100) / (peoples_total + deces_total));
        }


        private void sick_table_category()
        {
            peoples_count();

            int bolnavi = 0;

            //lets get a canvas to paint graphs on
            Canvas Charts = new Canvas();

            //graph dataPoint
            DataPoint graph = new DataPoint(BunifuDataViz._type.Bunifu_stackedColumn);

            try
            {
                conn.ConnectionOpen();

                string query = "SELECT tip_evidenta AS TIP, COUNT(id_bolnav) AS TOTAL FROM peoples_bolnav GROUP BY tip_evidenta";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn.connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    //sample data for datapoint
                    graph.addLabely(dtbl.Rows[i]["TIP"].ToString(), dtbl.Rows[i]["TOTAL"].ToString());

                    //calculam numarul total de bolnavi
                    bolnavi += Int32.Parse(dtbl.Rows[i]["TOTAL"].ToString());
                }

                //add datapoints to one canvas
                Charts.addData(graph);

                //render canvas through bunifu dataviz component.
                dataViz.Render(Charts);

                conn.ConnectionClose();

            }
            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //total bolnavi

            label_name.Text = "NUMĂRUL BOLNAVILOR DUPĂ CATEGORIE";

            label_1.Text = "TOTAL";
            progress_1.Value = peoples_total;
            label_num_1.Text = progress_1.Value.ToString();
            //round_1.Value = 15000 - ((bolnavi * 100) / (peoples_total + bolnavi));

            label_2.Text = "BOLNAVI";
            progress_2.Value = bolnavi;
            label_num_2.Text = progress_2.Value.ToString();
            //round_2.Value = ((bolnavi * 100) / (peoples_total + bolnavi));

        }

        private void sick_table_malady()
        {
            peoples_count();

            int bolnavi = 0;

            //lets get a canvas to paint graphs on
            Canvas Charts = new Canvas();

            //graph dataPoint
            DataPoint graph = new DataPoint(BunifuDataViz._type.Bunifu_stackedBar);

            try
            {
                conn.ConnectionOpen();

                string query = "SELECT diagnoza AS DIAGNOZ, COUNT(id_bolnav) AS TOTAL FROM peoples_bolnav GROUP BY diagnoza";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn.connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    //sample data for datapoint
                    graph.addLabely(dtbl.Rows[i]["DIAGNOZ"].ToString(), dtbl.Rows[i]["TOTAL"].ToString());

                    //calculam numarul total de bolnavi
                    bolnavi += Int32.Parse(dtbl.Rows[i]["TOTAL"].ToString());
                }

                //add datapoints to one canvas
                Charts.addData(graph);

                //render canvas through bunifu dataviz component.
                dataViz.Render(Charts);

                conn.ConnectionClose();

            }
            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //total bolnavi

            label_name.Text = "NUMĂRUL BOLNAVILOR DUPĂ DIAGNOZĂ";

            label_1.Text = "TOTAL";
            progress_1.Value = peoples_total;
            label_num_1.Text = progress_1.Value.ToString();
            //round_1.Value = 15000 - ((bolnavi * 100) / (peoples_total + bolnavi));

            label_2.Text = "BOLNAVI";
            progress_2.Value = bolnavi;
            label_num_2.Text = progress_2.Value.ToString();
            //round_2.Value = ((bolnavi * 100) / (peoples_total + bolnavi));
        }


        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbList.Text == "DEATH")
            {
                death_table();
            }
            else if (cmbList.Text == "SICK BY CATEGORY")
            {
                sick_table_category();
            }
            else if (cmbList.Text == "SICK BY MALADY")
            {
                sick_table_malady();
            }
        }
    }
}
