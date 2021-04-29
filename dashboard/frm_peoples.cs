using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace dashboard
{

    public partial class frm_peoples : Form
    {
        public frm_peoples()
        {
            InitializeComponent();
        }


        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vScrollHelper;

        private void add_edit_btn()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Image.FromFile(@"C:\Users\Alex\Desktop\icons\pencil_30px.png");
            img.Image = image;
            grid.Columns.Add(img);
            img.HeaderText = "EDIT";
            img.Name = "EDIT";
            this.grid.Columns["EDIT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void add_delete_btn()
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Image.FromFile(@"C:\Users\Alex\Desktop\icons\trash_32px.png");
            img.Image = image;
            grid.Columns.Add(img);
            img.HeaderText = "DELETE";
            img.Name = "DELETE";
            this.grid.Columns["DELETE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void frm_peoples_Load(object sender, EventArgs e)
        {

            vScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(grid, gunaVScrollBar1, true);


            Random r = new Random();
            for (int i = 0; i <= 40; i++)
            {
                grid.Rows.Add(new object[] { i, r.Next(200000, 500000), r.Next(200000, 500000), r.Next(200000, 500000), r.Next(200000, 500000) });
            }
            vScrollHelper.UpdateScrollBar();

            add_edit_btn();
            add_delete_btn();
        }

        private void grid_Resize(object sender, EventArgs e)
        {
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 6)
            {
                try
                {
                    string messege = string.Format("Remove People {0}", grid.CurrentRow.Cells[0].Value.ToString());
                    if (MessageBox.Show(messege, "Confirm Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in this.grid.SelectedRows)
                        {
                            grid.Rows.RemoveAt(item.Index);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == 5)
            {
                frm_peoples_edit form = new frm_peoples_edit();
                try
                {
                    string messege = string.Format("Edit People {0}", grid.CurrentRow.Cells[0].Value.ToString());
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
        }


        private void GunaButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
