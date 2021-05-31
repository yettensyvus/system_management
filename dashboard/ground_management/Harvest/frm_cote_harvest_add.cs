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
    public partial class frm_cote_harvest_add : Form
    {
        DBConnection conn = new DBConnection();

        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vScrollHelper;

        public frm_cote_harvest_add()
        {
            InitializeComponent();
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


        private void all_data()
        {
            try
            {
                conn.ConnectionOpen();
                string query = "SELECT cote_semanat.id_semanat AS ID, cote.nr_pamant AS NR_PAMANT, cote.suprafata_h AS SUPRAFATA, cote_semanat.an_semanat AS AN_SEMANAT, cote_semanat.tip_planta AS PLANTA " +
                               "FROM cote INNER JOIN " +
                               "cote_semanat ON cote.id_cote = cote_semanat.id_cote " +
                               "ORDER BY cote_semanat.id_semanat";

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

        private void grid_fill()
        {
            this.grid.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["NR_PAMANT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["SUPRAFATA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["AN_SEMANAT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["PLANTA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns["ADD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.grid.Columns["ADD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void frm_cote_harvest_add_Load(object sender, EventArgs e)
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
                (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(NR_PAMANT, 'System.String') LIKE '%{0}%'", txtSearch.Text);
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
                frm_cote_harvest_insert form = new frm_cote_harvest_insert();

                string nr_pamant = grid.CurrentRow.Cells["NR_PAMANT"].Value.ToString();
                string year = grid.CurrentRow.Cells["AN_SEMANAT"].Value.ToString();

                try
                {

                    string message = string.Format("Add harvest for this quota: {0}?", nr_pamant);

                    if (CustomMessageBox.ShowMessage(message, "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        form.nr_pamant = nr_pamant;
                        form.year = year;
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
