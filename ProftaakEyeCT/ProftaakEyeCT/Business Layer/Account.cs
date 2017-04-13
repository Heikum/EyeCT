using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public abstract class Account
    {


        private readonly int id = -1;
        private string username;
        private string password;
        private string emailadress;
        private int rights;
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Emailadress { get; set; }
        public int Rights { get; set; }

        public Account(int id, string username, string password, string emailadress, int rights)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.emailadress = emailadress;
            this.rights = rights;

        }
        public Account(string username, string password, string emailadress, int rights)
            : this(-1, username, password, emailadress, rights)
        {

        }


        //Post post
        public void placePost()
        {

        }

        public abstract void showEvents();


        public void showReservation()
        {

        }
    }

}
