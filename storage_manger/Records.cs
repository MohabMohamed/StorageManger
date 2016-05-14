using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace storage_manger
{
    
    public class Records
    {
        [XmlElement]
        public List<Data> Data= new List<Data>() ;
        public void push(Data data){
            this.Data.Add(data);
        }
    }
}
