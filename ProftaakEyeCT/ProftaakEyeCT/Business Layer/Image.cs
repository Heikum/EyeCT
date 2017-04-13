using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Image : Media
    {
        private string ImageLink { get; set; }
        private string ImageType { get; set; }

        public Image(string imagelink, string imageType, int MediaID, int MediaType) : base(MediaID, MediaType)
        {
            ImageLink = imagelink;
            ImageType = imageType;
        }

        public string GetImageLink()
        {
            return ImageLink;
        }



        public override string ToString()
        {
            return base.ToString();
        }

    }
}