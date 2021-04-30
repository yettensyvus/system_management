
namespace dashboard
{
    partial class frm_peoples
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_peoples));
            this.grid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.GunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportExcel = new Bunifu.Framework.UI.BunifuImageButton();
            this.GunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.GunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowCustomTheming = false;
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeight = 40;
            this.grid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.grid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.grid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.grid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.grid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.grid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.grid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.Name = null;
            this.grid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.grid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.grid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.grid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.grid.HeaderBgColor = System.Drawing.Color.Empty;
            this.grid.HeaderForeColor = System.Drawing.Color.White;
            this.grid.Location = new System.Drawing.Point(12, 136);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 40;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(691, 293);
            this.grid.TabIndex = 56;
            this.grid.TabStop = false;
            this.grid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            this.grid.Resize += new System.EventHandler(this.grid_Resize);
            // 
            // GunaTextBox1
            // 
            this.GunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.GunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.GunaTextBox1.BorderSize = 0;
            this.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.GunaTextBox1.FocusedForeColor = System.Drawing.Color.White;
            this.GunaTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.GunaTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.GunaTextBox1.Location = new System.Drawing.Point(12, 100);
            this.GunaTextBox1.Name = "GunaTextBox1";
            this.GunaTextBox1.PasswordChar = '\0';
            this.GunaTextBox1.SelectedText = "";
            this.GunaTextBox1.Size = new System.Drawing.Size(217, 30);
            this.GunaTextBox1.TabIndex = 2;
            this.GunaTextBox1.Text = "SEARCH ASSETS";
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(693, 136);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.Radius = 0;
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.DarkGray;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 292);
            this.gunaVScrollBar1.TabIndex = 58;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "RECORDS:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.Image = global::dashboard.Properties.Resources.microsoft_excel_96px;
            this.btnExportExcel.ImageActive = null;
            this.btnExportExcel.Location = new System.Drawing.Point(515, 100);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(31, 30);
            this.btnExportExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExportExcel.TabIndex = 65;
            this.btnExportExcel.TabStop = false;
            this.btnExportExcel.Zoom = 10;
            // 
            // GunaButton1
            // 
            this.GunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaButton1.AnimationHoverSpeed = 0.07F;
            this.GunaButton1.AnimationSpeed = 0.03F;
            this.GunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.GunaButton1.BorderColor = System.Drawing.Color.Black;
            this.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.GunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.GunaButton1.ForeColor = System.Drawing.Color.DarkGray;
            this.GunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("GunaButton1.Image")));
            this.GunaButton1.ImageSize = new System.Drawing.Size(12, 12);
            this.GunaButton1.Location = new System.Drawing.Point(552, 100);
            this.GunaButton1.Name = "GunaButton1";
            this.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.GunaButton1.OnHoverImage = null;
            this.GunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.GunaButton1.Radius = 3;
            this.GunaButton1.Size = new System.Drawing.Size(133, 30);
            this.GunaButton1.TabIndex = 6;
            this.GunaButton1.Text = "CREATE ASSET";
            // 
            // GunaCircleButton1
            // 
            this.GunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.GunaCircleButton1.AnimationSpeed = 0.03F;
            this.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.GunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.GunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.GunaCircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("GunaCircleButton1.Image")));
            this.GunaCircleButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.GunaCircleButton1.Location = new System.Drawing.Point(235, 100);
            this.GunaCircleButton1.Name = "GunaCircleButton1";
            this.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.GunaCircleButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("GunaCircleButton1.OnHoverImage")));
            this.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.GunaCircleButton1.Size = new System.Drawing.Size(30, 30);
            this.GunaCircleButton1.TabIndex = 1;
            // 
            // frm_peoples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(715, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.GunaTextBox1);
            this.Controls.Add(this.GunaButton1);
            this.Controls.Add(this.GunaCircleButton1);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.grid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_peoples";
            this.Text = "frm_peoples";
            this.Load += new System.EventHandler(this.frm_peoples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuDataGridView grid;
        internal Guna.UI.WinForms.GunaButton GunaButton1;
        internal Guna.UI.WinForms.GunaTextBox GunaTextBox1;
        internal Guna.UI.WinForms.GunaCircleButton GunaCircleButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnExportExcel;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private System.Windows.Forms.Label label1;
    }
}