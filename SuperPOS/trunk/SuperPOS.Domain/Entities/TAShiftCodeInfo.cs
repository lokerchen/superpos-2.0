using System;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TAShiftCodeInfo
    {
        [XmlElement(ElementName = "SystemKey")]
        public virtual Guid SystemKey { get; set; }

        [XmlElement(ElementName = "ShiftCode")]
        public virtual string ShiftCode { get; set; }

        [XmlElement(ElementName = "ShiftName")]
        public virtual string ShiftName { get; set; }

        [XmlElement(ElementName = "OtherName")]
        public virtual string OtherName { get; set; }

        [XmlElement(ElementName = "IsSpecial")]
        public virtual string IsSpecial { get; set; }

        [XmlElement(ElementName = "DtFrom")]
        public virtual string DtFrom { get; set; }

        [XmlElement(ElementName = "DtEnd")]
        public virtual string DtEnd { get; set; }

        [XmlElement(ElementName = "SpecialContent")]
        public virtual string SpecialContent { get; set; }

        [XmlElement(ElementName = "ShiftRmk")]
        public virtual string ShiftRmk { get; set; }
    }
}
