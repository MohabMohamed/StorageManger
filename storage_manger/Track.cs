using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace storage_manger
{
    
    public class Track
    {   [XmlElement]
        public List<Sector> Sector = new List<Sector>();
        public void push(Sector sector)
        {
           this.Sector.Add(sector);
        }
    }
}
