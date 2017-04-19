using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public abstract class Media
    {
        private int Id;


        public Media(int ID)
        {
            this.Id = ID;

        }

        public int MediaID { get { return Id; } set { Id = value; } }



        public override string ToString()
        {
            return Id.ToString();
        }
    }
}