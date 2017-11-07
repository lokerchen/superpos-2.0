﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SuperPOS.Domain.Entities
{
    public class TaCashDrawSetInfo
    {

        [XmlElement(ElementName = "ID")]
        public virtual int ID { get; set; }

        //是否启用钱箱
        [XmlElement(ElementName = "IsUseCashDraw")]
        public virtual string IsUseCashDraw { get; set; }

        //钱箱密码
        [XmlElement(ElementName = "CashDrawPwd")]
        public virtual string CashDrawPwd { get; set; }
    }
}
