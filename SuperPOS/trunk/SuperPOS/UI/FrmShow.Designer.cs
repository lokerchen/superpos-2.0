namespace SuperPOS.UI
{
    partial class FrmShow
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogon = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemote = new DevExpress.XtraEditors.SimpleButton();
            this.btnOnline = new DevExpress.XtraEditors.SimpleButton();
            this.btnSoftUpgrade = new DevExpress.XtraEditors.SimpleButton();
            this.picImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(138, 439);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(412, 18);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Copyright @ 2017 All Right Reserved     Gwenwich (UK) Limited";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(140, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(410, 39);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "SuperPOS ePOS System V2.0";
            // 
            // btnLogon
            // 
            this.btnLogon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogon.Appearance.Options.UseFont = true;
            this.btnLogon.Location = new System.Drawing.Point(413, 341);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(314, 71);
            this.btnLogon.TabIndex = 11;
            this.btnLogon.Text = "Logon to SuperPOS";
            this.btnLogon.Click += new System.EventHandler(this.btnLogon_Click);
            // 
            // btnRemote
            // 
            this.btnRemote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemote.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemote.Appearance.Options.UseFont = true;
            this.btnRemote.Location = new System.Drawing.Point(413, 253);
            this.btnRemote.Name = "btnRemote";
            this.btnRemote.Size = new System.Drawing.Size(314, 71);
            this.btnRemote.TabIndex = 10;
            this.btnRemote.Text = "Remote Support";
            // 
            // btnOnline
            // 
            this.btnOnline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOnline.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnline.Appearance.Options.UseFont = true;
            this.btnOnline.Location = new System.Drawing.Point(413, 162);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(314, 71);
            this.btnOnline.TabIndex = 9;
            this.btnOnline.Text = "Milpo Online Takeaway NetShop";
            // 
            // btnSoftUpgrade
            // 
            this.btnSoftUpgrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSoftUpgrade.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftUpgrade.Appearance.Options.UseFont = true;
            this.btnSoftUpgrade.Location = new System.Drawing.Point(413, 71);
            this.btnSoftUpgrade.Name = "btnSoftUpgrade";
            this.btnSoftUpgrade.Size = new System.Drawing.Size(314, 71);
            this.btnSoftUpgrade.TabIndex = 8;
            this.btnSoftUpgrade.Text = "Software Upgrade And Licence";
            // 
            // picImg
            // 
            this.picImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picImg.Location = new System.Drawing.Point(8, 71);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(370, 350);
            this.picImg.TabIndex = 7;
            this.picImg.TabStop = false;
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 470);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnLogon);
            this.Controls.Add(this.btnRemote);
            this.Controls.Add(this.btnOnline);
            this.Controls.Add(this.btnSoftUpgrade);
            this.Controls.Add(this.picImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogon;
        private DevExpress.XtraEditors.SimpleButton btnRemote;
        private DevExpress.XtraEditors.SimpleButton btnOnline;
        private DevExpress.XtraEditors.SimpleButton btnSoftUpgrade;
        private System.Windows.Forms.PictureBox picImg;
    }
}