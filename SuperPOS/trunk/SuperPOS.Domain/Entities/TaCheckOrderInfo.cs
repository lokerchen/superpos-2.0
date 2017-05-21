using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TaCheckOrderInfo
    {
        [XmlElement(ElementName = "ID")]
        public virtual int ID { get; set; }

        //账单号码
        [XmlElement(ElementName = "ChkCode")]
        public virtual string ChkCode { get; set; }

        //账单类型
        [XmlElement(ElementName = "ChkType")]
        public virtual string ChkType { get; set; }

        //已付款
        [XmlElement(ElementName = "PaidAmount")]
        public virtual string PaidAmount { get; set; }

        //付款类型
        [XmlElement(ElementName = "PaidType")]
        public virtual string PaidType { get; set; }

        //账单总数
        [XmlElement(ElementName = "ChkAmount")]
        public virtual string ChkAmount { get; set; }

        //是否已付完款
        [XmlElement(ElementName = "IsPaid")]
        public virtual string IsPaid { get; set; }

        //付款时间
        [XmlElement(ElementName = "OrderTime")]
        public virtual string OrderTime { get; set; }

        //操作ID
        [XmlElement(ElementName = "StaffID")]
        public virtual int StaffID { get; set; }
    }
}