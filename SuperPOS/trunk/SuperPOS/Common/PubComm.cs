
namespace SuperPOS.Common
{
    public class PubComm
    {
        //启动时错误提示
        public static string START_ONLY_ONE_APP = @"Only run one Application at a time!";
        //开启软件提示文字
        public static string INIT_MSG = @"Loading system data......";
        //log4net配置文件名
        public static string LOG4NET_CONFIG_FILE_NAME = @"log4net.config";

        //NHibernate配置文件
        public static string NHIBERNATE_CONFIG_FILE_NAME = @"hibernate.cfg.xml";

        //星期
        public static string[] WORD_DAY = new string[] { "Monday", "Tuesday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        //Menu Item中的其他属性
        public static string[] MENUITEM_OTHER_SET = new[] {"Unavailable", "Negative Price", "Discountable", "Without VAT", "Inventory Check"};

        //语言状态位
        //默认为1，即：英文
        public static int MENU_LANG_DEFAULT = 1;
        //其他语言
        public static int MENU_LANG_OTHER = 2;

        #region 系统常量
        //账单
        public static string SYS_VALUE_CHECK_CODE = "1001";

        #endregion
    }
}
