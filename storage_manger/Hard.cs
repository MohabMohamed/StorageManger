using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_manger
{
    class Hard
    {

        private List<Track> records = new List<Track>();
        public void push(Track track)
        {
            records.Add(track);
        }
    }
}
