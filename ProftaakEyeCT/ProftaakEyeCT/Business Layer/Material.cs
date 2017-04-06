using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Material
    {
        private string name;
        private decimal price;
        private int stock;
        private int ammount;
        private bool reserved;
        private bool available;

        public Material(string Name, decimal Price, int Stock, int Ammount)
        {

        }

        public bool reserve(Account account)
        {
            return reserved;
        }

        public bool availabilty()
        {
            return available;
        }
    }
}
