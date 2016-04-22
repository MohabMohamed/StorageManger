using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_manger
{
    class Calculate
    {
        public long recordsize, sectorsize, recordNO;
      public Calculate(long recsi,long sectsi,long recno){
          recordsize=recsi;
          sectorsize=sectsi;
          recordNO = recno;
      }
        public long  neededSectors()
        {
         return recordNO/ ( recordsize / sectorsize);
        }
      public  long  frag ()
        {


          return (sectorsize % recordsize)*neededSectors() ;

        }

    }
}
