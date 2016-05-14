using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace storage_manger
{
    
        public class Data
        {
            [XmlAttribute("ID")]
            public string ID { get; set; }
            [XmlElement("Name")]
            public string Name { get; set; }
            [XmlElement("address")]
            public string Address { get; set; }
        }
    
}
