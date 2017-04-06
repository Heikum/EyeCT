using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Video: Media
    {
        private int lenght;

        public Video(string Name, int Size, int Length): base(Name,Size)
        {

        }
        public int getDuration()
        {
            return 0;
        }
    }
}
