using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Media
    {
        private readonly int id = -1;
        private string videoname;
        private string videolink;
        private string imagename;
        private string imagelink;
        private int mediatype;

        public int Id => id;

        public string Videoname { get; set; }
        public string Videolink { get; set; }
        public string Imagename { get; set; }
        public string Imagelink { get; set; }
        public int Mediatype { get; set; }

        public Media(int id, string videoname, string videolink, string imagename, string imagelink, int mediatype)
        {

        }
        public Media(string videoname, string videolink, string imagename, string imagelink, int mediatype)
            : this(-1, videoname, videolink, imagename, imagelink, mediatype)
        {

        }
        public override string ToString()
        {
            return videoname + videolink + imagename + imagelink + mediatype;
        }
    }
}
