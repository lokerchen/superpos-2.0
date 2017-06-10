
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

        //菜品类型
        //主菜品
        public static int MENU_ITEM_MAIN = 1;
        //子菜品
        public static int MENU_ITEM_CHILD = 2;
        //改码
        public static int MENU_ITEM_APPEND = 3;

        //改码类型
        public static string[] EXTRA_MENU_EDIT_TYPE = new[] {"Vegetable", "Vegetable2", "Bean", "Meat", "Seafood", "Sauce", "Taste", "Fruit", "Cooking", "Others"};
        //改码Btn类型
        public static string[] EXTRA_MENU_BTN_TYPE = new[] {"Taste Item", "Drink Item"};
        //前端改码类型
        public static string[] FORM_BTN_TYPE = new[] {"LESS(-)", "ADD(+)", "MORE(++)", "WITHOUT(X)", "CHANGE(/)"};
        //前端实际使用类型
        public static string[] FORM_USE_TYPE = new[] {"-", "+", "++", "X", "/"};

        //订单类型
        public static string ORDER_TYPE_SHOP = "SHOP";
        public static string ORDER_TYPE_COLLECTION = "COLLECTION";
        public static string ORDER_TYPE_DELIVERY = "DELIVERY";

        #region 系统常量
        //账单
        public static string SYS_VALUE_CHECK_CODE = "1001";

        #endregion
    }
}
