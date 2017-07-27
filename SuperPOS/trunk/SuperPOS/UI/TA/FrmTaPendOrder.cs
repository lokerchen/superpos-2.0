using System;
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
using SuperPOS.Print;

namespace SuperPOS.UI.TA
{
    public partial class FrmTaPendOrder : DevExpress.XtraEditors.XtraForm
    {
        //用户ID
        private int usrID;

        //账单ID
        private int checkID;
        //账单号
        private string checkCode;
        //账单类型
        private string checkOrderType;
        //账单总价
        private string checkTotalAmount;
        //已付款
        private string checkPaid;
        //是否已付
        private string checkIsPaid;
        //下单用户
        private string checkUsrName;
        //来电ID
        private string checkCustID;
        //司机ID
        private int checkDriverID;

        public FrmTaPendOrder()
        {
            InitializeComponent();
        }

        public FrmTaPendOrder(int uID)
        {
            InitializeComponent();
            usrID = uID;
        }

        private void GetBindData(string orderType)
        {
            var lstDb = from check in CommonData.TaCheckOrder
                join cust in CommonData.TaCustomer
                    on check.CustomerID equals cust.ID.ToString()
                join user in CommonData.UsrBase
                    on check.StaffID equals user.ID
                where !check.IsPaid.Equals("Y")
                select new
                {
                    ID = check.ID,
                    CheckCode = check.CheckCode,
                    PayOrderType = check.PayOrderType,
                    IsPaid = check.IsPaid,
                    TotalAmount = check.TotalAmount,
                    StaffName = user.UsrName,
                    Paid = check.Paid,
                    CustID = cust.ID,
                    DriverID = check.DriverID
                };

            gridControlTaPendOrder.DataSource = !string.IsNullOrEmpty(orderType) ? lstDb.Where(s => s.PayOrderType.Equals(orderType)).ToList() : lstDb.ToList();
            gvTaPendOrder.FocusedRowHandle = gvTaPendOrder.RowCount - 1;
        }

        private void FrmTaPendOrder_Load(object sender, EventArgs e)
        {
            SystemData systemData = new SystemData();
            systemData.GetTaCheckOrder();
            systemData.GetTaCustomer();
            systemData.GetUsrBase();
            systemData.GetTaOrderItem();

            GetBindData("");
        }

