﻿using System;
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

        private void ShiftCode_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //XtraTabPage page = new XtraTabPage();
            //page.Name = "SysShiftCode"; //窗口名字
            //page.Text = "Shift Code";//窗口标题
            //if (!xtraTabControl1.TabPages.Any(s => s.Text.Equals(page.Text)))
            //{

            //    FrmShiftCode frmShiftCode = new FrmShiftCode();
            //    frmShiftCode.TopLevel = false;
            //    frmShiftCode.Show();
            //    page.Controls.Add(frmShiftCode);
            //    this.xtraTabControl1.TabPages.Add(page);
            //}
            //xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages.FirstOrDefault(s => s.Text.Equals(page.Text));
            ShowXtraTabPage("SysShiftCode", "Shift Code", new FrmShiftCode(usrID, usrName));
        }

        private void SysExit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Close();
        }

        #region User Setting
        private void UsrSet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //XtraTabPage page = new XtraTabPage();
            //page.Name = "UsrSet"; //窗口名字
            //page.Text = "User Setting";//窗口标题
            //if (!xtraTabControl1.TabPages.Any(s => s.Text.Equals(page.Text)))
            //{

            //    FrmUsrSet frmUsrSet = new FrmUsrSet(usrID, usrName);
            //    frmUsrSet.TopLevel = false;
            //    frmUsrSet.Show();
            //    page.Controls.Add(frmUsrSet);
            //    this.xtraTabControl1.TabPages.Add(page);
            //}
            //xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages.FirstOrDefault(s => s.Text.Equals(page.Text));
            ShowXtraTabPage("UsrSet", "User Setting", new FrmUsrSet(usrID, usrName));
        }
        #endregion

        #region Computer Address
        private void CompAdd_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //XtraTabPage page = new XtraTabPage();
            //page.Name = "CompAddr"; //窗口名字
            //page.Text = "Computer Address";//窗口标题
            //if (!xtraTabControl1.TabPages.Any(s => s.Text.Equals(page.Text)))
            //{

            //    FrmCompAddr frmUsrSet = new FrmCompAddr(usrID, usrName);
            //    frmUsrSet.TopLevel = false;
            //    frmUsrSet.Show();
            //    page.Controls.Add(frmUsrSet);
            //    this.xtraTabControl1.TabPages.Add(page);
            //}
            //xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages.FirstOrDefault(s => s.Text.Equals(page.Text));
            ShowXtraTabPage("CompAddr", "Computer Address", new FrmCompAddr(usrID, usrName));
        }
        #endregion

        #region Shop Details
        private void ShopDetail_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //XtraTabPage page = new XtraTabPage();
            //page.Name = "ShopDetail"; //窗口名字
            //page.Text = "Shop Details";//窗口标题
            //if (!xtraTabControl1.TabPages.Any(s => s.Text.Equals(page.Text)))
            //{

            //    FrmShopDetail frmShopDetail = new FrmShopDetail(usrID, usrName);
            //    frmShopDetail.TopLevel = false;
            //    frmShopDetail.Show();
            //    page.Controls.Add(frmShopDetail);
            //    this.xtraTabControl1.TabPages.Add(page);
            //}
            //xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages.FirstOrDefault(s => s.Text.Equals(page.Text));
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
    }
}