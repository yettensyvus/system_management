
namespace dashboard { 
    partial class frm_ground_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ground_management));
            this.panel_Child = new System.Windows.Forms.Panel();
            this.btnQuery = new MetroFramework.Controls.MetroTile();
            this.btnHarvest = new MetroFramework.Controls.MetroTile();
            this.btnGraph = new MetroFramework.Controls.MetroTile();
            this.btnPlanting = new MetroFramework.Controls.MetroTile();
            this.btnCote = new MetroFramework.Controls.MetroTile();
            this.panel_Child.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Child
            // 
            this.panel_Child.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.panel_Child.Controls.Add(this.btnQuery);
            this.panel_Child.Controls.Add(this.btnHarvest);
            this.panel_Child.Controls.Add(this.btnGraph);
            this.panel_Child.Controls.Add(this.btnPlanting);
            this.panel_Child.Controls.Add(this.btnCote);
            this.panel_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Child.Location = new System.Drawing.Point(0, 0);
            this.panel_Child.Name = "panel_Child";
            this.panel_Child.Size = new System.Drawing.Size(731, 491);
            this.panel_Child.TabIndex = 113;
            // 
            // btnQuery
            // 
            this.btnQuery.ActiveControl = null;
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(23, 333);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(276, 132);
            this.btnQuery.Style = MetroFramework.MetroColorStyle.Black;
            this.btnQuery.TabIndex = 119;
            this.btnQuery.Text = "Queries";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuery.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnQuery.TileImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.TileImage")));
            this.btnQuery.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuery.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnQuery.UseCustomBackColor = true;
            this.btnQuery.UseCustomForeColor = true;
            this.btnQuery.UseSelectable = true;
            this.btnQuery.UseStyleColors = true;
            this.btnQuery.UseTileImage = true;
            // 
            // btnHarvest
            // 
            this.btnHarvest.ActiveControl = null;
            this.btnHarvest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHarvest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHarvest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHarvest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHarvest.ForeColor = System.Drawing.Color.White;
            this.btnHarvest.Location = new System.Drawing.Point(524, 26);
            this.btnHarvest.Name = "btnHarvest";
            this.btnHarvest.Size = new System.Drawing.Size(183, 276);
            this.btnHarvest.Style = MetroFramework.MetroColorStyle.Black;
            this.btnHarvest.TabIndex = 118;
            this.btnHarvest.Text = "Recolta";
            this.btnHarvest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHarvest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnHarvest.TileImage = ((System.Drawing.Image)(resources.GetObject("btnHarvest.TileImage")));
            this.btnHarvest.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHarvest.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnHarvest.UseCustomBackColor = true;
            this.btnHarvest.UseCustomForeColor = true;
            this.btnHarvest.UseSelectable = true;
            this.btnHarvest.UseStyleColors = true;
            this.btnHarvest.UseTileImage = true;
            this.btnHarvest.Click += new System.EventHandler(this.btnHarvest_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.ActiveControl = null;
            this.btnGraph.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraph.ForeColor = System.Drawing.Color.White;
            this.btnGraph.Location = new System.Drawing.Point(335, 330);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(372, 135);
            this.btnGraph.Style = MetroFramework.MetroColorStyle.Black;
            this.btnGraph.TabIndex = 117;
            this.btnGraph.Text = "Grafice";
            this.btnGraph.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGraph.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGraph.TileImage = ((System.Drawing.Image)(resources.GetObject("btnGraph.TileImage")));
            this.btnGraph.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGraph.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnGraph.UseCustomBackColor = true;
            this.btnGraph.UseCustomForeColor = true;
            this.btnGraph.UseSelectable = true;
            this.btnGraph.UseStyleColors = true;
            this.btnGraph.UseTileImage = true;
            // 
            // btnPlanting
            // 
            this.btnPlanting.ActiveControl = null;
            this.btnPlanting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlanting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlanting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnPlanting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanting.ForeColor = System.Drawing.Color.White;
            this.btnPlanting.Location = new System.Drawing.Point(335, 26);
            this.btnPlanting.Name = "btnPlanting";
            this.btnPlanting.Size = new System.Drawing.Size(183, 276);
            this.btnPlanting.Style = MetroFramework.MetroColorStyle.Black;
            this.btnPlanting.TabIndex = 116;
            this.btnPlanting.Text = "Planting";
            this.btnPlanting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlanting.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPlanting.TileImage = ((System.Drawing.Image)(resources.GetObject("btnPlanting.TileImage")));
            this.btnPlanting.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlanting.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnPlanting.UseCustomBackColor = true;
            this.btnPlanting.UseCustomForeColor = true;
            this.btnPlanting.UseSelectable = true;
            this.btnPlanting.UseStyleColors = true;
            this.btnPlanting.UseTileImage = true;
            this.btnPlanting.Click += new System.EventHandler(this.btnPlanting_Click);
            // 
            // btnCote
            // 
            this.btnCote.ActiveControl = null;
            this.btnCote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnCote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCote.ForeColor = System.Drawing.Color.White;
            this.btnCote.Location = new System.Drawing.Point(23, 26);
            this.btnCote.Name = "btnCote";
            this.btnCote.Size = new System.Drawing.Size(276, 276);
            this.btnCote.Style = MetroFramework.MetroColorStyle.Black;
            this.btnCote.TabIndex = 112;
            this.btnCote.Text = "Lista Cote";
            this.btnCote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCote.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCote.TileImage = ((System.Drawing.Image)(resources.GetObject("btnCote.TileImage")));
            this.btnCote.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCote.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnCote.UseCustomBackColor = true;
            this.btnCote.UseCustomForeColor = true;
            this.btnCote.UseSelectable = true;
            this.btnCote.UseStyleColors = true;
            this.btnCote.UseTileImage = true;
            this.btnCote.Click += new System.EventHandler(this.btnCote_Click);
            // 
            // frm_ground_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(731, 491);
            this.Controls.Add(this.panel_Child);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ground_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ground_management";
            this.panel_Child.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Panel panel_Child;
    private MetroFramework.Controls.MetroTile btnQuery;
    private MetroFramework.Controls.MetroTile btnHarvest;
    private MetroFramework.Controls.MetroTile btnGraph;
    private MetroFramework.Controls.MetroTile btnPlanting;
    private MetroFramework.Controls.MetroTile btnCote;
}
}