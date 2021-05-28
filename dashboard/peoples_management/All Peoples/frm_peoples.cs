using dashboard.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace dashboard
{

    public partial class frm_peoples : Form
    {
        #region main
        DBConnection conn = new DBConnection();

        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vScrollHelper;

        public frm_peoples()
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

        private void add_delete_btn()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Resources.trash_32px;
            img.Image = image;
            grid.Columns.Add(img);
            img.HeaderText = "DELETE";
            img.Name = "DELETE";
            this.grid.Columns["DELETE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void all_data()
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

        private void grid_fill()
        {
            this.grid.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["NUME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["DATE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["IDNP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.grid.Columns["EDIT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.grid.Columns["DELETE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.grid.Columns["EDIT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grid.Columns["DELETE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void frm_peoples_Load(object sender, EventArgs e)
        {
            vScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(grid, gunaVScrollBar1, true);

            add_delete_btn();
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
            int indexx = grid.Columns["DELETE"].Index;

            if (e.ColumnIndex == index)
            {
                frm_peoples_edit form = new frm_peoples_edit();

                int id = int.Parse(grid.CurrentRow.Cells["ID"].Value.ToString());

                try
                {
                    string full_name = grid.CurrentRow.Cells["NUME"].Value.ToString();

                    string message = string.Format("Edit People: {0}?", full_name);

                    if (CustomMessageBox.ShowMessage(message, "Confirm Edit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        form.id = id;

                        form.txtFullName.Text = grid.Rows[e.RowIndex].Cells["NUME"].Value.ToString();
                        form.date_of_birth.Value = Convert.ToDateTime(grid.Rows[e.RowIndex].Cells["DATE"].Value.ToString());
                        form.txtIDNP.Text = grid.Rows[e.RowIndex].Cells["IDNP"].Value.ToString();
                        form.ShowDialog();
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == indexx)
            {
                int id = int.Parse(grid.CurrentRow.Cells["ID"].Value.ToString());

                try
                {
                    string full_name = grid.CurrentRow.Cells["NUME"].Value.ToString();

                    string message = string.Format("Remove People: {0}?", full_name);

                    if (CustomMessageBox.ShowMessage(message, "Confirm Remove!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.ConnectionOpen();
                        string sqlExpression = "DELETE FROM peoples WHERE id_peoples = " + id;

                        SqlCommand interogation = new SqlCommand(sqlExpression, conn.connection);
                        SqlDataReader reader = interogation.ExecuteReader();

                        reader.Close();
                        conn.ConnectionClose();

                        this.Alert("SUCCESS!", frm_alert.alertTypeEnum.Success);

                        all_data();
                        label1.Text = "RECORDS: " + grid.Rows.Count.ToString();
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
                (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("NUME LIKE '%{0}%' OR IDNP LIKE '%{0}%'", txtSearch.Text);
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
            frm_peoples_add form = new frm_peoples_add();
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frm_peoples_management fm = new frm_peoples_management();
            open_form(fm);
        }

    }
}
