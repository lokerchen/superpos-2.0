using SuperPOS.Domain.Entities;

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
    }
}
