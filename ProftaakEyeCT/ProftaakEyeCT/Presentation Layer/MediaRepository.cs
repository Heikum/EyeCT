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
        public Media InsertNull()
        {

            return context.InsertNull();

        }

        public Video Insert(Video video)
        {
            return context.Insert(video);
        }

        public Image Insert(Image image)
        {
            return context.Insert(image);
        }

        public int GetId()
        {
            return context.GetId();
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
