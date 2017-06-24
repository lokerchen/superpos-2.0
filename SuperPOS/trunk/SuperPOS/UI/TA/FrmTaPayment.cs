﻿using System;
using System.Collections;
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
using SuperPOS.Domain.Entities;

namespace SuperPOS.UI.TA
{
    public partial class FrmTaPayment : DevExpress.XtraEditors.XtraForm
    {
        //账单编号
        private string checkID = "";
        //用户ID
        private int usrID;
        //操作类型
        private string orderType = "";
        //呼入电话ID
        private string callerID = "";
        //付款方式数组
        private CheckEdit[] chkPayType = new CheckEdit[4];
        //司机列表
        private CheckEdit[] chkDriver = new CheckEdit[12];

        private readonly EntityControl _control = new EntityControl();

        private Hashtable htDetail = new Hashtable();

        //是否已经付完款
        public bool returnPaid = false;

        #region 构造函数
        public FrmTaPayment()
        {
            InitializeComponent();
        }

        public FrmTaPayment(int id, string chkId, string type, string caller, Hashtable ht)
        {
            InitializeComponent();
            usrID = id;
            checkID = chkId;
            orderType = type;
            callerID = caller;
            htDetail = ht;
        }
        #endregion

        #region 事件

        #region 窗体加载时
        private void FrmTaPayment_Load(object sender, EventArgs e)
        {
            //模块显示
            GetOrderTypeShowPanel(orderType);

            SetClick();

            //会员信息
            GetCustomer();

            SetChkType();
            SetChkDriver();

            //付款数据
            BindData(checkID);
            //账单数据
            GetChk(checkID);
            //来电客户信息
            GetCustomer(callerID);

            txtPaid.Text = GetPayDetail(checkID).ToString();
            txtToPay.Text = (Convert.ToDecimal(txtTotal.Text) - GetPayDetail(checkID)).ToString();
        }
        #endregion

        #region 数字按钮输入事件
        private void btn_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;

            if (!string.IsNullOrEmpty(txtPay.Text))
            {
                if (Convert.ToDecimal(txtPay.Text) > 0.00m)
                    txtPay.Text += btn.Text;
                else
                    txtPay.Text = btn.Text;
            }
            else
            {
                txtPay.Text = btn.Text;
            }
        }
        #endregion

        #region Del按键
        private void btnDel_Click(object sender, EventArgs e)
        {
            txtPay.Text = txtPay.Text.Length > 0 ? txtPay.Text.Substring(0, txtPay.Text.Length - 1) : "0.00";
        }
        #endregion

