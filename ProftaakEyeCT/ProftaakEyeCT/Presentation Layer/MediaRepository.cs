using ProftaakEyeCT.DAL;
using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.Presentation_Layer
{
    public class MediaRepository
    {
        private IMediaContext context;

        public MediaRepository(IMediaContext context)
        {
            this.context = context;
        }
        public Media Insert(Media media)
        {

            return context.Insert(media);

        }
        public List<Media> GetAll()
        {
            return context.GetAll();
        }
        public bool Update(Media media)
        {
            return context.Update(media);
        }

        public bool Delete(int id)
        {
            return context.Delete(id);
        }

    }
}
