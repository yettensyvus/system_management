
namespace dashboard.custom_controls
{
    partial class frm_MessageYesNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MessageYesNo));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.lblTitle = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblMessage = new System.Windows.Forms.Label();
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnYes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(169)))), ((int)(((byte)(248)))));
            this.lblTitle.Location = new System.Drawing.Point(142, 136);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 32);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Wait!";
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(133, 43);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(90, 90);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 53;
            this.icon.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(58, 171);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(240, 26);
            this.bunifuSeparator1.TabIndex = 55;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(2, 180);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(348, 90);
            this.lblMessage.TabIndex = 56;
            this.lblMessage.Text = "Message..";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragForm
            // 
            this.DragForm.Fixed = true;
            this.DragForm.Horizontal = true;
            this.DragForm.TargetControl = this;
            this.DragForm.Vertical = true;
            // 
            // btnYes
            // 
            this.btnYes.AllowToggling = false;
            this.btnYes.AnimationSpeed = 200;
            this.btnYes.AutoGenerateColors = false;
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(169)))), ((int)(((byte)(248)))));
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.ButtonText = "Yes";
            this.btnYes.ButtonTextMarginLeft = 0;
            this.btnYes.ColorContrastOnClick = 45;
            this.btnYes.ColorContrastOnHover = 45;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnYes.CustomizableEdges = borderEdges2;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnYes.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.IconMarginLeft = 11;
            this.btnYes.IconPadding = 10;
            this.btnYes.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(169)))), ((int)(((byte)(248)))));
            this.btnYes.IdleBorderRadius = 3;
            this.btnYes.IdleBorderThickness = 1;
            this.btnYes.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(169)))), ((int)(((byte)(248)))));
            this.btnYes.IdleIconLeftImage = null;
            this.btnYes.IdleIconRightImage = null;
            this.btnYes.IndicateFocus = false;
            this.btnYes.Location = new System.Drawing.Point(58, 273);
            this.btnYes.Name = "btnYes";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnYes.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.Black;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnYes.OnPressedState = stateProperties4;
            this.btnYes.Size = new System.Drawing.Size(114, 40);
            this.btnYes.TabIndex = 59;
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.TextMarginLeft = 0;
            this.btnYes.UseDefaultRadiusAndThickness = true;
            // 
            // btnNo
            // 
            this.btnNo.AllowToggling = false;
            this.btnNo.AnimationSpeed = 200;
            this.btnNo.AutoGenerateColors = false;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BackColor1 = System.Drawing.Color.Gray;
            this.btnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNo.BackgroundImage")));
            this.btnNo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.ButtonText = "No";
            this.btnNo.ButtonTextMarginLeft = 0;
            this.btnNo.ColorContrastOnClick = 45;
            this.btnNo.ColorContrastOnHover = 45;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNo.CustomizableEdges = borderEdges1;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnNo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.IconMarginLeft = 11;
            this.btnNo.IconPadding = 10;
            this.btnNo.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.IdleBorderColor = System.Drawing.Color.Gray;
            this.btnNo.IdleBorderRadius = 3;
            this.btnNo.IdleBorderThickness = 1;
            this.btnNo.IdleFillColor = System.Drawing.Color.Gray;
            this.btnNo.IdleIconLeftImage = null;
            this.btnNo.IdleIconRightImage = null;
            this.btnNo.IndicateFocus = false;
            this.btnNo.Location = new System.Drawing.Point(184, 273);
            this.btnNo.Name = "btnNo";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnNo.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Black;
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.Black;
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnNo.OnPressedState = stateProperties2;
            this.btnNo.Size = new System.Drawing.Size(114, 40);
            this.btnNo.TabIndex = 60;
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.TextMarginLeft = 0;
            this.btnNo.UseDefaultRadiusAndThickness = true;
            // 
            // frm_MessageYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MessageYesNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_MessageYesNo";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox icon;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblMessage;
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnYes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNo;
    }
}