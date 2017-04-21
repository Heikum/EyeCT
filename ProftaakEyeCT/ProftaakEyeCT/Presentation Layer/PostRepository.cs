using ProftaakEyeCT.DAL;
using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.Presentation_Layer
{
    public class PostRepository
    {
        private IPostContext context;

        public PostRepository(IPostContext context)
        {
            this.context = context;
        }
        public Post Insert(Post post)
        {

            return context.Insert(post);
        }
        public List<Post> GetAll()
        {
            return context.GetAll();
        }
        public bool Update(Post post)
        {
            return context.Update(post);
        }

        public List<Post> GetByUsername(string username)
        {
            return context.GetByUsername(username);
        }

        public bool Delete(int id)
        {
            return context.Delete(id);
        }
        public Post GetById(int id)
        {
            return context.GetById(id);
        }
    }
}
