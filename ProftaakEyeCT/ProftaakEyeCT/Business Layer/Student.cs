using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public class Student : Account
    {
        public Student(int Id, string kind,int personid,string Username, string Password, string Emailadress, int Rights) : base(Id,kind, personid, Username, Password, Emailadress, Rights)
        {

        }

        public void makeReservation()
        {

        }

        

        public void hireMaterial()
        {

        }
    }

}
