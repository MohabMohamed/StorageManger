using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace storage_manger
{
    class Records
    {
        private List<Data> records= new List<Data>() ;
        public void push(Data data){
            records.Add(data);
        }
    }
}
