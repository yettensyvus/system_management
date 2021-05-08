using dashboard.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace dashboard
{
    public partial class frm_peoples_death_add : Form
    {
        DBConnection conn = new DBConnection();

        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vScrollHelper;

        public frm_peoples_death_add()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frm_alert.alertTypeEnum type)
        {
            frm_alert f = new frm_alert();
            f.setAlert(msg, type);
        }


        private void peoples_data()
        {
            try
            {
                conn.ConnectionOpen();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_peoples AS ID, full_name AS NUME, date_of_birth AS DATE, idnp AS IDNP FROM peoples", conn.connection);
                DataTable data = new DataTable();
                sda.Fill(data);
                grid.DataSource = data;
                conn.ConnectionClose();
                label1.Text = "RECORDS: " + grid.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                conn.ConnectionClose();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void add_remove_btn()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Resources.trash_32px;
            img.Image = image;
            grid.Columns.Add(img);
            img.HeaderText = "REMOVE";
            img.Name = "REMOVE";
            this.grid.Columns["REMOVE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }


        private void grid_fill()
        {
            this.grid.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["NUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["DATE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["IDNP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns["REMOVE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.grid.Columns["REMOVE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void frm_peoples_death_add_Load(object sender, EventArgs e)
        {
            vScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(grid, gunaVScrollBar1, true);

            peoples_data();
            add_remove_btn();
            grid_fill();
            vScrollHelper.UpdateScrollBar();
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            try
            {
                (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("NUME LIKE '%{0}%' OR IDNP LIKE '%{0}%'", txtSearch.Text);
                label1.Text = "RECORDS: " + grid.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row Headers

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            int index = grid.Columns["REMOVE"].Index;

            if (e.ColumnIndex == index)
            {
                frm_peoples_death_insert form = new frm_peoples_death_insert();

                string id = grid.CurrentRow.Cells["ID"].Value.ToString();

                try
                {
                    string full_name = grid.CurrentRow.Cells["NUME"].Value.ToString();

                    string message = string.Format("This People: {0}, is Dead?", full_name);

                    if (CustomMessageBox.ShowMessage(message, "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        form.id = id;
                        form.ShowDialog();
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            peoples_data();
        }

        private void grid_Resize(object sender, EventArgs e)
        {
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }
    }
}
