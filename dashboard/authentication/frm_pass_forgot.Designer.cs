
namespace dashboard
{
    partial class frm_pass_forgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pass_forgot));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label_form_name = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestore = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecretW = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.DragPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            this.pnlHeader.Size = new System.Drawing.Size(490, 53);
            this.pnlHeader.TabIndex = 117;
            // 
            // label_form_name
            // 
            this.label_form_name.AutoSize = true;
            this.label_form_name.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label_form_name.ForeColor = System.Drawing.Color.LightGray;
            this.label_form_name.Location = new System.Drawing.Point(12, 22);
            this.label_form_name.Name = "label_form_name";
            this.label_form_name.Size = new System.Drawing.Size(152, 20);
            this.label_form_name.TabIndex = 56;
            this.label_form_name.Text = "RESTORE PASSWORD";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(442, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestore.AnimationHoverSpeed = 0.07F;
            this.btnRestore.AnimationSpeed = 0.03F;
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnRestore.BorderColor = System.Drawing.Color.Black;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestore.FocusedColor = System.Drawing.Color.Empty;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btnRestore.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageSize = new System.Drawing.Size(12, 12);
            this.btnRestore.Location = new System.Drawing.Point(100, 287);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnRestore.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRestore.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRestore.OnHoverImage = null;
            this.btnRestore.OnPressedColor = System.Drawing.Color.Black;
            this.btnRestore.Size = new System.Drawing.Size(259, 46);
            this.btnRestore.TabIndex = 128;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(177, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 127;
            this.label3.Text = "SECRET WORD";
            // 
            // txtSecretW
            // 
            this.txtSecretW.AcceptsReturn = false;
            this.txtSecretW.AcceptsTab = false;
            this.txtSecretW.AnimationSpeed = 200;
            this.txtSecretW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSecretW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSecretW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtSecretW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSecretW.BackgroundImage")));
            this.txtSecretW.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtSecretW.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSecretW.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtSecretW.BorderColorIdle = System.Drawing.Color.White;
            this.txtSecretW.BorderRadius = 30;
            this.txtSecretW.BorderThickness = 2;
            this.txtSecretW.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSecretW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecretW.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecretW.DefaultText = "";
            this.txtSecretW.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtSecretW.ForeColor = System.Drawing.Color.LightGray;
            this.txtSecretW.HideSelection = true;
            this.txtSecretW.IconLeft = null;
            this.txtSecretW.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtSecretW.IconPadding = 10;
            this.txtSecretW.IconRight = null;
            this.txtSecretW.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSecretW.Lines = new string[0];
            this.txtSecretW.Location = new System.Drawing.Point(100, 221);
            this.txtSecretW.MaxLength = 32767;
            this.txtSecretW.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSecretW.Modified = false;
            this.txtSecretW.Multiline = false;
            this.txtSecretW.Name = "txtSecretW";
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSecretW.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties18.FillColor = System.Drawing.Color.White;
            stateProperties18.ForeColor = System.Drawing.Color.Empty;
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSecretW.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSecretW.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.White;
            stateProperties20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties20.ForeColor = System.Drawing.Color.LightGray;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSecretW.OnIdleState = stateProperties20;
            this.txtSecretW.PasswordChar = '\0';
            this.txtSecretW.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSecretW.PlaceholderText = "";
            this.txtSecretW.ReadOnly = false;
            this.txtSecretW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSecretW.SelectedText = "";
            this.txtSecretW.SelectionLength = 0;
            this.txtSecretW.SelectionStart = 0;
            this.txtSecretW.ShortcutsEnabled = true;
            this.txtSecretW.Size = new System.Drawing.Size(259, 35);
            this.txtSecretW.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtSecretW.TabIndex = 126;
            this.txtSecretW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSecretW.TextMarginBottom = 0;
            this.txtSecretW.TextMarginLeft = 0;
            this.txtSecretW.TextMarginTop = 0;
            this.txtSecretW.TextPlaceholder = "";
            this.txtSecretW.UseSystemPasswordChar = false;
            this.txtSecretW.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(186, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 125;
            this.label2.Text = "USERNAME";
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.AnimationSpeed = 200;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtName.BorderColorIdle = System.Drawing.Color.White;
            this.txtName.BorderRadius = 30;
            this.txtName.BorderThickness = 2;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtName.ForeColor = System.Drawing.Color.LightGray;
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = null;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = null;
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(100, 123);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtName.Modified = false;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            stateProperties21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties22.FillColor = System.Drawing.Color.White;
            stateProperties22.ForeColor = System.Drawing.Color.Empty;
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtName.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.White;
            stateProperties24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties24.ForeColor = System.Drawing.Color.LightGray;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnIdleState = stateProperties24;
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtName.PlaceholderText = "";
            this.txtName.ReadOnly = false;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(259, 35);
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtName.TabIndex = 124;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginBottom = 0;
            this.txtName.TextMarginLeft = 0;
            this.txtName.TextMarginTop = 0;
            this.txtName.TextPlaceholder = "";
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.WordWrap = true;
            // 
            // DragPanel
            // 
            this.DragPanel.Fixed = true;
            this.DragPanel.Horizontal = true;
            this.DragPanel.TargetControl = this.pnlHeader;
            this.DragPanel.Vertical = true;
            // 
            // DragForm
            // 
            this.DragForm.Fixed = true;
            this.DragForm.Horizontal = true;
            this.DragForm.TargetControl = this;
            this.DragForm.Vertical = true;
            // 
            // frm_pass_forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(490, 392);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecretW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_pass_forgot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_pass_forgot";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label_form_name;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        internal Guna.UI.WinForms.GunaButton btnRestore;
        private System.Windows.Forms.Label label3;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSecretW;
        private System.Windows.Forms.Label label2;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.Framework.UI.BunifuDragControl DragPanel;
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
    }
}