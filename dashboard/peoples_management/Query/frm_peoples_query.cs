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
    public partial class frm_peoples_query : Form
    {
        DBConnection conn = new DBConnection();

        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vScrollHelper;

        public frm_peoples_query()
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

        private void frm_peoples_query_Load(object sender, EventArgs e)
        {
            vScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(grid, gunaVScrollBar1, true);
            vScrollHelper.UpdateScrollBar();

            try
            { 

                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("QueryText");
                dataTable.Columns.Add("QueryDescription");

                dataTable.Rows.Add(new Object[] { "SELECT * FROM peoples ",
                "ALL PEOPLES" });

                dataTable.Rows.Add(new Object[] { "SELECT * FROM peoples_deces ",
                "ALL DECES" });

                cmbList.DataSource = dataTable;
                cmbList.ValueMember = dataTable.Columns[0].ColumnName;
                cmbList.DisplayMember = dataTable.Columns[1].ColumnName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grid_Resize(object sender, EventArgs e)
        {
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frm_peoples_management fm = new frm_peoples_management();
            open_form(fm);
        }

        private void cmbList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = cmbList.SelectedValue.ToString();

            try
            {
                conn.ConnectionOpen();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn.connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                grid.DataSource = dataTable;

                grid.Visible = true;

                label1.Text = "RECORDS: " + grid.Rows.Count.ToString();

                conn.ConnectionClose();
            }
            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
