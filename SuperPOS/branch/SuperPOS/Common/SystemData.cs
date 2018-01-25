﻿using SuperPOS.Domain.Entities;

namespace SuperPOS.Common
{
    public class SystemData
    {
        private EntityControl _control;

        public SystemData() { _control = EntityControl.CreateEntityControl(); }

        public void GetTaShiftCodeList() { CommonData.TaShiftCodeList = _control.SelectAll<TAShiftCodeInfo>(); }

        public void GetUsrBase() { CommonData.UsrBase = _control.SelectAll<UsrBaseInfo>(); }

        public void GetUsrAuthAccess() { CommonData.UsrAuthAccess = _control.SelectAll<UsrAuthAccessInfo>(); }

        public void GetUsrAuthDetail() { CommonData.UsrAuthDetail = _control.SelectAll<UsrAuthDetailInfo>(); }

        public void GetUsrAuthGroup() { CommonData.UsrAuthGroup = _control.SelectAll<UsrAuthGroupInfo>(); }

        public void GetUsrAuthRule() { CommonData.UsrAuthRule = _control.SelectAll<UsrAuthRuleInfo>(); }

        public void GetCompAddr() { CommonData.CompAddr = _control.SelectAll<CompAddrInfo>(); }

        public void GetShopDetail() { CommonData.ShopDetail = _control.SelectAll<ShopDetailInfo>(); }

        public void GenSet() { CommonData.GenSet = _control.SelectAll<GenSetInfo>(); }

        public void GetKeypadList() { CommonData.Keypad = _control.SelectAll<KeypadInfo>(); }

        public void GetSysPrtList() { CommonData.SysPrt = _control.SelectAll<SysPrtSetInfo>(); }

        public void GetTaDeptCode() { CommonData.TaDeptCode = _control.SelectAll<TaDeptCodeInfo>(); }

        public void GetTaMenuSet() { CommonData.TaMenuSet = _control.SelectAll<TaMenuSetInfo>(); }

        public void GetTaMenuCate() { CommonData.TaMenuCate = _control.SelectAll<TaMenuCateInfo>(); }

        public void GetTaMenuItem() { CommonData.TaMenuItem = _control.SelectAll<TaMenuItemInfo>(); }
        
        public void GetTaMenuItemOtherChoice() { CommonData.TaMenuItemOtherChoice = _control.SelectAll<TaMenuItemOtherChoiceInfo>(); }

        public void GetTaOrderItem() { CommonData.TaOrderItem = _control.SelectAll<TaOrderItemInfo>(); }

        public void GetTaCheckOrder() { CommonData.TaCheckOrder = _control.SelectAll<TaCheckOrderInfo>(); }

        public void GetSysValue() { CommonData.SysValue = _control.SelectAll<SysValueInfo>(); }

        public void GetTaExtraMenu() { CommonData.TaExtraMenu = _control.SelectAll<TaExtraMenuInfo>(); }

        public void GetTaPaymentType() { CommonData.TaPaymentType = _control.SelectAll<TaPaymentTypeInfo>(); }

        public void GetTaDiscount() { CommonData.TaDiscount = _control.SelectAll<TaDiscountInfo>(); }

        public void GetTaDeliveryNote() { CommonData.TaDeliveryNote = _control.SelectAll<TaDeliveryNoteInfo>(); }

        public void GetTaDriver() { CommonData.TaDriver = _control.SelectAll<TaDriverInfo>(); }

        public void GetTaCustomer() { CommonData.TaCustomer = _control.SelectAll<TaCustomerInfo>(); }

        public void GetTaPayment() { CommonData.TaPayment = _control.SelectAll<TaPaymentInfo>(); }

        public void GetTaPaymentDetail() { CommonData.TaPaymentDetail = _control.SelectAll<TaPaymentDetailInfo>(); }
        
        public void GetTaCashDrawSet() { CommonData.TaCashDrawSet = _control.SelectAll<TaCashDrawSetInfo>(); }

        public void GetDataManager() { CommonData.DataManager = _control.SelectAll<DataManagerInfo>(); }

        public void GetTaFreeFood() { CommonData.TaFreeFood = _control.SelectAll<TaFreeFoodInfo>(); }

        public void GetTaDeliverySet() { CommonData.TaDeliverySet = _control.SelectAll<TaDeliverySetInfo>(); }

        public void GetTaDeliverySetDetail() { CommonData.TaDeliverySetDetail = _control.SelectAll<TaDeliverySetDetailInfo>(); }

        public void GetTaPostcodeCharge() { CommonData.TaPostcodeCharge = _control.SelectAll<TaPostcodeChargeInfo>(); }

        public void GetTaPostcodeZone() { CommonData.TaPostcodeZone = _control.SelectAll<TaPostcodeZoneInfo>(); }

        public void GetTaPostcodeSet() { CommonData.TaPostcodeSet = _control.SelectAll<TaPostcodeSetInfo>(); }

        public void GetTaSubMenu() { CommonData.TaSubMenu = _control.SelectAll<TaSubMenuInfo>(); }

        public void GetTaSubMenuDetail() { CommonData.TaSubMenuDetail = _control.SelectAll<TaSubMenuDetailInfo>(); }

        public void GetTaSysFont() { CommonData.TaSysFont = _control.SelectAll<TaSysFontInfo>(); }
    }
}
