
namespace dashboard
{
    partial class frm_peoples_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_peoples_add));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.date_of_birth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DragPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtFullName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtIDNP = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
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
            this.pnlHeader.TabIndex = 129;
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
            // date_of_birth
            // 
            this.date_of_birth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.date_of_birth.BorderRadius = 0;
            this.date_of_birth.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.date_of_birth.ForeColor = System.Drawing.Color.LightGray;
            this.date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_of_birth.FormatCustom = "yyyy-MM-dd";
            this.date_of_birth.Location = new System.Drawing.Point(16, 207);
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.Size = new System.Drawing.Size(242, 36);
            this.date_of_birth.TabIndex = 128;
            this.date_of_birth.Value = new System.DateTime(2021, 5, 2, 15, 34, 30, 48);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 127;
            this.label2.Text = "DATE OF BIRTH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 125;
            this.label1.Text = "FULL NAME";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnAdd.Location = new System.Drawing.Point(16, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(242, 46);
            this.btnAdd.TabIndex = 131;
            this.btnAdd.Text = "INSERT";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(12, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 130;
            this.label3.Text = "IDNP";
            // 
            // DragPanel
            // 
            this.DragPanel.Fixed = true;
            this.DragPanel.Horizontal = true;
            this.DragPanel.TargetControl = this.pnlHeader;
            this.DragPanel.Vertical = true;
            // 
            // txtFullName
            // 
            this.txtFullName.AcceptsReturn = false;
            this.txtFullName.AcceptsTab = false;
            this.txtFullName.AnimationSpeed = 200;
            this.txtFullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFullName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtFullName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFullName.BackgroundImage")));
            this.txtFullName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtFullName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtFullName.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtFullName.BorderColorIdle = System.Drawing.Color.White;
            this.txtFullName.BorderRadius = 30;
            this.txtFullName.BorderThickness = 2;
            this.txtFullName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFullName.DefaultText = "";
            this.txtFullName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtFullName.ForeColor = System.Drawing.Color.LightGray;
            this.txtFullName.HideSelection = true;
            this.txtFullName.IconLeft = null;
            this.txtFullName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtFullName.IconPadding = 10;
            this.txtFullName.IconRight = null;
            this.txtFullName.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(16, 117);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtFullName.Modified = false;
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFullName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFullName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFullName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties4.ForeColor = System.Drawing.Color.LightGray;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFullName.OnIdleState = stateProperties4;
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.ReadOnly = false;
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(242, 35);
            this.txtFullName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtFullName.TabIndex = 132;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFullName.TextMarginBottom = 0;
            this.txtFullName.TextMarginLeft = 0;
            this.txtFullName.TextMarginTop = 0;
            this.txtFullName.TextPlaceholder = "";
            this.txtFullName.UseSystemPasswordChar = false;
            this.txtFullName.WordWrap = true;
            // 
            // txtIDNP
            // 
            this.txtIDNP.AcceptsReturn = false;
            this.txtIDNP.AcceptsTab = false;
            this.txtIDNP.AnimationSpeed = 200;
            this.txtIDNP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIDNP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIDNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtIDNP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtIDNP.BackgroundImage")));
            this.txtIDNP.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtIDNP.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtIDNP.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtIDNP.BorderColorIdle = System.Drawing.Color.White;
            this.txtIDNP.BorderRadius = 30;
            this.txtIDNP.BorderThickness = 2;
            this.txtIDNP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIDNP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNP.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIDNP.DefaultText = "";
            this.txtIDNP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtIDNP.ForeColor = System.Drawing.Color.LightGray;
            this.txtIDNP.HideSelection = true;
            this.txtIDNP.IconLeft = null;
            this.txtIDNP.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtIDNP.IconPadding = 10;
            this.txtIDNP.IconRight = null;
            this.txtIDNP.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.txtIDNP.Lines = new string[0];
            this.txtIDNP.Location = new System.Drawing.Point(16, 284);
            this.txtIDNP.MaxLength = 32767;
            this.txtIDNP.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtIDNP.Modified = false;
            this.txtIDNP.Multiline = false;
            this.txtIDNP.Name = "txtIDNP";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIDNP.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtIDNP.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIDNP.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.White;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties8.ForeColor = System.Drawing.Color.LightGray;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIDNP.OnIdleState = stateProperties8;
            this.txtIDNP.PasswordChar = '\0';
            this.txtIDNP.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtIDNP.PlaceholderText = "";
            this.txtIDNP.ReadOnly = false;
            this.txtIDNP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDNP.SelectedText = "";
            this.txtIDNP.SelectionLength = 0;
            this.txtIDNP.SelectionStart = 0;
            this.txtIDNP.ShortcutsEnabled = true;
            this.txtIDNP.Size = new System.Drawing.Size(242, 35);
            this.txtIDNP.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtIDNP.TabIndex = 133;
            this.txtIDNP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIDNP.TextMarginBottom = 0;
            this.txtIDNP.TextMarginLeft = 0;
            this.txtIDNP.TextMarginTop = 0;
            this.txtIDNP.TextPlaceholder = "";
            this.txtIDNP.UseSystemPasswordChar = false;
            this.txtIDNP.WordWrap = true;
            // 
            // frm_peoples_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(279, 400);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.date_of_birth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtIDNP);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_peoples_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_peoples_add";
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
        public Bunifu.Framework.UI.BunifuDatepicker date_of_birth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDragControl DragPanel;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtFullName;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtIDNP;
    }
}