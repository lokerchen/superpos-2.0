using System.Collections.Generic;
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
    }
}
