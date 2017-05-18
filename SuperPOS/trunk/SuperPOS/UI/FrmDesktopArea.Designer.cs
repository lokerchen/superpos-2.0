namespace SuperPOS.UI
{
    partial class FrmDesktopArea
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDrawer = new DevExpress.XtraEditors.SimpleButton();
            this.btnTakeaway = new DevExpress.XtraEditors.SimpleButton();
            this.btnEatIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuickFood = new DevExpress.XtraEditors.SimpleButton();
            this.btnCtlPanel = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            this.lblSession = new DevExpress.XtraEditors.LabelControl();
            this.lblUsrName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.Controls.Add(this.lblUsrName);
            this.panelControl1.Controls.Add(this.lblSession);
            this.panelControl1.Controls.Add(this.btnQuickFood);
            this.panelControl1.Controls.Add(this.btnEatIn);
            this.panelControl1.Controls.Add(this.btnTakeaway);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Location = new System.Drawing.Point(4, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(698, 559);
            this.panelControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnShowOrder);
            this.panel1.Controls.Add(this.btnCtlPanel);
            this.panel1.Controls.Add(this.btnDrawer);
            this.panel1.Location = new System.Drawing.Point(37, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 394);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(268, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(413, 84);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Desktop Area";
            // 
            // btnDrawer
            // 
            this.btnDrawer.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawer.Appearance.Options.UseFont = true;
            this.btnDrawer.Location = new System.Drawing.Point(8, 12);
            this.btnDrawer.Name = "btnDrawer";
            this.btnDrawer.Size = new System.Drawing.Size(155, 75);
            this.btnDrawer.TabIndex = 6;
            this.btnDrawer.Text = "Cash Drawer";
            // 
            // btnTakeaway
            // 
            this.btnTakeaway.Appearance.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeaway.Appearance.Options.UseFont = true;
            this.btnTakeaway.Location = new System.Drawing.Point(268, 156);
            this.btnTakeaway.Name = "btnTakeaway";
            this.btnTakeaway.Size = new System.Drawing.Size(352, 109);
            this.btnTakeaway.TabIndex = 2;
            this.btnTakeaway.Text = "Takeaway";
            this.btnTakeaway.Click += new System.EventHandler(this.btnTakeaway_Click);
            // 
            // btnEatIn
            // 
            this.btnEatIn.Appearance.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEatIn.Appearance.Options.UseFont = true;
            this.btnEatIn.Location = new System.Drawing.Point(268, 297);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(352, 109);
            this.btnEatIn.TabIndex = 3;
            this.btnEatIn.Text = "Eat In";
            // 
            // btnQuickFood
            // 
            this.btnQuickFood.Appearance.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickFood.Appearance.Options.UseFont = true;
            this.btnQuickFood.Location = new System.Drawing.Point(268, 433);
            this.btnQuickFood.Name = "btnQuickFood";
            this.btnQuickFood.Size = new System.Drawing.Size(352, 109);
            this.btnQuickFood.TabIndex = 4;
            this.btnQuickFood.Text = "Quick Food";
            // 
            // btnCtlPanel
            // 
            this.btnCtlPanel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtlPanel.Appearance.Options.UseFont = true;
            this.btnCtlPanel.Location = new System.Drawing.Point(8, 213);
            this.btnCtlPanel.Name = "btnCtlPanel";
            this.btnCtlPanel.Size = new System.Drawing.Size(155, 78);
            this.btnCtlPanel.TabIndex = 7;
            this.btnCtlPanel.Text = "Control Panel";
            this.btnCtlPanel.Click += new System.EventHandler(this.btnCtlPanel_Click);
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOrder.Appearance.Options.UseFont = true;
            this.btnShowOrder.Location = new System.Drawing.Point(8, 109);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(155, 78);
            this.btnShowOrder.TabIndex = 8;
            this.btnShowOrder.Text = "Show Order";
            // 
            // btnLogout
            // 
            this.btnLogout.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Appearance.Options.UseFont = true;
            this.btnLogout.Location = new System.Drawing.Point(8, 304);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(155, 78);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblSession
            // 
            this.lblSession.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(37, 62);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(108, 36);
            this.lblSession.TabIndex = 10;
            this.lblSession.Text = "DINNER";
            // 
            // lblUsrName
            // 
            this.lblUsrName.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrName.Location = new System.Drawing.Point(37, 104);
            this.lblUsrName.Name = "lblUsrName";
            this.lblUsrName.Size = new System.Drawing.Size(101, 36);
            this.lblUsrName.TabIndex = 11;
            this.lblUsrName.Text = "STAFF8";
            // 
            // FrmDesktopArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 594);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDesktopArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDesktopArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuickFood;
        private DevExpress.XtraEditors.SimpleButton btnEatIn;
        private DevExpress.XtraEditors.SimpleButton btnTakeaway;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnCtlPanel;
        private DevExpress.XtraEditors.SimpleButton btnDrawer;
        private DevExpress.XtraEditors.SimpleButton btnShowOrder;
        private DevExpress.XtraEditors.SimpleButton btnLogout;
        private DevExpress.XtraEditors.LabelControl lblUsrName;
        private DevExpress.XtraEditors.LabelControl lblSession;
    }
}