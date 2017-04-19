using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.DAL
{
    public interface IReactionContext
    {

        List<Reaction> GetAll();
        List<Reaction> GetByPost(Post post);
        Reaction Insert( Reaction reaction);
        bool Delete(int id);
        bool Update(Reaction reaction);
    }
}
