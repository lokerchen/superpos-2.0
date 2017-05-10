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
        public FrmTaAdminMain()
        {
            InitializeComponent();
        }

        private void FrmTaAdminMain_Load(object sender, EventArgs e)
        {
            //treeMenu.ExpandAll();
        }

        private void ShiftCode_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            page.Name = "SysShiftCode"; //窗口名字
            page.Text = "Shift Code";//窗口标题
            if (!xtraTabControl1.TabPages.Any(s => s.Text.Equals(page.Text)))
            {
                
                FrmShiftCode frmShiftCode = new FrmShiftCode();
                frmShiftCode.TopLevel = false;
                frmShiftCode.Show();
                page.Controls.Add(frmShiftCode);
                this.xtraTabControl1.TabPages.Add(page);
            }
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages.FirstOrDefault(s => s.Text.Equals(page.Text));
        }

        private void SysExit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Close();
        }
    }
}