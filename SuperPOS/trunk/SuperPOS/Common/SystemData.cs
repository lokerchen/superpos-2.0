using SuperPOS.Domain.Entities;

namespace SuperPOS.Common
{
    public class SystemData
    {
        private EntityControl _control;

        public SystemData() { _control = EntityControl.CreateEntityControl(); }

        public void GetTaShiftCodeList() { CommonData.TaShiftCodeList = _control.SelectAll<TAShiftCodeInfo>(); }

        public void GetUsrBase() { CommonData.UsrBase = _control.SelectAll<UsrBaseInfo>(); }
    }
}
