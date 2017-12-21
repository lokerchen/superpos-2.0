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

namespace SuperPOS.UI.TA
{
    public partial class FrmTaKeyPad : DevExpress.XtraEditors.XtraForm
    {
        //Key按钮
        private SimpleButton[] btnKey = new SimpleButton[10];

        public string DisCode
        {
            get { return txtDishCode.Text; }
            set { DisCode = value; }
        }

        public string Qty
        {
            get { return txtQty.Text; }
            set { Qty = value; }
        }

        public FrmTaKeyPad()
        {
            InitializeComponent();
        }

        #region 数字按钮输入事件
        private void btn_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;

            txtDishCode.Text += btn.Text;
        }
        #endregion

        private void FrmTaKeyPad_Load(object sender, EventArgs e)
        {
            #region 按钮Click
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
            btnP.Click += this.btn_Click;

            btnQty1.Click += btnQty_Click;
            btnQty2.Click += btnQty_Click;
            btnQty3.Click += btnQty_Click;
            btnQty4.Click += btnQty_Click;
            btnQty5.Click += btnQty_Click;

            btnKey1.Click += btnKey_Ckick;
            btnKey2.Click += btnKey_Ckick;
            btnKey3.Click += btnKey_Ckick;
            btnKey4.Click += btnKey_Ckick;
            btnKey5.Click += btnKey_Ckick;
            btnKey6.Click += btnKey_Ckick;
            btnKey7.Click += btnKey_Ckick;
            btnKey8.Click += btnKey_Ckick;
            btnKey9.Click += btnKey_Ckick;
            btnKey10.Click += btnKey_Ckick;
            #endregion

            btnKey[0] = btnKey1;
            btnKey[1] = btnKey2;
            btnKey[2] = btnKey3;
            btnKey[3] = btnKey4;
            btnKey[4] = btnKey5;
            btnKey[5] = btnKey6;
            btnKey[6] = btnKey7;
            btnKey[7] = btnKey8;
            btnKey[8] = btnKey9;
            btnKey[9] = btnKey10;

            int i = 0;
            foreach (var keypadInfo in CommonData.Keypad)
            {
                btnKey[i].Text = keypadInfo.KeyCode;
                i++;
            }

            for (int j = i; j < 10; j++)
            {
                btnKey[j].Text = "";
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtDishCode.Text = txtDishCode.Text.Substring(0, txtDishCode.TextLength - 1);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDishCode.Text = "";
        }

        private void btnQty_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            txtQty.Text = btn.Text.Substring(1, btn.Text.Length - 1);
        }

        private void btnKey_Ckick(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            txtDishCode.Text += btn.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Hide();
        }
    }
}