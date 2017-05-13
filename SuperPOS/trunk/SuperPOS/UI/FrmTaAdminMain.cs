using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using SuperPOS.UI.Sys;

namespace SuperPOS.UI.TA
{
    public partial class FrmTaAdminMain : DevExpress.XtraEditors.XtraForm
    {
        //用户ID
        public int usrID = 0;
        //用户姓名
        public string usrName = "";

        public FrmTaAdminMain()
        {
            InitializeComponent();
        }

        public FrmTaAdminMain(int uID, string sName)
        {
            InitializeComponent();
            usrID = uID;
            usrName = sName;
        }

        private void FrmTaAdminMain_Load(object sender, EventArgs e)
        {
            //treeMenu.ExpandAll();
        }

        #region Shift Code
        private void ShiftCode_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowXtraTabPage("SysShiftCode", "Shift Code", new FrmShiftCode(usrID, usrName));
        }
        #endregion

        #region Exit
        private void SysExit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region User Setting
        private void UsrSet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowXtraTabPage("UsrSet", "User Setting", new FrmUsrSet(usrID, usrName));
        }
        #endregion

        #region Computer Address
        private void CompAdd_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowXtraTabPage("CompAddr", "Computer Address", new FrmCompAddr(usrID, usrName));
        }
        #endregion

        #region Shop Details
        private void ShopDetail_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowXtraTabPage("ShopDetail", "Shop Details", new FrmShopDetail(usrID, usrName));
        }
        #endregion

        #region 显示XtraTabPage
        /// <summary>
        /// 显示XtraTabPage
        /// </summary>
        /// <param name="pageName">窗口名字</param>
        /// <param name="pageText">窗口标题</param>
        /// <param name="frmObject">窗口实例</param>
        private void ShowXtraTabPage(string pageName, string pageText, Form frmObject)
        {
            XtraTabPage page = new XtraTabPage();
            page.Name = pageName; //窗口名字
            page.Text = pageText;//窗口标题
            if (!xtraTabControl1.TabPages.Any(s => s.Text.Equals(page.Text)))
            {

                Form frm = frmObject;
                frm.TopLevel = false;
                frm.Show();
                page.Controls.Add(frm);
                this.xtraTabControl1.TabPages.Add(page);
            }
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages.FirstOrDefault(s => s.Text.Equals(page.Text));
        }
        #endregion

        #region General Setting
        private void GenSet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowXtraTabPage("GenSet", "General Setting", new FrmGenSet(usrID, usrName));
        }
        #endregion

        #region Keypad Setting
        private void KeypadSet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowXtraTabPage("KeypadSet", "Keypad Setting", new FrmKeyPadSet(usrID, usrName));
        }
        #endregion

        #region Printer Setting
        private void SysPrt_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowXtraTabPage("SysPrt", "Printer Setting", new FrmPrtSet(usrID, usrName));
        }
        #endregion

    }
}