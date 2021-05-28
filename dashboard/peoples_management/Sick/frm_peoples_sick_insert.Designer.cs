
namespace dashboard
{
    partial class frm_peoples_sick_insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_peoples_sick_insert));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DragPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtDiagnoz = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.cmbList = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.pnlHeader.TabIndex = 135;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 134;
            this.label2.Text = "TIP EVIDENTA";
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
            this.btnAdd.Location = new System.Drawing.Point(16, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(242, 46);
            this.btnAdd.TabIndex = 137;
            this.btnAdd.Text = "INSERT";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 136;
            this.label3.Text = "DIAGNOZ";
            // 
            // DragPanel
            // 
            this.DragPanel.Fixed = true;
            this.DragPanel.Horizontal = true;
            this.DragPanel.TargetControl = this.pnlHeader;
            this.DragPanel.Vertical = true;
            // 
            // txtDiagnoz
            // 
            this.txtDiagnoz.AcceptsReturn = false;
            this.txtDiagnoz.AcceptsTab = false;
            this.txtDiagnoz.AnimationSpeed = 200;
            this.txtDiagnoz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDiagnoz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDiagnoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtDiagnoz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDiagnoz.BackgroundImage")));
            this.txtDiagnoz.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtDiagnoz.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtDiagnoz.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtDiagnoz.BorderColorIdle = System.Drawing.Color.White;
            this.txtDiagnoz.BorderRadius = 30;
            this.txtDiagnoz.BorderThickness = 2;
            this.txtDiagnoz.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiagnoz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnoz.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiagnoz.DefaultText = "";
            this.txtDiagnoz.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txtDiagnoz.ForeColor = System.Drawing.Color.LightGray;
            this.txtDiagnoz.HideSelection = true;
            this.txtDiagnoz.IconLeft = null;
            this.txtDiagnoz.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtDiagnoz.IconPadding = 10;
            this.txtDiagnoz.IconRight = null;
            this.txtDiagnoz.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDiagnoz.Lines = new string[0];
            this.txtDiagnoz.Location = new System.Drawing.Point(16, 199);
            this.txtDiagnoz.MaxLength = 32767;
            this.txtDiagnoz.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtDiagnoz.Modified = false;
            this.txtDiagnoz.Multiline = false;
            this.txtDiagnoz.Name = "txtDiagnoz";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDiagnoz.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDiagnoz.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDiagnoz.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties4.ForeColor = System.Drawing.Color.LightGray;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDiagnoz.OnIdleState = stateProperties4;
            this.txtDiagnoz.PasswordChar = '\0';
            this.txtDiagnoz.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDiagnoz.PlaceholderText = "";
            this.txtDiagnoz.ReadOnly = false;
            this.txtDiagnoz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiagnoz.SelectedText = "";
            this.txtDiagnoz.SelectionLength = 0;
            this.txtDiagnoz.SelectionStart = 0;
            this.txtDiagnoz.ShortcutsEnabled = true;
            this.txtDiagnoz.Size = new System.Drawing.Size(242, 35);
            this.txtDiagnoz.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtDiagnoz.TabIndex = 138;
            this.txtDiagnoz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiagnoz.TextMarginBottom = 0;
            this.txtDiagnoz.TextMarginLeft = 0;
            this.txtDiagnoz.TextMarginTop = 0;
            this.txtDiagnoz.TextPlaceholder = "";
            this.txtDiagnoz.UseSystemPasswordChar = false;
            this.txtDiagnoz.WordWrap = true;
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
            this.cmbList.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.cmbList.ForeColor = System.Drawing.Color.LightGray;
            this.cmbList.FormattingEnabled = true;
            this.cmbList.HoverState.Parent = this.cmbList;
            this.cmbList.ItemHeight = 34;
            this.cmbList.Items.AddRange(new object[] {
            "NARCOLOGIE",
            "PSIHOLOGIE"});
            this.cmbList.ItemsAppearance.Parent = this.cmbList;
            this.cmbList.Location = new System.Drawing.Point(16, 124);
            this.cmbList.Name = "cmbList";
            this.cmbList.ShadowDecoration.Parent = this.cmbList;
            this.cmbList.Size = new System.Drawing.Size(242, 40);
            this.cmbList.TabIndex = 153;
            // 
            // frm_peoples_sick_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(279, 309);
            this.Controls.Add(this.cmbList);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiagnoz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_peoples_sick_insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_peoples_sick_insert";
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
        private System.Windows.Forms.Label label2;
        internal Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDragControl DragPanel;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtDiagnoz;
        private Guna.UI2.WinForms.Guna2ComboBox cmbList;
    }
}