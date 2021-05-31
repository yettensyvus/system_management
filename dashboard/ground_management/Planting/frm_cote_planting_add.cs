using dashboard.Properties;
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
    public partial class frm_cote_planting_add : Form
    {
        DBConnection conn = new DBConnection();

        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vScrollHelper;

        public frm_cote_planting_add()
        {
            InitializeComponent();
        }

        public void Alert(string msg, frm_alert.alertTypeEnum type)
        {
            frm_alert f = new frm_alert();
            f.setAlert(msg, type);
        }


        private void all_data()
        {
            try
            {
                conn.ConnectionOpen();
                string query = "SELECT cote.id_cote AS ID, peoples.full_name AS NUME, peoples.idnp AS IDNP, cote.nr_pamant AS NR_PAMANT, cote.suprafata_h AS SUPRAFATA " +
                               "FROM cote INNER JOIN " +
                               "peoples ON cote.id_peoples = peoples.id_peoples " +
                               "ORDER BY cote.id_cote";

                SqlDataAdapter sda = new SqlDataAdapter(query, conn.connection);
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

        private void add_add_btn()
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
            this.grid.Columns["IDNP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["NR_PAMANT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["SUPRAFATA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns["ADD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.grid.Columns["ADD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void frm_cote_planting_add_Load(object sender, EventArgs e)
        {
            vScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(grid, gunaVScrollBar1, true);
            add_add_btn();
            all_data();
            grid_fill();
            vScrollHelper.UpdateScrollBar();
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            try
            {
                (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("NUME LIKE '%{0}%' OR IDNP LIKE '%{0}%' OR Convert(NR_PAMANT, 'System.String') LIKE '%{0}%'", txtSearch.Text);
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
                frm_cote_planting_insert form = new frm_cote_planting_insert();

                string id = grid.CurrentRow.Cells["NR_PAMANT"].Value.ToString();

                try
                {
                    string nr_pamant = grid.CurrentRow.Cells["NR_PAMANT"].Value.ToString();

                    string message = string.Format("Planting in this quota: {0}?", nr_pamant);

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

        private void grid_Resize(object sender, EventArgs e)
        {
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }
    }
}
