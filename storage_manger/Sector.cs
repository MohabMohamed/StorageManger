using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace storage_manger
{
    
    public class Sector
    {
        [XmlElement]
        public List<Records> Record = new List<Records>();
        public void push(Records record)
        {
            this.Record.Add(record);
        }

        
    }
}
