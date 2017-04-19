﻿using ProftaakEyectEvents;
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
        Post Insert(Post post);
        bool Delete(int id);
        bool Update(Post post);

    }
}
