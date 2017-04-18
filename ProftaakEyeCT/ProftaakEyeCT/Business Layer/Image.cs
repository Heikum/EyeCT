using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Image : Media
    {
        private string imageLink;
        private string imageName;

        public Image(int Id, string imageLink, string imageName): base (Id)
        {
            this.imageLink = imageLink;
            this.imageName = imageName;
        }

        public string ImageLink
        {
            get
            {
                return imageLink;
            }

            set
            {
                imageLink = value;
            }
        }

        public string ImageName
        {
            get
            {
                return imageName;
            }

            set
            {
                imageName = value;
            }
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