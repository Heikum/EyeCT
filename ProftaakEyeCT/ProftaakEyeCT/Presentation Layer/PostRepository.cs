﻿using ProftaakEyeCT.DAL;
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
        public Post InsertPost(Post post, Account account, Media media)
        {
            return context.InsertPost(post, account, media);
        }
        public List<Post> GetAll()
        {
            return context.GetAll();
        }
        public bool UpdatePost(Post post)
        {
            return context.UpdatePost(post);
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
