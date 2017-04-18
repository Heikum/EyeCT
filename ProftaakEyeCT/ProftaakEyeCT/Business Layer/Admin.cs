using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Admin : Account
    {
        public Admin(int Id, string kind,int personid,string Username, string Emailadress, string Password, bool Rights) : base(Id,kind,personid, Username, Emailadress, Password, Rights)
        {

        }

       

        public void removeEvent()
        {

        }

    }
    }
