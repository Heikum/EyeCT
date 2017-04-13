using ProftaakEyeCT.DAL;
using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.Presentation_Layer
{
    public class MaterialRepository
    {
        private IMaterialContext context;

        public MaterialRepository(IMaterialContext context)
        {
            this.context = context;
        }
        public Material Insert(Material material)
        {

            return context.InsertMaterial(material);

        }
        public List<Material> GetAll()
        {
            return context.GetAll();
        }
        public bool Update(Material material)
        {
            return context.UpdateMaterial(material);
        }

        public bool Delete(int id)
        {
            return context.DeleteMaterial(id);
        }


    }
}
