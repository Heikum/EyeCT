using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.DAL
{
    public interface IMaterialContext
    {
        List<Material> GetAll();

        bool Insert(Material material);

        bool UpdateMaterial(Material material);

        bool DeleteMaterial(int id);
        bool DeleteMaterialReservation(int resID); 

    }
}
