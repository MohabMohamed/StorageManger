using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_manger
{
    class Track
    {
        private List<Sector> records = new List<Sector>();
        public void push(Sector sector)
        {
            records.Add(sector);
        }
    }
}
