using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using dashboard.Class;
using dashboard.custom_controls;
using dashboard.Properties;

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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_peoples AS ID, f_name AS NUME, l_name AS PRENUME, patronymic AS PATRONIMIC, date_of_birth AS DATA, idnp AS IDNP FROM peoples", conn.connection);
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
            grid.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };
        }

        #endregion

        #region control_events

        private void frm_peoples_Load(object sender, EventArgs e)
        {
            vScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(grid, gunaVScrollBar1, true);

            all_data();
            add_edit_btn();
            add_delete_btn();
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

            if (e.ColumnIndex == 0)
            {
                frm_peoples_edit form = new frm_peoples_edit();
                try
                {
                    string fname = grid.CurrentRow.Cells["NUME"].Value.ToString();
                    string lname = grid.CurrentRow.Cells["PRENUME"].Value.ToString();
                    string full_name = fname + " " + lname;

                    string messege = string.Format("Edit People {0}", full_name);
                    if (MessageBox.Show(messege, "Confirm Edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //form.txtIDPeople.Text = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        //form.txtFullname.Text = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                        //form.txtIDNP.Text = grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        //form.ShowDialog();
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == 1)
            {
                int id = int.Parse(grid.CurrentRow.Cells["ID"].Value.ToString());

                try
                {
                    string fname = grid.CurrentRow.Cells["NUME"].Value.ToString();
                    string lname = grid.CurrentRow.Cells["PRENUME"].Value.ToString();
                    string full_name = fname + " " + lname;

                    string messege = string.Format("Remove People {0}", full_name);
                    if (MessageBox.Show(messege, "Confirm Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
        #endregion

    }
}
