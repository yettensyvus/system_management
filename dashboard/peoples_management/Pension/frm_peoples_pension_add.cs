using dashboard.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace dashboard
{
    public partial class frm_peoples_pension_add : Form
    {
        DBConnection conn = new DBConnection();

        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vScrollHelper;


        public frm_peoples_pension_add()
        {
            InitializeComponent();
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

        private void add_plus_btn()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Resources.add_32px;
            img.Image = image;
            grid.Columns.Add(img);
            img.HeaderText = "ADD";
            img.Name = "ADD";
            this.grid.Columns["ADD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }


        private void grid_fill()
        {
            this.grid.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["NUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["DATE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["IDNP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns["ADD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.grid.Columns["ADD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }



        private void frm_peoples_pension_add_Load(object sender, EventArgs e)
        {
            vScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(grid, gunaVScrollBar1, true);

            add_plus_btn();
            peoples_data();
            grid_fill();
            vScrollHelper.UpdateScrollBar();
        }

        private void grid_Resize(object sender, EventArgs e)
        {
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
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

            int index = grid.Columns["ADD"].Index;

            if (e.ColumnIndex == index)
            {
                frm_peoples_pension_insert form = new frm_peoples_pension_insert();

                string id = grid.CurrentRow.Cells["IDNP"].Value.ToString();

                try
                {
                    string full_name = grid.CurrentRow.Cells["NUME"].Value.ToString();

                    string message = string.Format("Add Pension For People: {0}?", full_name);

                    if (CustomMessageBox.ShowMessage(message, "Confirm Add!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
    }
}
