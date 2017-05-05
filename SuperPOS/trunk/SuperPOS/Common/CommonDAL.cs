
namespace SuperPOS.Common
{
    public class CommonDAL
    {
        #region 加载系统数据
        /// <summary>
        /// 加载系统数据
        /// </summary>
        public static void InitData()
        {
            SystemData systemData = new SystemData();
            systemData.GetTaShiftCodeList();
        }
        #endregion
    }
}
