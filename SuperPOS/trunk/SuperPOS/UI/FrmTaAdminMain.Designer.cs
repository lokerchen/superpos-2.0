namespace SuperPOS.UI.TA
{
    partial class FrmTaAdminMain
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.SetSys = new DevExpress.XtraNavBar.NavBarGroup();
            this.SysConf = new DevExpress.XtraNavBar.NavBarItem();
            this.CompAdd = new DevExpress.XtraNavBar.NavBarItem();
            this.ShiftCode = new DevExpress.XtraNavBar.NavBarItem();
            this.ShopDetail = new DevExpress.XtraNavBar.NavBarItem();
            this.GenSet = new DevExpress.XtraNavBar.NavBarItem();
            this.KeypadSet = new DevExpress.XtraNavBar.NavBarItem();
            this.PrtSet = new DevExpress.XtraNavBar.NavBarItem();
            this.SysExit = new DevExpress.XtraNavBar.NavBarItem();
            this.SetTa = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem2 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.UsrAuth = new DevExpress.XtraNavBar.NavBarGroup();
            this.UsrSet = new DevExpress.XtraNavBar.NavBarItem();
            this.UsrAuthGroup = new DevExpress.XtraNavBar.NavBarItem();
            this.UsrAuthRule = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.FloatSize = new System.Drawing.Size(500, 561);
            this.dockPanel1.ID = new System.Guid("16aeaab6-9f5c-4043-8afd-ae9652e72e2a");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowAutoHideButton = false;
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(342, 200);
            this.dockPanel1.Size = new System.Drawing.Size(342, 712);
            this.dockPanel1.Text = "Control Panel";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(5, 28);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(332, 679);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.SetSys;
            this.navBarControl1.Appearance.Button.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Appearance.Button.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemActive.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Appearance.ItemActive.Options.UseFont = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.SetSys,
            this.SetTa,
            this.UsrAuth});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.SysConf,
            this.UsrSet,
            this.CompAdd,
            this.ShiftCode,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarItem11,
            this.navBarItem12,
            this.navBarItem13,
            this.SysExit,
            this.UsrAuthGroup,
            this.UsrAuthRule,
            this.navBarSeparatorItem2,
            this.navBarItem1,
            this.navBarSeparatorItem1,
            this.ShopDetail,
            this.GenSet,
            this.KeypadSet,
            this.PrtSet});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 332;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl1.Size = new System.Drawing.Size(332, 679);
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Summer 2008");
            // 
            // SetSys
            // 
            this.SetSys.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetSys.Appearance.Options.UseFont = true;
            this.SetSys.Caption = "System Setting";
            this.SetSys.Expanded = true;
            this.SetSys.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.SysConf),
            new DevExpress.XtraNavBar.NavBarItemLink(this.CompAdd),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ShiftCode),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ShopDetail),
            new DevExpress.XtraNavBar.NavBarItemLink(this.GenSet),
            new DevExpress.XtraNavBar.NavBarItemLink(this.KeypadSet),
            new DevExpress.XtraNavBar.NavBarItemLink(this.PrtSet),
            new DevExpress.XtraNavBar.NavBarItemLink(this.SysExit)});
            this.SetSys.Name = "SetSys";
            this.SetSys.ShowIcons = DevExpress.Utils.DefaultBoolean.False;
            // 
            // SysConf
            // 
            this.SysConf.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysConf.Appearance.Options.UseFont = true;
            this.SysConf.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysConf.AppearanceDisabled.Options.UseFont = true;
            this.SysConf.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysConf.AppearanceHotTracked.Options.UseFont = true;
            this.SysConf.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysConf.AppearancePressed.Options.UseFont = true;
            this.SysConf.Caption = "System Configuration";
            this.SysConf.Name = "SysConf";
            this.SysConf.Visible = false;
            // 
            // CompAdd
            // 
            this.CompAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompAdd.Appearance.Options.UseFont = true;
            this.CompAdd.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompAdd.AppearanceHotTracked.Options.UseFont = true;
            this.CompAdd.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompAdd.AppearancePressed.Options.UseFont = true;
            this.CompAdd.Caption = "Computer Address";
            this.CompAdd.Name = "CompAdd";
            this.CompAdd.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.CompAdd_LinkClicked);
            // 
            // ShiftCode
            // 
            this.ShiftCode.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftCode.Appearance.Options.UseFont = true;
            this.ShiftCode.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftCode.AppearanceHotTracked.Options.UseFont = true;
            this.ShiftCode.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftCode.AppearancePressed.Options.UseFont = true;
            this.ShiftCode.Caption = "Shift Code";
            this.ShiftCode.Name = "ShiftCode";
            this.ShiftCode.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ShiftCode_LinkClicked);
            // 
            // ShopDetail
            // 
            this.ShopDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopDetail.Appearance.Options.UseFont = true;
            this.ShopDetail.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopDetail.AppearanceDisabled.Options.UseFont = true;
            this.ShopDetail.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopDetail.AppearanceHotTracked.Options.UseFont = true;
            this.ShopDetail.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopDetail.AppearancePressed.Options.UseFont = true;
            this.ShopDetail.Caption = "Shop Detail";
            this.ShopDetail.Name = "ShopDetail";
            this.ShopDetail.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ShopDetail_LinkClicked);
            // 
            // GenSet
            // 
            this.GenSet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenSet.Appearance.Options.UseFont = true;
            this.GenSet.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenSet.AppearanceDisabled.Options.UseFont = true;
            this.GenSet.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenSet.AppearanceHotTracked.Options.UseFont = true;
            this.GenSet.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenSet.AppearancePressed.Options.UseFont = true;
            this.GenSet.Caption = "General Setting";
            this.GenSet.Name = "GenSet";
            this.GenSet.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.GenSet_LinkClicked);
            // 
            // KeypadSet
            // 
            this.KeypadSet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeypadSet.Appearance.Options.UseFont = true;
            this.KeypadSet.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeypadSet.AppearanceDisabled.Options.UseFont = true;
            this.KeypadSet.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeypadSet.AppearanceHotTracked.Options.UseFont = true;
            this.KeypadSet.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeypadSet.AppearancePressed.Options.UseFont = true;
            this.KeypadSet.Caption = "Keypad Setting";
            this.KeypadSet.Name = "KeypadSet";
            this.KeypadSet.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.KeypadSet_LinkClicked);
            // 
            // PrtSet
            // 
            this.PrtSet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrtSet.Appearance.Options.UseFont = true;
            this.PrtSet.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrtSet.AppearanceDisabled.Options.UseFont = true;
            this.PrtSet.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrtSet.AppearanceHotTracked.Options.UseFont = true;
            this.PrtSet.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrtSet.AppearancePressed.Options.UseFont = true;
            this.PrtSet.Caption = "Print Options";
            this.PrtSet.Name = "PrtSet";
            // 
            // SysExit
            // 
            this.SysExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysExit.Appearance.Options.UseFont = true;
            this.SysExit.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysExit.AppearanceHotTracked.Options.UseFont = true;
            this.SysExit.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysExit.AppearancePressed.Options.UseFont = true;
            this.SysExit.Caption = "Exit";
            this.SysExit.Name = "SysExit";
            this.SysExit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.SysExit_LinkClicked);
            // 
            // SetTa
            // 
            this.SetTa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTa.Appearance.Options.UseFont = true;
            this.SetTa.Caption = "Takeaway & Quick Dining Setting";
            this.SetTa.Expanded = true;
            this.SetTa.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem12),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem2)});
            this.SetTa.Name = "SetTa";
            this.SetTa.ShowIcons = DevExpress.Utils.DefaultBoolean.False;
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "navBarItem9";
            this.navBarItem9.Name = "navBarItem9";
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "navBarItem10";
            this.navBarItem10.Name = "navBarItem10";
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "navBarItem11";
            this.navBarItem11.Name = "navBarItem11";
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "navBarItem12";
            this.navBarItem12.Name = "navBarItem12";
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "navBarItem13";
            this.navBarItem13.Name = "navBarItem13";
            // 
            // navBarSeparatorItem2
            // 
            this.navBarSeparatorItem2.CanDrag = false;
            this.navBarSeparatorItem2.Enabled = false;
            this.navBarSeparatorItem2.Hint = null;
            this.navBarSeparatorItem2.LargeImageIndex = 0;
            this.navBarSeparatorItem2.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem2.Name = "navBarSeparatorItem2";
            this.navBarSeparatorItem2.SmallImageIndex = 0;
            this.navBarSeparatorItem2.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // UsrAuth
            // 
            this.UsrAuth.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrAuth.Appearance.Options.UseFont = true;
            this.UsrAuth.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrAuth.AppearanceHotTracked.Options.UseFont = true;
            this.UsrAuth.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrAuth.AppearancePressed.Options.UseFont = true;
            this.UsrAuth.Caption = "User Authorization";
            this.UsrAuth.Expanded = true;
            this.UsrAuth.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.UsrSet),
            new DevExpress.XtraNavBar.NavBarItemLink(this.UsrAuthGroup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.UsrAuthRule),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1)});
            this.UsrAuth.Name = "UsrAuth";
            this.UsrAuth.ShowIcons = DevExpress.Utils.DefaultBoolean.False;
            // 
            // UsrSet
            // 
            this.UsrSet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrSet.Appearance.Options.UseFont = true;
            this.UsrSet.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrSet.AppearanceHotTracked.Options.UseFont = true;
            this.UsrSet.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrSet.AppearancePressed.Options.UseFont = true;
            this.UsrSet.Caption = "User Setting";
            this.UsrSet.Name = "UsrSet";
            this.UsrSet.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.UsrSet_LinkClicked);
            // 
            // UsrAuthGroup
            // 
            this.UsrAuthGroup.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrAuthGroup.Appearance.Options.UseFont = true;
            this.UsrAuthGroup.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrAuthGroup.AppearanceDisabled.Options.UseFont = true;
            this.UsrAuthGroup.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrAuthGroup.AppearanceHotTracked.Options.UseFont = true;
            this.UsrAuthGroup.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrAuthGroup.AppearancePressed.Options.UseFont = true;
            this.UsrAuthGroup.Caption = "Authority Group";
            this.UsrAuthGroup.Name = "UsrAuthGroup";
            // 
            // UsrAuthRule
            // 
            this.UsrAuthRule.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrAuthRule.Appearance.Options.UseFont = true;
            this.UsrAuthRule.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrAuthRule.AppearanceHotTracked.Options.UseFont = true;
            this.UsrAuthRule.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrAuthRule.AppearancePressed.Options.UseFont = true;
            this.UsrAuthRule.Caption = "Authority Rule";
            this.UsrAuthRule.Name = "UsrAuthRule";
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.LargeImageIndex = 0;
            this.navBarSeparatorItem1.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            this.navBarSeparatorItem1.SmallImageIndex = 0;
            this.navBarSeparatorItem1.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "navBarItem5";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "navBarItem6";
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "navBarItem7";
            this.navBarItem7.Name = "navBarItem7";
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "navBarItem8";
            this.navBarItem8.Name = "navBarItem8";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "User Setting";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(342, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1015, 712);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1008, 676);
            this.xtraTabPage1.Text = "Admin Control";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(997, 615);
            // 
            // FrmTaAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 712);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.dockPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTaAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTaAdminMain";
            this.Load += new System.EventHandler(this.FrmTaAdminMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup SetSys;
        private DevExpress.XtraNavBar.NavBarGroup SetTa;
        private DevExpress.XtraNavBar.NavBarItem SysConf;
        private DevExpress.XtraNavBar.NavBarItem UsrSet;
        private DevExpress.XtraNavBar.NavBarItem CompAdd;
        private DevExpress.XtraNavBar.NavBarItem ShiftCode;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem12;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraNavBar.NavBarItem SysExit;
        private DevExpress.XtraNavBar.NavBarGroup UsrAuth;
        private DevExpress.XtraNavBar.NavBarItem UsrAuthGroup;
        private DevExpress.XtraNavBar.NavBarItem UsrAuthRule;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem2;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem ShopDetail;
        private DevExpress.XtraNavBar.NavBarItem GenSet;
        private DevExpress.XtraNavBar.NavBarItem KeypadSet;
        private DevExpress.XtraNavBar.NavBarItem PrtSet;
    }
}