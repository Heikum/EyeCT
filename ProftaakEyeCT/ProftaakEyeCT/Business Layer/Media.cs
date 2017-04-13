using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public abstract class Media
    {
        private int MediaID { get; set; }
        private int MediaType { get; set; }

        public Media(int mediaID, int mediaType)
        {
            MediaID = mediaID;
            MediaType = mediaType;
        }


        public override string ToString()
        {
            return "Media";
        }
    }
}