
namespace dashboard
{
    partial class frm_cote_harvest_insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cote_harvest_insert));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.DragPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtKG = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
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
            this.pnlHeader.Size = new System.Drawing.Size(279, 53);
            this.pnlHeader.TabIndex = 182;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "INSERT";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(231, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.Fixed = true;
            this.DragPanel.Horizontal = true;
            this.DragPanel.TargetControl = this.pnlHeader;
            this.DragPanel.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(108, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 184;
            this.label1.Text = "TONE";
            // 
            // txtKG
            // 
            this.txtKG.AcceptsReturn = false;
            this.txtKG.AcceptsTab = false;
            this.txtKG.AnimationSpeed = 200;
            this.txtKG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtKG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtKG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtKG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtKG.BackgroundImage")));
            this.txtKG.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtKG.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtKG.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtKG.BorderColorIdle = System.Drawing.Color.White;
            this.txtKG.BorderRadius = 30;
            this.txtKG.BorderThickness = 2;
            this.txtKG.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKG.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtKG.DefaultText = "";
            this.txtKG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtKG.ForeColor = System.Drawing.Color.LightGray;
            this.txtKG.HideSelection = true;
            this.txtKG.IconLeft = null;
            this.txtKG.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtKG.IconPadding = 10;
            this.txtKG.IconRight = null;
            this.txtKG.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.txtKG.Lines = new string[0];
            this.txtKG.Location = new System.Drawing.Point(16, 115);
            this.txtKG.MaxLength = 32767;
            this.txtKG.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtKG.Modified = false;
            this.txtKG.Multiline = false;
            this.txtKG.Name = "txtKG";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKG.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtKG.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKG.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.White;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties8.ForeColor = System.Drawing.Color.LightGray;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKG.OnIdleState = stateProperties8;
            this.txtKG.PasswordChar = '\0';
            this.txtKG.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtKG.PlaceholderText = "";
            this.txtKG.ReadOnly = false;
            this.txtKG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKG.SelectedText = "";
            this.txtKG.SelectionLength = 0;
            this.txtKG.SelectionStart = 0;
            this.txtKG.ShortcutsEnabled = true;
            this.txtKG.Size = new System.Drawing.Size(242, 35);
            this.txtKG.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtKG.TabIndex = 185;
            this.txtKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKG.TextMarginBottom = 0;
            this.txtKG.TextMarginLeft = 0;
            this.txtKG.TextMarginTop = 0;
            this.txtKG.TextPlaceholder = "";
            this.txtKG.UseSystemPasswordChar = false;
            this.txtKG.WordWrap = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(12, 12);
            this.btnAdd.Location = new System.Drawing.Point(16, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(242, 46);
            this.btnAdd.TabIndex = 186;
            this.btnAdd.Text = "INSERT";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frm_cote_harvest_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(279, 229);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cote_harvest_insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_cote_harvest_insert";
            this.Load += new System.EventHandler(this.frm_cote_harvest_insert_Load);
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
        private Bunifu.Framework.UI.BunifuDragControl DragPanel;
        private System.Windows.Forms.Label label1;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtKG;
        internal Guna.UI.WinForms.GunaButton btnAdd;
    }
}