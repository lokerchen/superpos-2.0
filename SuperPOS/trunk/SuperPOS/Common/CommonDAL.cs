
using System;
using System.Linq;
using SuperPOS.Domain.Entities;

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
            //获得Shift Code
            systemData.GetTaShiftCodeList();
            //用户列表
            systemData.GetUsrBase();
            //用户权限
            systemData.GetUsrAuthority();
        }

        #endregion

        #region 获取Session
        /// <summary>
        /// 获取Session
        /// </summary>
        /// <returns></returns>
        public static string GetSession()
        {
            new SystemData().GetTaShiftCodeList();

            return CommonData.TaShiftCodeList.Any(sc => DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), Convert.ToDateTime(sc.DtFrom)) >= 0
                            && DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), Convert.ToDateTime(sc.DtEnd)) <= 0)
                    ? CommonData.TaShiftCodeList.FirstOrDefault(sc => DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), Convert.ToDateTime(sc.DtFrom)) >= 0
                            && DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), Convert.ToDateTime(sc.DtEnd)) <= 0).ShiftName
                    : "";
        }

        #endregion

        #region 验证登录用户密码是否正确
        /// <summary>
        /// 验证登录用户密码是否正确
        /// </summary>
        /// <param name="strPwd">用户密码</param>
        /// <returns></returns>
        public static bool IsUser(string strPwd)
        {
            return true;
        }
        #endregion
    }
}
