﻿using System.Collections.Generic;
using SuperPOS.Domain.Entities;

namespace SuperPOS.Common
{
    public class CommonData
    {
        public static IList<TAShiftCodeInfo> TaShiftCodeList { get; set; } 

        public static IList<UsrBaseInfo> UsrBase { get; set; } 

        public static IList<UsrAuthAccessInfo> UsrAuthAccess { get; set; }

        public static IList<UsrAuthDetailInfo> UsrAuthDetail { get; set; } 

        public static IList<UsrAuthGroupInfo> UsrAuthGroup { get; set; } 

        public static IList<UsrAuthRuleInfo> UsrAuthRule { get; set; } 

        public static IList<CompAddrInfo> CompAddr { get; set; } 

        public static IList<ShopDetailInfo> ShopDetail { get; set; }

        public static IList<GenSetInfo> GenSet { get; set; } 

        public static IList<KeypadInfo> Keypad { get; set; }

        public static IList<SysPrtSetInfo> SysPrt { get; set; }

        public static IList<TaDeptCodeInfo> TaDeptCode { get; set; } 

        public static IList<TaMenuSetInfo> TaMenuSet { get; set; } 

        public static IList<TaMenuCateInfo> TaMenuCate { get; set; } 

        public static IList<TaMenuItemInfo> TaMenuItem { get; set; } 

        public static IList<TaMenuItemOtherChoiceInfo> TaMenuItemOtherChoice { get; set; } 

        public static IList<TaOrderItemInfo> TaOrderItem { get; set; } 

        public static IList<TaCheckOrderInfo> TaCheckOrder { get; set; }

        public static IList<SysValueInfo> SysValue { get; set; } 
    }
}
