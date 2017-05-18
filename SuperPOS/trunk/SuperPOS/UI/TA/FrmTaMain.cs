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

namespace SuperPOS.UI.TA
{
    public partial class FrmTaMain : DevExpress.XtraEditors.XtraForm
    {
        //操作用户ID
        private int usrID;

        //MenuItem按钮
        private SimpleButton[] btnMenuItem = new SimpleButton[32];
        //ManuCate按钮
        private SimpleButton[] btnMenuCate = new SimpleButton[12];

        public FrmTaMain()
        {
            InitializeComponent();
        }

        public FrmTaMain(int id)
        {
            InitializeComponent();
            usrID = id;
        }

        #region 显示TreeList行号
        private void treeListOrder_CustomDrawNodeIndicator(object sender, DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs e)
        {
            DevExpress.XtraTreeList.TreeList tmpTree = sender as DevExpress.XtraTreeList.TreeList;
            DevExpress.Utils.Drawing.IndicatorObjectInfoArgs args = e.ObjectArgs as DevExpress.Utils.Drawing.IndicatorObjectInfoArgs;
            if (args != null)
            {
                int rowNum = tmpTree.GetVisibleIndexByNode(e.Node) + 1;
                this.treeListOrder.IndicatorWidth = rowNum.ToString().Length * 10 + 10;
                args.DisplayText = rowNum.ToString();
            }
        }
        #endregion

        #region 设置MenuItem按钮
        /// <summary>
        /// 设置MenuItem按钮
        /// </summary>
        private void SetMiBtn()
        {
            btnMenuItem[0] = btnMi0;
            btnMenuItem[1] = btnMi1;
            btnMenuItem[2] = btnMi2;
            btnMenuItem[3] = btnMi3;
            btnMenuItem[4] = btnMi4;
            btnMenuItem[5] = btnMi5;
            btnMenuItem[6] = btnMi6;
            btnMenuItem[7] = btnMi7;
            btnMenuItem[8] = btnMi8;
            btnMenuItem[9] = btnMi9;
            btnMenuItem[10] = btnMi10;
            btnMenuItem[11] = btnMi11;
            btnMenuItem[12] = btnMi12;
            btnMenuItem[13] = btnMi13;
            btnMenuItem[14] = btnMi14;
            btnMenuItem[15] = btnMi15;

            for (int i = 0; i < 16; i++)
            {
                btnMenuItem[i].Click += btnMenuItem_Click;
            }
        }
        #endregion

        #region MenuItem 点击
        /// <summary>
        /// MenuItem 点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region 设置MenuCate按钮
        /// <summary>
        /// 设置MenuCate按钮
        /// </summary>
        private void SetMenuCateBtn()
        {
            btnMenuCate[0] = btnMc0;
            btnMenuCate[1] = btnMc1;
            btnMenuCate[2] = btnMc2;
            btnMenuCate[3] = btnMc3;
            btnMenuCate[4] = btnMc4;
            btnMenuCate[5] = btnMc5;
            btnMenuCate[6] = btnMc6;
            btnMenuCate[7] = btnMc7;
            btnMenuCate[8] = btnMc9;
            btnMenuCate[9] = btnMc10;
            btnMenuCate[10] = btnMc10;
            btnMenuCate[11] = btnMc11;
            btnMenuCate[12] = btnMc12;
            btnMenuCate[13] = btnMc13;
            btnMenuCate[14] = btnMc14;
            btnMenuCate[15] = btnMc15;
            btnMenuCate[16] = btnMc16;
            btnMenuCate[17] = btnMc17;
            btnMenuCate[18] = btnMc18;
            btnMenuCate[19] = btnMc19;
            btnMenuCate[20] = btnMc20;
            btnMenuCate[21] = btnMc21;
            btnMenuCate[22] = btnMc22;
            btnMenuCate[23] = btnMc23;
            btnMenuCate[24] = btnMc24;
            btnMenuCate[25] = btnMc25;
            btnMenuCate[26] = btnMc26;
            btnMenuCate[27] = btnMc27;
            btnMenuCate[28] = btnMc28;
            btnMenuCate[29] = btnMc29;
            btnMenuCate[30] = btnMc30;
            btnMenuCate[31] = btnMc31;
            btnMenuCate[32] = btnMc32;
            btnMenuCate[33] = btnMc33;
            btnMenuCate[34] = btnMc34;
            btnMenuCate[35] = btnMc35;
            btnMenuCate[36] = btnMc36;
            btnMenuCate[37] = btnMc37;
            btnMenuCate[38] = btnMc38;
            btnMenuCate[39] = btnMc39;
            btnMenuCate[40] = btnMc40;
            btnMenuCate[41] = btnMc41;

            for (int i = 0; i < 42; i++)
            {
                btnMenuCate[i].Click += btnMenuCate_Click;
            }
        }
        #endregion

        #region MenuCate 点击
        /// <summary>
        /// MenuCate 点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenuCate_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {

        }
    }
}