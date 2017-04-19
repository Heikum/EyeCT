using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Admin : Account
    {
        private string username;

        public Admin(string username): base(username)
        {
            this.username = username;
        }

        public Admin(int Id, string kind,int personid,string Username, string Emailadress, string Password, bool Rights) : base(Id,kind,personid, Username, Emailadress, Password, Rights)
        {

        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public void removeEvent()
        {

        }

        public override string ToString()
        {
            return username; 
        }

    }
    }
