﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyectEvents
{
    public abstract class Account
    {


        private int id;
        private string kind;
        private int personid;
        private string username;
        private string password;
        private string emailadress;
        private int rights;
        public int Id { get { return id; } set { id = value; } }
        public int Personid { get { return personid; } set { personid =value; } }

        public string Kind { get { return kind; } set { kind = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Emailadress { get { return emailadress; } set { emailadress = value; } }
        public int Rights { get {return rights;} set{rights =  value; }}

        public Account(int id, string kind, int personid,  string username, string password, string emailadress, int rights)
        {
            this.id = id;
            this.kind = kind;
            this.personid = personid;
            this.username = username;
            this.password = password;
            this.emailadress = emailadress;
            this.rights = rights;

        }
        public Account(string kind,string username, string password, string emailadress, int rights)
            : this(-1 ,kind,-1, username, password, emailadress, rights)
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
        public override string ToString()
        {
            return username + " " + password + " " + emailadress;
        }
    }

}
