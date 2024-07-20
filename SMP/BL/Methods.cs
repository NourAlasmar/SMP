using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SMP.BL
{
     class Methods
    {
        public MemoryStream ma = new MemoryStream();
        public byte[] by;

        // Convert to byte
        public byte[] convert_byte()
        {
         return ma.ToArray();
        }

        //Convert To Image
        public MemoryStream convert_image()
        {
            ma = new MemoryStream(by);
            return ma;
        }
    }
}
