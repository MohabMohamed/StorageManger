using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_manger
{
    class Sector
    {
        private List<Records> records = new List<Records>();
        public void push(Records record)
        {
            records.Add(record);
        }
    }
}
