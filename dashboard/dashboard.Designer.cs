
namespace dashboard
{
    partial class dashboard
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel_Child = new System.Windows.Forms.Panel();
            this.PanelDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label_app_name = new System.Windows.Forms.Label();
            this.btnMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNormal = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlDrawer = new System.Windows.Forms.Panel();
            this.btnProfile = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAbout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelManagementSub = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPeoples = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnManagement = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelToggle = new System.Windows.Forms.Panel();
            this.btnToggleDrawer = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            this.pnlDrawer.SuspendLayout();
            this.panelManagementSub.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelToggle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleDrawer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Child
            // 
            this.panel_Child.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.panel_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Child.Location = new System.Drawing.Point(200, 52);
            this.panel_Child.Name = "panel_Child";
            this.panel_Child.Size = new System.Drawing.Size(731, 491);
            this.panel_Child.TabIndex = 13;
            // 
            // PanelDrag
            // 
            this.PanelDrag.Fixed = true;
            this.PanelDrag.Horizontal = true;
            this.PanelDrag.TargetControl = this.pnlHeader;
            this.PanelDrag.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnlHeader.Controls.Add(this.btnMin);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.label_app_name);
            this.pnlHeader.Controls.Add(this.btnMax);
            this.pnlHeader.Controls.Add(this.btnNormal);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(731, 52);
            this.pnlHeader.TabIndex = 12;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(632, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 3;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(694, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label_app_name
            // 
            this.label_app_name.AutoSize = true;
            this.label_app_name.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label_app_name.ForeColor = System.Drawing.Color.LightGray;
            this.label_app_name.Location = new System.Drawing.Point(6, 15);
            this.label_app_name.Name = "label_app_name";
            this.label_app_name.Size = new System.Drawing.Size(174, 20);
            this.label_app_name.TabIndex = 0;
            this.label_app_name.Text = "MANAGEMENT SYSTEM";
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.ImageActive = null;
            this.btnMax.Location = new System.Drawing.Point(663, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 2;
            this.btnMax.TabStop = false;
            this.btnMax.Zoom = 10;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.ImageActive = null;
            this.btnNormal.Location = new System.Drawing.Point(663, 12);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(25, 25);
            this.btnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNormal.TabIndex = 4;
            this.btnNormal.TabStop = false;
            this.btnNormal.Zoom = 10;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // pnlDrawer
            // 
            this.pnlDrawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnlDrawer.Controls.Add(this.btnProfile);
            this.pnlDrawer.Controls.Add(this.btnAbout);
            this.pnlDrawer.Controls.Add(this.panelManagementSub);
            this.pnlDrawer.Controls.Add(this.btnExit);
            this.pnlDrawer.Controls.Add(this.btnManagement);
            this.pnlDrawer.Controls.Add(this.panelLogo);
            this.pnlDrawer.Controls.Add(this.panelToggle);
            this.pnlDrawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDrawer.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawer.Name = "pnlDrawer";
            this.pnlDrawer.Size = new System.Drawing.Size(200, 543);
            this.pnlDrawer.TabIndex = 11;
            // 
            // btnProfile
            // 
            this.btnProfile.Animated = true;
            this.btnProfile.AnimationHoverSpeed = 0.07F;
            this.btnProfile.AnimationSpeed = 0.03F;
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnProfile.BorderColor = System.Drawing.Color.Black;
            this.btnProfile.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnProfile.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnProfile.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnProfile.CheckedForeColor = System.Drawing.Color.White;
            this.btnProfile.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.CheckedImage")));
            this.btnProfile.CheckedLineColor = System.Drawing.Color.Black;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FocusedColor = System.Drawing.Color.Empty;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageSize = new System.Drawing.Size(32, 32);
            this.btnProfile.LineColor = System.Drawing.Color.Transparent;
            this.btnProfile.LineLeft = 4;
            this.btnProfile.Location = new System.Drawing.Point(0, 378);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnProfile.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnProfile.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProfile.OnHoverImage = null;
            this.btnProfile.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnProfile.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnProfile.OnPressedDepth = 0;
            this.btnProfile.Size = new System.Drawing.Size(200, 49);
            this.btnProfile.TabIndex = 16;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Animated = true;
            this.btnAbout.AnimationHoverSpeed = 0.07F;
            this.btnAbout.AnimationSpeed = 0.03F;
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnAbout.BorderColor = System.Drawing.Color.Black;
            this.btnAbout.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnAbout.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnAbout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAbout.CheckedForeColor = System.Drawing.Color.White;
            this.btnAbout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.CheckedImage")));
            this.btnAbout.CheckedLineColor = System.Drawing.Color.Black;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FocusedColor = System.Drawing.Color.Empty;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAbout.LineColor = System.Drawing.Color.Transparent;
            this.btnAbout.LineLeft = 4;
            this.btnAbout.Location = new System.Drawing.Point(0, 329);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnAbout.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAbout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAbout.OnHoverImage = null;
            this.btnAbout.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnAbout.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnAbout.OnPressedDepth = 0;
            this.btnAbout.Size = new System.Drawing.Size(200, 49);
            this.btnAbout.TabIndex = 14;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panelManagementSub
            // 
            this.panelManagementSub.Controls.Add(this.gunaAdvenceButton2);
            this.panelManagementSub.Controls.Add(this.btnPeoples);
            this.panelManagementSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManagementSub.Location = new System.Drawing.Point(0, 231);
            this.panelManagementSub.Name = "panelManagementSub";
            this.panelManagementSub.Size = new System.Drawing.Size(200, 98);
            this.panelManagementSub.TabIndex = 17;
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.Animated = true;
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.LineLeft = 4;
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(0, 49);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.gunaAdvenceButton2.OnPressedDepth = 0;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(200, 49);
            this.gunaAdvenceButton2.TabIndex = 16;
            this.gunaAdvenceButton2.Text = "Dashboard Ground";
            // 
            // btnPeoples
            // 
            this.btnPeoples.Animated = true;
            this.btnPeoples.AnimationHoverSpeed = 0.07F;
            this.btnPeoples.AnimationSpeed = 0.03F;
            this.btnPeoples.BackColor = System.Drawing.Color.Transparent;
            this.btnPeoples.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnPeoples.BorderColor = System.Drawing.Color.Black;
            this.btnPeoples.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.btnPeoples.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPeoples.CheckedForeColor = System.Drawing.Color.White;
            this.btnPeoples.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPeoples.CheckedImage")));
            this.btnPeoples.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnPeoples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeoples.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPeoples.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeoples.FocusedColor = System.Drawing.Color.Empty;
            this.btnPeoples.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPeoples.ForeColor = System.Drawing.Color.White;
            this.btnPeoples.Image = ((System.Drawing.Image)(resources.GetObject("btnPeoples.Image")));
            this.btnPeoples.ImageSize = new System.Drawing.Size(32, 32);
            this.btnPeoples.LineColor = System.Drawing.Color.Transparent;
            this.btnPeoples.LineLeft = 4;
            this.btnPeoples.Location = new System.Drawing.Point(0, 0);
            this.btnPeoples.Name = "btnPeoples";
            this.btnPeoples.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnPeoples.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnPeoples.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPeoples.OnHoverImage = null;
            this.btnPeoples.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnPeoples.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnPeoples.OnPressedDepth = 0;
            this.btnPeoples.Size = new System.Drawing.Size(200, 49);
            this.btnPeoples.TabIndex = 15;
            this.btnPeoples.Text = "Dashboard Peoples";
            this.btnPeoples.Click += new System.EventHandler(this.btnPeoples_Click);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnExit.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnExit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnExit.CheckedForeColor = System.Drawing.Color.White;
            this.btnExit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnExit.CheckedImage")));
            this.btnExit.CheckedLineColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(32, 32);
            this.btnExit.LineColor = System.Drawing.Color.Transparent;
            this.btnExit.LineLeft = 4;
            this.btnExit.Location = new System.Drawing.Point(0, 494);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnExit.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnExit.OnPressedDepth = 0;
            this.btnExit.Size = new System.Drawing.Size(200, 49);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Animated = true;
            this.btnManagement.AnimationHoverSpeed = 0.07F;
            this.btnManagement.AnimationSpeed = 0.03F;
            this.btnManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnManagement.BorderColor = System.Drawing.Color.Black;
            this.btnManagement.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnManagement.Checked = true;
            this.btnManagement.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnManagement.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnManagement.CheckedForeColor = System.Drawing.Color.White;
            this.btnManagement.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnManagement.CheckedImage")));
            this.btnManagement.CheckedLineColor = System.Drawing.Color.Black;
            this.btnManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnManagement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManagement.ForeColor = System.Drawing.Color.White;
            this.btnManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnManagement.Image")));
            this.btnManagement.ImageSize = new System.Drawing.Size(32, 32);
            this.btnManagement.LineColor = System.Drawing.Color.Transparent;
            this.btnManagement.LineLeft = 4;
            this.btnManagement.Location = new System.Drawing.Point(0, 182);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnManagement.OnHoverForeColor = System.Drawing.Color.White;
            this.btnManagement.OnHoverImage = null;
            this.btnManagement.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnManagement.OnPressedDepth = 0;
            this.btnManagement.Size = new System.Drawing.Size(200, 49);
            this.btnManagement.TabIndex = 12;
            this.btnManagement.Text = "Management";
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 52);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 130);
            this.panelLogo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOLDOVA\r\nR-NL. SOROCA  \r\nCAINARII VECHI\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelToggle
            // 
            this.panelToggle.Controls.Add(this.btnToggleDrawer);
            this.panelToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToggle.Location = new System.Drawing.Point(0, 0);
            this.panelToggle.Name = "panelToggle";
            this.panelToggle.Size = new System.Drawing.Size(200, 52);
            this.panelToggle.TabIndex = 7;
            // 
            // btnToggleDrawer
            // 
            this.btnToggleDrawer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleDrawer.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleDrawer.Image")));
            this.btnToggleDrawer.ImageActive = null;
            this.btnToggleDrawer.Location = new System.Drawing.Point(12, 15);
            this.btnToggleDrawer.Name = "btnToggleDrawer";
            this.btnToggleDrawer.Size = new System.Drawing.Size(27, 27);
            this.btnToggleDrawer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnToggleDrawer.TabIndex = 2;
            this.btnToggleDrawer.TabStop = false;
            this.btnToggleDrawer.Zoom = 10;
            this.btnToggleDrawer.Click += new System.EventHandler(this.btnToggleDrawer_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(47)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(931, 543);
            this.Controls.Add(this.panel_Child);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlDrawer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            this.pnlDrawer.ResumeLayout(false);
            this.panelManagementSub.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelToggle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleDrawer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Child;
        private Bunifu.Framework.UI.BunifuDragControl PanelDrag;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label_app_name;
        private Bunifu.Framework.UI.BunifuImageButton btnMax;
        private Bunifu.Framework.UI.BunifuImageButton btnNormal;
        private System.Windows.Forms.Panel pnlDrawer;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal Guna.UI.WinForms.GunaAdvenceButton btnManagement;
        internal Guna.UI.WinForms.GunaAdvenceButton btnAbout;
        internal Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private System.Windows.Forms.Panel panelToggle;
        private Bunifu.Framework.UI.BunifuImageButton btnToggleDrawer;
        private System.Windows.Forms.Label label1;
        internal Guna.UI.WinForms.GunaAdvenceButton btnProfile;
        private System.Windows.Forms.Panel panelManagementSub;
        internal Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        internal Guna.UI.WinForms.GunaAdvenceButton btnPeoples;
    }
}

