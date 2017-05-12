using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    //权限组细节权限
    public class UsrAuthRuleInfo
    {
        [XmlElement(ElementName = "ID")]
        public virtual int ID { get; set; }

        //权限组ID
        [XmlElement(ElementName = "GrpID")]
        public virtual int GrpID { get; set; }

        //权限细节ID
        [XmlElement(ElementName = "AuthID")]
        public virtual int AuthID { get; set; }
    }
}
