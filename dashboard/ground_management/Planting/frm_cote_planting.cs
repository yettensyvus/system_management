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
    public partial class frm_cote_planting : Form
    {
        #region main
        DBConnection conn = new DBConnection();

        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vScrollHelper;

        public frm_cote_planting()
        {
            InitializeComponent();
            DoubleBuffering.SetDoubleBuffering(this, true);
        }
        #endregion

        #region methodes
        public void Alert(string msg, frm_alert.alertTypeEnum type)
        {
            frm_alert f = new frm_alert();
            f.setAlert(msg, type);
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

        private void add_edit_btn()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Resources.pencil_30px;
            img.Image = image;
            grid.Columns.Add(img);
            img.HeaderText = "EDIT";
            img.Name = "EDIT";
            this.grid.Columns["EDIT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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
            this.grid.Columns["EDIT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.grid.Columns["EDIT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void copyAlltoClipboard()
        {
            grid.SelectAll();
            DataObject dataObj = grid.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        #endregion

        #region control_events

        private void frm_cote_planting_Load(object sender, EventArgs e)
        {
            vScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(grid, gunaVScrollBar1, true);

            add_edit_btn();
            all_data();
            grid_fill();

            vScrollHelper.UpdateScrollBar();

        }

        private void grid_Resize(object sender, EventArgs e)
        {
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row Headers

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            int index = grid.Columns["EDIT"].Index;

            if (e.ColumnIndex == index)
            {
                frm_cote_planting_upd form = new frm_cote_planting_upd();

                int id = int.Parse(grid.CurrentRow.Cells["ID"].Value.ToString());

                try
                {
                    string nr_pamant = grid.CurrentRow.Cells["NR_PAMANT"].Value.ToString();

                    string message = string.Format("Edit quota data: {0}?", nr_pamant);

                    if (CustomMessageBox.ShowMessage(message, "Confirm Edit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        form.id = id;

                        form.txtAn.Text = grid.Rows[e.RowIndex].Cells["AN_SEMANAT"].Value.ToString();
                        form.txtPlant.Text = grid.Rows[e.RowIndex].Cells["PLANTA"].Value.ToString();
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


        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            all_data();
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_cote_planting_add form = new frm_cote_planting_add();
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frm_ground_management fm = new frm_ground_management();
            open_form(fm);
        }

    }
}
