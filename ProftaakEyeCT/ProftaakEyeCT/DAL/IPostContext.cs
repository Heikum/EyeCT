using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.DAL
{
    public interface IPostContext
    {
        List<Post> GetAll();
        Post GetById(int id);
        void InsertPost(Post post);
        bool Delete(int id);
        List<Post> GetByUsername(string username);
        bool UpdatePost(Post post);
        List<Post> GetAllReportedPosts();
        List<string> GetReportPostComplaint(Post post);
        void InsertReportedPost(Post post, string complaint);


    }
}

