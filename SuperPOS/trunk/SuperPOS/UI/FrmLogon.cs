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
using SuperPOS.Common;
using SuperPOS.UI.TA;

namespace SuperPOS.UI
{
    public partial class FrmLogon : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void FrmLogon_Load(object sender, EventArgs e)
        {
            #region 数字按钮Click
            btn1.Click += this.btn_Click;
            btn2.Click += this.btn_Click;
            btn3.Click += this.btn_Click;
            btn4.Click += this.btn_Click;
            btn5.Click += this.btn_Click;
            btn6.Click += this.btn_Click;
            btn7.Click += this.btn_Click;
            btn8.Click += this.btn_Click;
            btn9.Click += this.btn_Click;
            btn0.Click += this.btn_Click;
            #endregion

            //Date
            lblDate.Text = DateTime.Now.ToShortDateString();
            //Time
            lblTime.Text = DateTime.Now.ToShortTimeString();
            //获得Session
            lblSession.Text = CommonDAL.GetSession();
        }

        #region Timer空间
        private void tTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region Clear按钮
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPwd.Text = "";
        }

        #endregion

        #region Exit按钮
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        #endregion

        #region 数字按钮输入事件
        private void btn_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;

            txtPwd.Text += btn.Text;
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CommonDAL.IsUsr(txtPwd.Text))
            {
                int id = CommonDAL.GetUsrID(txtPwd.Text);

                if (id == 0)
                {
                    CommonTool.ShowMessage("Log in failure!");
                    txtPwd.Text = "";
                }
                else
                {
                    txtPwd.Text = "";
                    FrmTaAdminMain frmTaAdminMain = new FrmTaAdminMain(id);
                    frmTaAdminMain.ShowDialog();
                }
            }
            else
            {
                CommonTool.ShowMessage("Log in failure!");
                txtPwd.Text = "";
            }
        }
    }
}