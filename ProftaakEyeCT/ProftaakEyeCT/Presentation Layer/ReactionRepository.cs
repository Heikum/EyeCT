using ProftaakEyeCT.DAL;
using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.Presentation_Layer
{
    public class ReactionRepository
    {
        private IReactionContext context;

        public ReactionRepository(IReactionContext context)
        {
            this.context = context;
        }
        public Reaction Insert(Reaction reaction)
        {

            return context.Insert(reaction);

        }
        public List<Reaction> GetAll()
        {
            return context.GetAll();
        }
        public bool Update(Reaction reaction)
        {
            return context.Update(reaction);
        }

        public bool Delete(int id)
        {
            return context.Delete(id);
        }
        public List<Reaction> GetByPost(Post post)
        {
            return context.GetByPost(post);
        }
        
    }
}
