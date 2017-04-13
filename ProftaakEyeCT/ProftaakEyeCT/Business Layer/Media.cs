using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public abstract class Media
    {
        private int mediaID;
        private int mediaType;
        public int MediaID { get { return mediaID; } set { mediaID = value; } }
        public int MediaType { get { return mediaType; } set{ mediaType = value; } }

        public Media(int mediaID, int mediaType)
        {
            this.mediaID = mediaID;
            this.mediaType = mediaType;
        }


        public override string ToString()
        {
            return "Media";
        }
    }
}