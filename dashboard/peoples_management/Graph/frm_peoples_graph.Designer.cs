
namespace dashboard
{
    partial class frm_peoples_graph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_peoples_graph));
            this.panel_Child = new System.Windows.Forms.Panel();
            this.dataViz = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.cmbList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_name = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progress_2 = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.round_2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label_num_2 = new System.Windows.Forms.Label();
            this.label_num_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.round_1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.progress_1 = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.panel_Child.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Child
            // 
            this.panel_Child.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.panel_Child.Controls.Add(this.dataViz);
            this.panel_Child.Controls.Add(this.cmbList);
            this.panel_Child.Controls.Add(this.label_name);
            this.panel_Child.Controls.Add(this.btnClose);
            this.panel_Child.Controls.Add(this.panel1);
            this.panel_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Child.Location = new System.Drawing.Point(0, 0);
            this.panel_Child.Name = "panel_Child";
            this.panel_Child.Size = new System.Drawing.Size(731, 491);
            this.panel_Child.TabIndex = 148;
            // 
            // dataViz
            // 
            this.dataViz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataViz.animationEnabled = true;
            this.dataViz.AxisLineColor = System.Drawing.Color.LightGray;
            this.dataViz.AxisXFontColor = System.Drawing.Color.Gray;
            this.dataViz.AxisXGridColor = System.Drawing.Color.Gray;
            this.dataViz.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dataViz.AxisYFontColor = System.Drawing.Color.Gray;
            this.dataViz.AxisYGridColor = System.Drawing.Color.Gray;
            this.dataViz.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dataViz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.dataViz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dataViz.Location = new System.Drawing.Point(12, 104);
            this.dataViz.Name = "dataViz";
            this.dataViz.Size = new System.Drawing.Size(707, 246);
            this.dataViz.TabIndex = 171;
            this.dataViz.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme3;
            this.dataViz.Title = "";
            // 
            // cmbList
            // 
            this.cmbList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbList.BackColor = System.Drawing.Color.Transparent;
            this.cmbList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cmbList.BorderThickness = 0;
            this.cmbList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cmbList.FocusedColor = System.Drawing.Color.Empty;
            this.cmbList.FocusedState.Parent = this.cmbList;
            this.cmbList.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.cmbList.ForeColor = System.Drawing.Color.LightGray;
            this.cmbList.FormattingEnabled = true;
            this.cmbList.HoverState.Parent = this.cmbList;
            this.cmbList.ItemHeight = 34;
            this.cmbList.Items.AddRange(new object[] {
            "DEATH",
            "SICK"});
            this.cmbList.ItemsAppearance.Parent = this.cmbList;
            this.cmbList.Location = new System.Drawing.Point(598, 12);
            this.cmbList.Name = "cmbList";
            this.cmbList.ShadowDecoration.Parent = this.cmbList;
            this.cmbList.Size = new System.Drawing.Size(121, 40);
            this.cmbList.StartIndex = 0;
            this.cmbList.TabIndex = 169;
            this.cmbList.SelectedIndexChanged += new System.EventHandler(this.cmbList_SelectedIndexChanged);
            // 
            // label_name
            // 
            this.label_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label_name.ForeColor = System.Drawing.Color.LightGray;
            this.label_name.Location = new System.Drawing.Point(8, 66);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(53, 20);
            this.label_name.TabIndex = 162;
            this.label_name.Text = "NAME";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 151;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.progress_2);
            this.panel1.Controls.Add(this.round_2);
            this.panel1.Controls.Add(this.label_num_2);
            this.panel1.Controls.Add(this.label_num_1);
            this.panel1.Controls.Add(this.label_2);
            this.panel1.Controls.Add(this.label_1);
            this.panel1.Controls.Add(this.round_1);
            this.panel1.Controls.Add(this.progress_1);
            this.panel1.Location = new System.Drawing.Point(12, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 111);
            this.panel1.TabIndex = 163;
            // 
            // progress_2
            // 
            this.progress_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress_2.Animation = 1;
            this.progress_2.AnimationStep = 10;
            this.progress_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_2.BackgroundImage")));
            this.progress_2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.progress_2.BorderRadius = 5;
            this.progress_2.BorderThickness = 1;
            this.progress_2.Location = new System.Drawing.Point(9, 81);
            this.progress_2.MaximumValue = 1000;
            this.progress_2.MinimumValue = 0;
            this.progress_2.Name = "progress_2";
            this.progress_2.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.progress_2.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.progress_2.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(56)))), ((int)(((byte)(227)))));
            this.progress_2.Size = new System.Drawing.Size(442, 13);
            this.progress_2.TabIndex = 169;
            this.progress_2.Value = 50;
            // 
            // round_2
            // 
            this.round_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.round_2.animated = false;
            this.round_2.animationIterval = 5;
            this.round_2.animationSpeed = 300;
            this.round_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.round_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("round_2.BackgroundImage")));
            this.round_2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.round_2.LabelVisible = true;
            this.round_2.LineProgressThickness = 8;
            this.round_2.LineThickness = 5;
            this.round_2.Location = new System.Drawing.Point(605, 9);
            this.round_2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.round_2.MaxValue = 100;
            this.round_2.Name = "round_2";
            this.round_2.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.round_2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(227)))), ((int)(((byte)(189)))));
            this.round_2.Size = new System.Drawing.Size(96, 96);
            this.round_2.TabIndex = 168;
            this.round_2.Value = 50;
            // 
            // label_num_2
            // 
            this.label_num_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_num_2.AutoSize = true;
            this.label_num_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label_num_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_num_2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label_num_2.ForeColor = System.Drawing.Color.DarkGray;
            this.label_num_2.Location = new System.Drawing.Point(457, 75);
            this.label_num_2.Name = "label_num_2";
            this.label_num_2.Size = new System.Drawing.Size(31, 19);
            this.label_num_2.TabIndex = 167;
            this.label_num_2.Text = "100";
            // 
            // label_num_1
            // 
            this.label_num_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_num_1.AutoSize = true;
            this.label_num_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label_num_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_num_1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label_num_1.ForeColor = System.Drawing.Color.DarkGray;
            this.label_num_1.Location = new System.Drawing.Point(457, 32);
            this.label_num_1.Name = "label_num_1";
            this.label_num_1.Size = new System.Drawing.Size(31, 19);
            this.label_num_1.TabIndex = 166;
            this.label_num_1.Text = "100";
            // 
            // label_2
            // 
            this.label_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_2.AutoSize = true;
            this.label_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label_2.ForeColor = System.Drawing.Color.Gray;
            this.label_2.Location = new System.Drawing.Point(5, 59);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(49, 19);
            this.label_2.TabIndex = 165;
            this.label_2.Text = "NAME";
            // 
            // label_1
            // 
            this.label_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_1.AutoSize = true;
            this.label_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label_1.ForeColor = System.Drawing.Color.Gray;
            this.label_1.Location = new System.Drawing.Point(5, 16);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(49, 19);
            this.label_1.TabIndex = 164;
            this.label_1.Text = "NAME";
            // 
            // round_1
            // 
            this.round_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.round_1.animated = false;
            this.round_1.animationIterval = 5;
            this.round_1.animationSpeed = 300;
            this.round_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.round_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("round_1.BackgroundImage")));
            this.round_1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.round_1.LabelVisible = true;
            this.round_1.LineProgressThickness = 8;
            this.round_1.LineThickness = 5;
            this.round_1.Location = new System.Drawing.Point(497, 9);
            this.round_1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.round_1.MaxValue = 100;
            this.round_1.Name = "round_1";
            this.round_1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.round_1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.round_1.Size = new System.Drawing.Size(96, 96);
            this.round_1.TabIndex = 163;
            this.round_1.Value = 50;
            // 
            // progress_1
            // 
            this.progress_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress_1.Animation = 1;
            this.progress_1.AnimationStep = 10;
            this.progress_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_1.BackgroundImage")));
            this.progress_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.progress_1.BorderRadius = 5;
            this.progress_1.BorderThickness = 1;
            this.progress_1.Location = new System.Drawing.Point(9, 38);
            this.progress_1.MaximumValue = 1000;
            this.progress_1.MinimumValue = 0;
            this.progress_1.Name = "progress_1";
            this.progress_1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.progress_1.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.progress_1.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(56)))), ((int)(((byte)(227)))));
            this.progress_1.Size = new System.Drawing.Size(442, 13);
            this.progress_1.TabIndex = 162;
            this.progress_1.Value = 50;
            // 
            // frm_peoples_graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(731, 491);
            this.Controls.Add(this.panel_Child);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_peoples_graph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_peoples_graph";
            this.Load += new System.EventHandler(this.frm_peoples_graph_Load);
            this.panel_Child.ResumeLayout(false);
            this.panel_Child.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Child;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.Winforms.BunifuProgressBar progress_2;
        public Bunifu.Framework.UI.BunifuCircleProgressbar round_2;
        private System.Windows.Forms.Label label_num_2;
        private System.Windows.Forms.Label label_num_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_1;
        public Bunifu.Framework.UI.BunifuCircleProgressbar round_1;
        private Bunifu.UI.Winforms.BunifuProgressBar progress_1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbList;
        private Bunifu.DataViz.WinForms.BunifuDataViz dataViz;
    }
}