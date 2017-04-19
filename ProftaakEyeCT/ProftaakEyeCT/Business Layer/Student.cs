using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Student : Account
    {
        private string username;

        public string Username1
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

        public Student(int Id, string kind, int personid, string Username, string Emailadress, string Password, bool Rights) : base(Id, kind, personid, Username, Emailadress, Password, Rights)
        {

        }


        public Student(string username) : base(username)
        {
            this.Username1 = username;
        }
                
   

        

        public void makeReservation()
        {

        }

        

        public void hireMaterial()
        {

        }

        public override string ToString()
        {
            return username;
        }
    }

}
