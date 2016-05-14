using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace storage_manger
{
    
    [XmlRoot("Hard")]
    public class Hard
    {
        [XmlElement]
        public List<Track> Track = new List<Track>();
        public void push(Track track)
        {
            this.Track.Add(track);
        }
    }
}
