
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
            systemData.GetUsrAuthAccess();
            systemData.GetUsrAuthDetail();
            systemData.GetUsrAuthGroup();
            systemData.GetUsrAuthRule();
            //Computer Address
            systemData.GetCompAddr();
            //店铺详情
            systemData.GetShopDetail();
            //General设定
            systemData.GenSet();
            //Keypad设定
            systemData.GetKeypadList();
            //打印机列表
            systemData.GetSysPrtList();

            #region Takeaway
            //Department Code
            systemData.GetTaDeptCode();
            //Menu Set
            systemData.GetTaMenuSet();
            //Menu Category
            systemData.GetTaMenuCate();
            //Menu Item
            systemData.GetTaMenuItem();
            #endregion
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

        #region 判断用户权限
        /// <summary>
        /// 判断用户权限
        /// </summary>
        /// <param name="sID">用户ID</param>
        /// <returns></returns>
        public static bool IsUsrAuth(int sID)
        {
            new SystemData().GetUsrAuthAccess();

            var lst = from aa in CommonData.UsrAuthAccess
                      join ag in CommonData.UsrAuthGroup
                      on aa.AuthGrpID equals ag.ID
                      where aa.UsrID == sID
                      select new
                      {
                          ID = aa.ID
                      };

            return lst.Any();
        }
        #endregion

        #region 用户登录判断
        /// <summary>
        /// 用户登录判断
        /// </summary>
        /// <param name="strPwd">用户密码</param>
        /// <returns></returns>
        public static bool IsUsr(string strPwd)
        {
            new SystemData().GetUsrBase();

            var lstUsr = CommonData.UsrBase.Where(s => s.UsrPwd.Equals(strPwd));

            return lstUsr.Any();
        }
        #endregion

        #region 获得用户ID
        /// <summary>
        /// 获得用户ID
        /// </summary>
        /// <param name="strPwd">用户密码</param>
        /// <returns></returns>
        public static int GetUsrID(string strPwd)
        {
            var lstUsrID = CommonData.UsrBase.Where(s => s.UsrPwd.Equals(strPwd));

            return lstUsrID.Any() ? lstUsrID.FirstOrDefault().ID : 0;
        }
        #endregion

        #region 获得用户名

        public static string GetUsrName(int id)
        {
            new SystemData().GetUsrBase();

            return CommonData.UsrBase.FirstOrDefault(s => s.ID == id).UsrName;
        }
        #endregion
    }
}
