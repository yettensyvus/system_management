
namespace dashboard
{
    partial class frm_cote_planting_upd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cote_planting_upd));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.DragPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPlant = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnlHeader.Controls.Add(this.label8);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(286, 53);
            this.pnlHeader.TabIndex = 151;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "UPDATE";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(238, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(12, 12);
            this.btnUpdate.Location = new System.Drawing.Point(16, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(242, 46);
            this.btnUpdate.TabIndex = 152;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.Fixed = true;
            this.DragPanel.Horizontal = true;
            this.DragPanel.TargetControl = this.pnlHeader;
            this.DragPanel.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 155;
            this.label2.Text = "PLANTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 153;
            this.label1.Text = "AN SEMANAT";
            // 
            // txtAn
            // 
            this.txtAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAn.BackColor = System.Drawing.Color.Transparent;
            this.txtAn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtAn.BorderThickness = 0;
            this.txtAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtAn.FocusedColor = System.Drawing.Color.Empty;
            this.txtAn.FocusedState.Parent = this.txtAn;
            this.txtAn.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.txtAn.ForeColor = System.Drawing.Color.LightGray;
            this.txtAn.FormattingEnabled = true;
            this.txtAn.HoverState.Parent = this.txtAn;
            this.txtAn.ItemHeight = 34;
            this.txtAn.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.txtAn.ItemsAppearance.Parent = this.txtAn;
            this.txtAn.Location = new System.Drawing.Point(16, 112);
            this.txtAn.Name = "txtAn";
            this.txtAn.ShadowDecoration.Parent = this.txtAn;
            this.txtAn.Size = new System.Drawing.Size(242, 40);
            this.txtAn.TabIndex = 176;
            // 
            // txtPlant
            // 
            this.txtPlant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlant.BackColor = System.Drawing.Color.Transparent;
            this.txtPlant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtPlant.BorderThickness = 0;
            this.txtPlant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPlant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txtPlant.FocusedColor = System.Drawing.Color.Empty;
            this.txtPlant.FocusedState.Parent = this.txtPlant;
            this.txtPlant.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.txtPlant.ForeColor = System.Drawing.Color.LightGray;
            this.txtPlant.FormattingEnabled = true;
            this.txtPlant.HoverState.Parent = this.txtPlant;
            this.txtPlant.ItemHeight = 34;
            this.txtPlant.Items.AddRange(new object[] {
            "Semințe de Floarea Soarelui",
            "Porumb",
            "Sfeclă de zahăr",
            "Grîu"});
            this.txtPlant.ItemsAppearance.Parent = this.txtPlant;
            this.txtPlant.Location = new System.Drawing.Point(16, 178);
            this.txtPlant.Name = "txtPlant";
            this.txtPlant.ShadowDecoration.Parent = this.txtPlant;
            this.txtPlant.Size = new System.Drawing.Size(242, 40);
            this.txtPlant.TabIndex = 177;
            // 
            // frm_cote_planting_upd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(286, 307);
            this.Controls.Add(this.txtPlant);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cote_planting_upd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_cote_planting_upd";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        internal Guna.UI.WinForms.GunaButton btnUpdate;
        private Bunifu.Framework.UI.BunifuDragControl DragPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ComboBox txtAn;
        public Guna.UI2.WinForms.Guna2ComboBox txtPlant;
    }
}