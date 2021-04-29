
namespace dashboard
{
    partial class frm_database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_database));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label_form_name = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnServerList = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnAccess = new Guna.UI.WinForms.GunaButton();
            this.btnBrowse = new Guna.UI.WinForms.GunaButton();
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnlHeader.Controls.Add(this.label_form_name);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(281, 53);
            this.pnlHeader.TabIndex = 62;
            // 
            // label_form_name
            // 
            this.label_form_name.AutoSize = true;
            this.label_form_name.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label_form_name.ForeColor = System.Drawing.Color.LightGray;
            this.label_form_name.Location = new System.Drawing.Point(8, 19);
            this.label_form_name.Name = "label_form_name";
            this.label_form_name.Size = new System.Drawing.Size(85, 20);
            this.label_form_name.TabIndex = 56;
            this.label_form_name.Text = "DATABASE ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(233, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnServerList
            // 
            this.btnServerList.BackColor = System.Drawing.Color.Transparent;
            this.btnServerList.BorderRadius = 3;
            this.btnServerList.DisabledColor = System.Drawing.Color.Gray;
            this.btnServerList.ForeColor = System.Drawing.Color.LightGray;
            this.btnServerList.items = new string[0];
            this.btnServerList.Location = new System.Drawing.Point(12, 87);
            this.btnServerList.Name = "btnServerList";
            this.btnServerList.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnServerList.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnServerList.selectedIndex = -1;
            this.btnServerList.Size = new System.Drawing.Size(217, 35);
            this.btnServerList.TabIndex = 63;
            // 
            // btnAccess
            // 
            this.btnAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccess.AnimationHoverSpeed = 0.07F;
            this.btnAccess.AnimationSpeed = 0.03F;
            this.btnAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnAccess.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnAccess.BorderColor = System.Drawing.Color.Black;
            this.btnAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccess.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccess.FocusedColor = System.Drawing.Color.Empty;
            this.btnAccess.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnAccess.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAccess.Image = ((System.Drawing.Image)(resources.GetObject("btnAccess.Image")));
            this.btnAccess.ImageSize = new System.Drawing.Size(12, 12);
            this.btnAccess.Location = new System.Drawing.Point(12, 147);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnAccess.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAccess.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAccess.OnHoverImage = null;
            this.btnAccess.OnPressedColor = System.Drawing.Color.Black;
            this.btnAccess.Size = new System.Drawing.Size(257, 35);
            this.btnAccess.TabIndex = 84;
            this.btnAccess.Text = "CREATE";
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AnimationHoverSpeed = 0.07F;
            this.btnBrowse.AnimationSpeed = 0.03F;
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBrowse.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnBrowse.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.Image = null;
            this.btnBrowse.ImageSize = new System.Drawing.Size(12, 12);
            this.btnBrowse.Location = new System.Drawing.Point(236, 87);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBrowse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBrowse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBrowse.OnHoverImage = null;
            this.btnBrowse.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnBrowse.Size = new System.Drawing.Size(33, 35);
            this.btnBrowse.TabIndex = 85;
            this.btnBrowse.Text = ". . .";
            this.btnBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // DragForm
            // 
            this.DragForm.Fixed = true;
            this.DragForm.Horizontal = true;
            this.DragForm.TargetControl = this;
            this.DragForm.Vertical = true;
            // 
            // DragPanel
            // 
            this.DragPanel.Fixed = true;
            this.DragPanel.Horizontal = true;
            this.DragPanel.TargetControl = this.pnlHeader;
            this.DragPanel.Vertical = true;
            // 
            // frm_database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(281, 198);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.btnServerList);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_database";
            this.Load += new System.EventHandler(this.frm_database_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label_form_name;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDropdown btnServerList;
        internal Guna.UI.WinForms.GunaButton btnAccess;
        internal Guna.UI.WinForms.GunaButton btnBrowse;
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
        private Bunifu.Framework.UI.BunifuDragControl DragPanel;
    }
}