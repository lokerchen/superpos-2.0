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
            this.lblUsrName = new DevExpress.XtraEditors.LabelControl();
            this.lblSession = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnCtlPanel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDrawer = new DevExpress.XtraEditors.SimpleButton();
            this.btnOrder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLogout);
            this.panelControl1.Controls.Add(this.lblUsrName);
            this.panelControl1.Controls.Add(this.btnCtlPanel);
            this.panelControl1.Controls.Add(this.btnShowOrder);
            this.panelControl1.Controls.Add(this.lblSession);
            this.panelControl1.Controls.Add(this.btnOrder);
            this.panelControl1.Controls.Add(this.btnDrawer);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(4, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(439, 559);
            this.panelControl1.TabIndex = 0;
            // 
            // lblUsrName
            // 
            this.lblUsrName.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrName.Location = new System.Drawing.Point(36, 339);
            this.lblUsrName.Name = "lblUsrName";
            this.lblUsrName.Size = new System.Drawing.Size(101, 36);
            this.lblUsrName.TabIndex = 11;
            this.lblUsrName.Text = "STAFF8";
            // 
            // lblSession
            // 
            this.lblSession.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(36, 297);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(108, 36);
            this.lblSession.TabIndex = 10;
            this.lblSession.Text = "DINNER";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(36, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(355, 84);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Home Page";
            // 
            // btnLogout
            // 
            this.btnLogout.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Appearance.Options.UseFont = true;
            this.btnLogout.Location = new System.Drawing.Point(230, 469);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 80);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOrder.Appearance.Options.UseFont = true;
            this.btnShowOrder.Location = new System.Drawing.Point(230, 297);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(190, 80);
            this.btnShowOrder.TabIndex = 8;
            this.btnShowOrder.Text = "Show Order";
            // 
            // btnCtlPanel
            // 
            this.btnCtlPanel.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtlPanel.Appearance.Options.UseFont = true;
            this.btnCtlPanel.Location = new System.Drawing.Point(230, 383);
            this.btnCtlPanel.Name = "btnCtlPanel";
            this.btnCtlPanel.Size = new System.Drawing.Size(190, 80);
            this.btnCtlPanel.TabIndex = 7;
            this.btnCtlPanel.Text = "Control Panel";
            this.btnCtlPanel.Click += new System.EventHandler(this.btnCtlPanel_Click);
            // 
            // btnDrawer
            // 
            this.btnDrawer.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawer.Appearance.Options.UseFont = true;
            this.btnDrawer.Location = new System.Drawing.Point(230, 211);
            this.btnDrawer.Name = "btnDrawer";
            this.btnDrawer.Size = new System.Drawing.Size(190, 80);
            this.btnDrawer.TabIndex = 6;
            this.btnDrawer.Text = "Cash Drawer";
            // 
            // btnOrder
            // 
            this.btnOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Appearance.Options.UseFont = true;
            this.btnOrder.Location = new System.Drawing.Point(230, 124);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(190, 80);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // FrmDesktopArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 572);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDesktopArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDesktopArea_Load);
            this.SizeChanged += new System.EventHandler(this.FrmDesktopArea_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCtlPanel;
        private DevExpress.XtraEditors.SimpleButton btnDrawer;
        private DevExpress.XtraEditors.SimpleButton btnShowOrder;
        private DevExpress.XtraEditors.SimpleButton btnLogout;
        private DevExpress.XtraEditors.LabelControl lblUsrName;
        private DevExpress.XtraEditors.LabelControl lblSession;
        private DevExpress.XtraEditors.SimpleButton btnOrder;
    }
}