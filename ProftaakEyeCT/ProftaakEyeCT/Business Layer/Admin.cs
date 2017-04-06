using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Admin : Account
    {


        public Admin(string Username, string Password, string Emailadress, bool Rights, Person person) : base(Username, Password, Emailadress, Rights, person)
        {

        }

        public override void showEvents()
        {

        }

        public void removeEvent()
        {

        }

    }
    }
