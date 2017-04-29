using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.DAL
{
    public interface IMediaContext
    {

        List<Media> GetAll();
        Media GetByName(string Name);
        Media InsertNull();
        Video Insert(Video video);
        Image Insert(Image image);
        bool Delete(int id);
        bool Update(Media media);
        int GetId();

    }
}

