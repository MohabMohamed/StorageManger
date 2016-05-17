using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_manger
{
    class Calculate
    {
        public long recordsize, sectorsize, recordNO, tracksize;
      public Calculate(long recsi,long sectsi,long recno,long tracksi){
          recordsize=recsi;
          sectorsize=sectsi;
          recordNO = recno;
          tracksize = tracksi;
      }
        public long  neededSectors()
        {
         return recordNO/ ( sectorsize / recordsize  );
        }
      public  long  frag ()
        { 
          
           return ( sectorsize  % recordsize) *neededSectors() ;
                     

        }
      public long RecordsPerTrack()
      {
 return (tracksize / sectorsize) * (sectorsize / recordsize);
      }

      public long needed_Records()
      {
          return (sectorsize / recordsize); 
      }

      
    }
}
