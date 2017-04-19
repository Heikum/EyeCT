using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProftaakEyectEvents.DAL;
using ProftaakEyectEvents.Prensentation_Layer;
using ProftaakEyectEvents;
using ProftaakEyeCT.Presentation_Layer;
using ProftaakEyeCT.DAL;

namespace ProftaakEyeCT
{
    public partial class Form1 : Form
    {
        private PersonRepository personrepo;
        private Person updatePerson;
        private AccountRepository accountrepo;
        private Account updateAccount;
        private MediaRepository mediarepo;
        private Media updateMedia;
        private MaterialRepository materialrepo;
        public Form1()
        {
            InitializeComponent();
            personrepo = new PersonRepository(new PersonSQLContext());
            //mediarepo = new MediaRepository(new MediaSQLContext());
            accountrepo = new AccountRepository(new AccountSQLContext());
            materialrepo = new MaterialRepository(new MaterialSQLContext());
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            bool message = accountrepo.Login(tbUsername.Text, tbPassword.Text);
            if (message == true)
            {
                MessageBox.Show("You are now logged in!");
                Menuform menu = new Menuform();
                menu.Show();
            }
            else if (message == false)
            {
                MessageBox.Show("You entered an incorrect username or password.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registerform register = new Registerform();
            register.Show();
        }
    }
}