        #region Clear按键
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPay.Text = "0.00";
        }
        #endregion

        #region Payment Type点击事件
        private void chkPayType_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit chkPayType = (CheckEdit)sender;

            switch (chkPayType.Name)
            {
                case "chkPayType0":
                    if (chkPayType.Checked)
                    {
                        chkPayType1.Checked = false;
                        chkPayType2.Checked = false;
                        chkPayType3.Checked = false;
                    }
                    break;
                case "chkPayType1":
                    if (chkPayType.Checked)
                    {
                        chkPayType0.Checked = false;
                        chkPayType2.Checked = false;
                        chkPayType3.Checked = false;
                    }
                    break;
                case "chkPayType2":
                    if (chkPayType.Checked)
                    {
                        chkPayType0.Checked = false;
                        chkPayType1.Checked = false;
                        chkPayType3.Checked = false;
                    }
                    break;
                case "chkPayType3":
                    if (chkPayType.Checked)
                    {
                        chkPayType0.Checked = false;
                        chkPayType1.Checked = false;
                        chkPayType2.Checked = false;
                    }
                    break;
                default:
                    chkPayType0.Checked = false;
                    chkPayType1.Checked = false;
                    chkPayType2.Checked = false;
                    chkPayType3.Checked = false;
                    break;
            }
        }
        #endregion

        #region Driver点击事件
        private void chkDriver_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit chkDr = (CheckEdit)sender;

            switch (chkDr.Name)
            {
                case "chkDriver0":
                    if (chkDr.Checked)
                    {
                        for (int i = 1; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver1":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 1; i++) { chkDriver[i].Checked = false; }
                        for (int i = 2; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver2":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 2; i++) { chkDriver[i].Checked = false; }
                        for (int i = 3; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver3":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 3; i++) { chkDriver[i].Checked = false; }
                        for (int i = 4; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver4":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 4; i++) { chkDriver[i].Checked = false; }
                        for (int i = 5; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver5":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 5; i++) { chkDriver[i].Checked = false; }
                        for (int i = 6; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver6":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 6; i++) { chkDriver[i].Checked = false; }
                        for (int i = 7; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver7":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 7; i++) { chkDriver[i].Checked = false; }
                        for (int i = 8; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver8":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 8; i++) { chkDriver[i].Checked = false; }
                        for (int i = 9; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver9":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 9; i++) { chkDriver[i].Checked = false; }
                        for (int i = 10; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver10":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 10; i++) { chkDriver[i].Checked = false; }
                        for (int i = 11; i < 12; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                case "chkDriver11":
                    if (chkDr.Checked)
                    {
                        for (int i = 0; i < 11; i++) { chkDriver[i].Checked = false; }
                    }
                    break;
                default:
                    for (int i = 0; i < 12; i++) { chkDriver[i].Checked = false; }
                    break;
            }
        }
        #endregion

        #region Exit按钮
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtPay.Text) <= 0m) return;

            #region 是否选中付款类型
            //付款必选
            bool isSelectPayType = chkPayType.Any(t => t.Checked);

            int iPT = 0;
            for (int i = 0; i < chkPayType.Length; i++)
            {
                if (chkPayType[i].Checked)
                {
                    iPT = i;
                    break;
                }
            }
            #endregion

            #region 是否选中司机
            //司机必选
            bool isSelectDriver = chkDriver.Any(t => t.Checked);
            int iDriver = 0;
            for (int i = 0; i < chkDriver.Length; i++)
            {
                if (chkDriver[i].Checked)
                {
                    iDriver = i;
                    break;
                }
            }
            #endregion

            if (orderType.Equals(PubComm.ORDER_TYPE_SHOP))
            {
                if (!isSelectPayType)
                { 
                    CommonTool.ShowMessage("Please select a payment type!");
                    return;
                }

                SaveOrder(iPT, 0);
            }
            else if (orderType.Equals(PubComm.ORDER_TYPE_COLLECTION))
            {
                if (!isSelectPayType)
                {
                    CommonTool.ShowMessage("Please select a payment type!");
                    return;
                }

                SaveOrder(iPT, 0);
            }
            else if (orderType.Equals(PubComm.ORDER_TYPE_DELIVERY))
            {
                //未选择付款方式
                //提示选择付款方式  
                //未选择司机
                //提示选择司机

                if (!isSelectPayType)
                {
                    CommonTool.ShowMessage("Please select a payment type!");
                    return;
                }

                if (!isSelectDriver)
                {
                    CommonTool.ShowMessage("Please select a Driver!");
                    return;
                }

                SaveOrder(iPT, iDriver);
            }


        }

        #endregion

        #region 方法

        #region 根据账单类型判断会员模块和司机按钮模块是否需要显示
        /// <summary>
        /// 根据账单类型判断会员模块和司机按钮模块是否需要显示
        /// </summary>
        /// <param name="oType">账单类型</param>
        private void GetOrderTypeShowPanel(string oType)
        {
            if (!string.IsNullOrEmpty(oType))
            {
                if (oType.Equals(PubComm.ORDER_TYPE_SHOP))
                {
                    panelDriver.Visible = false;
                    panelMember.Visible = false;
                }
                else if (oType.Equals(PubComm.ORDER_TYPE_COLLECTION))
                {
                    panelDriver.Visible = false;
                    panelMember.Visible = true;
                }
                else if (oType.Equals(PubComm.ORDER_TYPE_DELIVERY))
                {
                    panelDriver.Visible = true;
                    panelMember.Visible = true;
                }
            }
            else
            {
                //默认为SHOP
                panelDriver.Visible = false;
                panelMember.Visible = false;
            } 
        }
        #endregion

        #region 显示会员信息
        /// <summary>
        /// 显示会员信息
        /// </summary>
        private void GetCustomer()
        {
            if (!string.IsNullOrEmpty(callerID))
            {
                new SystemData().GetTaCustomer();

                var lstCus = CommonData.TaCustomer.Where(s => s.cusPhone.Equals(callerID));

                if (lstCus.Any())
                {
                    TaCustomerInfo taCustomerInfo = lstCus.FirstOrDefault();
                    txtPhone.Text = taCustomerInfo.cusPhone;
                    txtName.Text = taCustomerInfo.cusName;
                    txtHouseNo.Text = taCustomerInfo.cusHouseNo;
                    txtAddr.Text = taCustomerInfo.cusAddr;
                    txtPostcode.Text = taCustomerInfo.cusPostcode;
                    txtDistance.Text = taCustomerInfo.cusDistance;
                    txtPcZone.Text = taCustomerInfo.cusPcZone;
                    txtDelCharge.Text = taCustomerInfo.cusDelCharge;
                    txtReadyTime.Text = taCustomerInfo.cusReadyTime;
                    txtIntNotes.Text = taCustomerInfo.cusIntNotes;
                    txtNoteOnBill.Text = taCustomerInfo.cusNotesOnBill;
                    chkBlackList.Checked = taCustomerInfo.cusIsBlack.Equals("Y") ? true : false;
                    txtNote.Text = taCustomerInfo.cusNote;
                }
            }
        }
        #endregion

        #region 设置Payment Type
        /// <summary>
        /// 设置Payment Type
        /// </summary>
        private void SetChkType()
        {
            chkPayType[0] = chkPayType0;
            chkPayType[1] = chkPayType1;
            chkPayType[2] = chkPayType2;
            chkPayType[3] = chkPayType3;

            int i = 0;
            foreach (var taPaymentTypeInfo in CommonData.TaPaymentType)
            {
                chkPayType[i].Text = taPaymentTypeInfo.PaymentType;
                i++;
            }

            for (int j = i; j < 4; j++)
            {
                chkPayType[j].Visible = false;
            }

            for (int j = 0; j < 4; j++)
            {
                chkPayType[j].CheckedChanged += this.chkPayType_CheckedChanged;
            }
        }
        #endregion

        #region 设置Driver
        /// <summary>
        /// 设置Driver
        /// </summary>
        private void SetChkDriver()
        {
            chkDriver[0] = chkDriver0;
            chkDriver[1] = chkDriver1;
            chkDriver[2] = chkDriver2;
            chkDriver[3] = chkDriver3;
            chkDriver[4] = chkDriver4;
            chkDriver[5] = chkDriver5;
            chkDriver[6] = chkDriver6;
            chkDriver[7] = chkDriver7;
            chkDriver[8] = chkDriver8;
            chkDriver[9] = chkDriver9;
            chkDriver[10] = chkDriver10;
            chkDriver[11] = chkDriver11;

            int i = 0;
            foreach (var d in CommonData.TaDriver)
            {
                chkDriver[i].Text = d.DriverName;
                i++;
            }

            for (int j = i; j < 12; j++)
            {
                chkDriver[j].Visible = false;
            }

            for (int j = 0; j < 12; j++)
            {
                chkDriver[j].CheckedChanged += this.chkDriver_CheckedChanged;
            }
        }
        #endregion

        #region 绑定付款数据
        /// <summary>
        /// 绑定付款数据
        /// </summary>
        /// <param name="chkId">账单号</param>
        private void BindData(string chkId)
        {
            new SystemData().GetTaPaymentDetail();

            gridControlTaPayDetail.DataSource = CommonData.TaPaymentDetail.Where(s => s.CheckOrder.Equals(chkId)).ToList();

            gvTaPayDetail.FocusedRowHandle = gvTaPayDetail.RowCount - 1;
        }
        #endregion

        #region 数字按钮Click
        /// <summary>
        /// 数字按钮Click
        /// </summary>
        private void SetClick()
        {
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
            btnPoint.Click += this.btn_Click;
        }


        #endregion

        #region 获得Discount
        /// <summary>
        /// 获得Discount
        /// </summary>
        /// <param name="strChkType">账单类型</param>
        private decimal GetDiscount(string strChkType)
        {
            decimal d = 0.00m;
            if (strChkType.Equals(PubComm.ORDER_TYPE_SHOP))
            {
                
            }
            else if (strChkType.Equals(PubComm.ORDER_TYPE_COLLECTION))
            {

            }
            else  //PubComm.ORDER_TYPE_DELIVERY
            {
                
            }

            return d;
        }
        #endregion

        #region 获得账单

        private void GetChk(string chkId)
        {
            new SystemData().GetTaCheckOrder();

            var lstChk = CommonData.TaCheckOrder.Where(s => s.CheckCode.Equals(chkId));

            if (lstChk.Any())
            {
                TaCheckOrderInfo taCheckOrderInfo = lstChk.FirstOrDefault();
                txtDelivery.Text = taCheckOrderInfo.PayDelivery;
                txtDiscount.Text = taCheckOrderInfo.PayDiscount;
                txtTotal.Text = taCheckOrderInfo.TotalAmount;
                txtDiscount.Text = CommonDAL.GetTaDiscountAmount(orderType, Convert.ToDecimal(taCheckOrderInfo.MenuAmount)).ToString();
                txtPaid.Text = GetPayDetail(checkID).ToString();
            }
            else
            {
                txtDelivery.Text = "0.00";
                txtDiscount.Text = "0.00";
                txtTotal.Text = "0.00";
                txtDiscount.Text = "0.00";
                txtPaid.Text = "0.00";
            }
        }
        #endregion

        #region 获得会员信息

        private void GetCustomer(string phone)
        {
            if (!orderType.Equals(PubComm.ORDER_TYPE_SHOP))
            {
                new SystemData().GetTaCustomer();

                var lstCus = CommonData.TaCustomer.Where(s => s.cusPhone.ToString().Equals(phone));

                if (lstCus.Any())
                {
                    TaCustomerInfo taCustomerInfo = lstCus.FirstOrDefault();
                    txtPhone.Text = taCustomerInfo.cusPhone;
                    txtName.Text = taCustomerInfo.cusName;
                    txtHouseNo.Text = taCustomerInfo.cusHouseNo;
                    txtAddr.Text = taCustomerInfo.cusAddr;
                    txtPostcode.Text = taCustomerInfo.cusPostcode;
                    txtDistance.Text = taCustomerInfo.cusDistance;
                    txtPcZone.Text = taCustomerInfo.cusPcZone;
                    txtDelCharge.Text = taCustomerInfo.cusDelCharge;
                    txtReadyTime.Text = taCustomerInfo.cusReadyTime;
                    txtIntNotes.Text = taCustomerInfo.cusIntNotes;
                    txtNoteOnBill.Text = taCustomerInfo.cusNotesOnBill;
                    chkBlackList.Checked = taCustomerInfo.cusIsBlack.Equals("Y") ? true : false;
                    txtNote.Text = taCustomerInfo.cusNote;
                }
            }
        }
        #endregion

        #region 获得已付款汇总

        private decimal GetPayDetail(string chkId)
        {
            new SystemData().GetTaPaymentDetail();

            var lstDetail = CommonData.TaPaymentDetail.Where(s => s.CheckOrder.Equals(chkId));

            return lstDetail.Any() ? lstDetail.Where(s => s.CheckOrder.Equals(chkId)).Sum(s => Convert.ToDecimal(s.PayAmount)) : 0.00m;
        }
        #endregion

        #region 保存付款信息

        private void SaveOrder(int pt, int dri)
        {
            TaPaymentDetailInfo taPaymentDetailInfo = new TaPaymentDetailInfo();
            taPaymentDetailInfo.CheckOrder = checkID;
            taPaymentDetailInfo.PayType = chkPayType[pt].Text;
            taPaymentDetailInfo.PayAmount = txtPay.Text;
            taPaymentDetailInfo.StaffID = usrID;
            taPaymentDetailInfo.PayTime = DateTime.Now.ToString();

            _control.AddEntity(taPaymentDetailInfo);

            BindData(checkID);

            txtPaid.Text = GetPayDetail(checkID).ToString();

            txtPay.Text = "0.00";

            decimal dToPay = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtPaid.Text);

            //判断是否已经超过需付款值
            if (dToPay <= 0.00m)
            {
                txtToPay.Text = @"0.00";
                //超过，付款完成
                new SystemData().GetTaCheckOrder();
                var lstChk = CommonData.TaCheckOrder.Where(s => s.CheckCode.Equals(checkID));

                //更新账单信息
                if (lstChk.Any())
                {
                    TaCheckOrderInfo taCheckOrderInfo = lstChk.FirstOrDefault();
                    taCheckOrderInfo.Paid = GetPayDetail(checkID).ToString();
                    taCheckOrderInfo.IsPaid = @"Y";

                    if (dri > 0)
                    {
                        new SystemData().GetTaDriver();
                        var lstDri = CommonData.TaDriver.Where(s => s.DriverName.Equals(chkDriver[dri].Text));
                        taCheckOrderInfo.DriverID = lstDri.Any() ? lstDri.FirstOrDefault().ID : 0;
                    }

                    _control.UpdateEntity(taCheckOrderInfo);

                    returnPaid = true;

                    CommonTool.ShowMessage("odd change:" + Math.Abs(dToPay));

                    this.DialogResult = DialogResult.OK;

                    Hide();
                }
            }
            else
            {
                txtToPay.Text = dToPay.ToString("0.00");
            }
        }
        #endregion

        #endregion
    }
}