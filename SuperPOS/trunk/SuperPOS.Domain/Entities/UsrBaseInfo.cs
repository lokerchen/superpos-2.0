using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class UsrBaseInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        //用户编号
        [XmlElement(ElementName = "UsrID")]
        public virtual string UsrID { get; set; }

        //用户名
        [XmlElement(ElementName = "UsrName")]
        public virtual string UsrName { get; set; }

        //用户密码
        [XmlElement(ElementName = "UsrPwd")]
        public virtual string UsrPwd { get; set; }

        //备注
        [XmlElement(ElementName = "UsrRmk")]
        public virtual string UsrRmk { get; set; }
    }
}