        private void gvTaPendOrder_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle > -1)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gvTaPendOrder_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvTaPendOrder.FocusedRowHandle <= 0) return;
            //账单ID
            checkID = Convert.ToInt32(gvTaPendOrder.GetRowCellValue(gvTaPendOrder.FocusedRowHandle, "ID").ToString());
            //账单号
            checkCode = gvTaPendOrder.GetRowCellValue(gvTaPendOrder.FocusedRowHandle, "CheckCode").ToString();
            //账单类型
            checkOrderType = gvTaPendOrder.GetRowCellValue(gvTaPendOrder.FocusedRowHandle, "PayOrderType").ToString();
            //账单总价
            checkTotalAmount = gvTaPendOrder.GetRowCellValue(gvTaPendOrder.FocusedRowHandle, "TotalAmount").ToString();
            //已付款
            checkPaid = gvTaPendOrder.GetRowCellValue(gvTaPendOrder.FocusedRowHandle, "Paid").ToString();
            //已付
            checkIsPaid = gvTaPendOrder.GetRowCellValue(gvTaPendOrder.FocusedRowHandle, "IsPaid").ToString();
            //下单用户
            checkUsrName = gvTaPendOrder.GetRowCellValue(gvTaPendOrder.FocusedRowHandle, "StaffName").ToString();
            //来电ID
            checkCustID = gvTaPendOrder.GetRowCellValue(gvTaPendOrder.FocusedRowHandle, "CustID").ToString();
            //司机ID
            checkDriverID = Convert.ToInt32(gvTaPendOrder.GetRowCellValue(gvTaPendOrder.FocusedRowHandle, "DriverID").ToString());
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FrmTaPayment frmTaPayment = new FrmTaPayment(usrID, checkCode, checkOrderType, checkCustID, SetPrtInfo());

            if (frmTaPayment.ShowDialog() == DialogResult.OK)
            {
                if (frmTaPayment.returnPaid) GetBindData("");
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            GetBindData(PubComm.ORDER_TYPE_DELIVERY);
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            GetBindData(PubComm.ORDER_TYPE_COLLECTION);
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            GetBindData(PubComm.ORDER_TYPE_SHOP);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            GetBindData("");
        }

        #region 设置打印相关信息

        private Hashtable SetPrtInfo()
        {
            Hashtable htDetail = new Hashtable();

            new SystemData().GetUsrBase();

            htDetail["Staff"] = CommonData.UsrBase.Any(s => s.ID == usrID) ? CommonData.UsrBase.FirstOrDefault(s => s.ID == usrID).UsrName : "";

            var lstOi = CommonData.TaOrderItem.Where(s => s.CheckCode.Equals(checkCode));

            htDetail["ItemQty"] = lstOi.Count(s => s.ItemType == 1);
            htDetail["SubTotal"] = checkTotalAmount;
            htDetail["Total"] = checkTotalAmount;
            htDetail["PayType"] = checkOrderType;
            htDetail["OrderNo"] = checkCode;

            return htDetail;
        }
        #endregion

        private void btnPrtReceipt_Click(object sender, EventArgs e)
        {
            Hashtable ht = SetPrtInfo();
            ht["Tendered"] = checkPaid;

            ht["Change"] = "0.00";

            new SystemData().GetTaOrderItem();
            var lstOi = CommonData.TaOrderItem.Where(s => s.CheckCode.Equals(checkCode)).ToList();

            #region VAT计算
            if (CommonData.GenSet.Any())
            {
                ht["Rate1"] = CommonData.GenSet.FirstOrDefault().VATPer + @"%";

                var lstVAT = from oi in CommonData.TaOrderItem.Where(s => s.CheckCode.Equals(checkID))
                             join mi in CommonData.TaMenuItem on oi.ItemCode equals mi.MiDishCode
                             where !string.IsNullOrEmpty(mi.MiRmk) && mi.MiRmk.Contains(@"Without VAT")
                             select new
                             {
                                 itemTotalPrice = oi.ItemTotalPrice
                             };

                decimal dTotal = 0.00m;
                decimal dVatTmp = 0.00m;
                decimal dVat = 0.00m;

                if (lstVAT.Any())
                {
                    dTotal = lstVAT.ToList().Sum(vat => Convert.ToDecimal(vat.itemTotalPrice));
                    //交税
                    dVatTmp = (Convert.ToDecimal(CommonData.GenSet.FirstOrDefault().VATPer) / 100) * dTotal;

                    dVat = Math.Round(dVatTmp, 2, MidpointRounding.AwayFromZero);
                }

                ht["VAT-A"] = dVat.ToString();
                //税前
                ht["Net1"] = dTotal.ToString();
                //总价
                ht["Gross1"] = (dTotal - dVat).ToString();
                ht["Rate2"] = "0.00%";
                ht["Net2"] = (Convert.ToDecimal(checkTotalAmount) - dTotal).ToString();
                ht["VAT-B"] = "0.00";
                ht["Gross2"] = (Convert.ToDecimal(checkTotalAmount) - dTotal).ToString();
            }
            else
            {
                ht["Rate1"] = "0.00%";
                ht["Net1"] = "0.00";
                ht["VAT-A"] = "0.00";
                ht["Gross1"] = "0.00";
                ht["Rate2"] = "0.00%";
                ht["Net2"] = "0.00";
                ht["VAT-B"] = "0.00";
                ht["Gross2"] = "0.00";
            }
            #endregion

            PrtPrint.PrtReceipt(lstOi, ht);
        }

        private void btnPrtBill_Click(object sender, EventArgs e)
        {
            Hashtable ht = SetPrtInfo();
            ht["Tendered"] = checkPaid;

            ht["Change"] = "0.00";

            new SystemData().GetTaOrderItem();
            var lstOi = CommonData.TaOrderItem.Where(s => s.CheckCode.Equals(checkCode)).ToList();

            PrtPrint.PrtBillBilingual(lstOi, ht);
        }

        private void btnPrtKit_Click(object sender, EventArgs e)
        {
            Hashtable ht = SetPrtInfo();
            ht["ChkNum"] = checkCode;

            new SystemData().GetTaOrderItem();
            var lstOi = CommonData.TaOrderItem.Where(s => s.CheckCode.Equals(checkCode)).ToList();

            PrtPrint.PrtKitchen(lstOi, ht);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTaMain frmTaMain = new FrmTaMain(usrID);
            frmTaMain.ShowDialog();
        }

        private void gvTaPendOrder_DoubleClick(object sender, EventArgs e)
        {
            Hide();
            FrmTaMain frmTaMain = new FrmTaMain(checkCode, usrID);
            frmTaMain.ShowDialog();
        }
    }
}