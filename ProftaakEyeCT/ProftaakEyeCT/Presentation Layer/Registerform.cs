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
    public partial class Registerform : Form
    {
        private PersonRepository personrepo;
        private Person updatePerson;
        private AccountRepository accountrepo;
        private AccessRepository accessrepo; 
        public Registerform()
        {
            InitializeComponent();
            personrepo = new PersonRepository(new PersonSQLContext());
            accountrepo = new AccountRepository(new AccountSQLContext());
            accessrepo = new AccessRepository(new AccessSQLContext()); 
        }

        private void InsertPerson()
        {

            Person person = null;
            try
            {
                person = new Person(txtNewPersonName.Text, txtNewPersonZipcode.Text, txtNewPersonCity.Text, txtNewPersonStreet.Text, (int)nudNewPersonHousenumber.Value, txtNewPersonPhonenumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Adding person failed. Check if the field is valid.");
                return;
            }

            if (personrepo.Insert(person) != null)
            {
               

                txtNewPersonZipcode.Text = "";
                txtNewPersonCity.Text = "";
                txtNewPersonStreet.Text = "";
                nudNewPersonHousenumber.Value = 0;
                txtNewPersonPhonenumber.Text = "";
            }
            else
            {
                MessageBox.Show("Adding person failed. Check if the number is unique.");
            } 

        }
        private void InsertAccount()
        {

            Account account = null;
            updatePerson = null;
            try
            {
                updatePerson = personrepo.GetByName(txtNewPersonName.Text);
                account = new Account("Student", txtNewAccountUsername.Text, txtNewAccountEmail.Text, txtNewAccountPassword.Text, false);
            }
            catch (FormatException)
            {
                MessageBox.Show("Adding account failed. Check if the field is valid.");
                return;
            }

            if (accountrepo.InsertAccount(account, updatePerson) != null)
            {
                
                txtNewAccountUsername.Text = "";
                txtNewAccountPassword.Text = "";
                txtNewAccountEmail.Text = "";
                txtNewPersonName.Text = "";

            }
            else
            {
                MessageBox.Show("Adding account failed. Check if the number is unique.");
            }

        }
        public void insertaccess()
        {
            accessrepo.AddRFIDstatusnewaccount(accountrepo.GetID());
        }

        private void btnAccountConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewAccountUsername.Text == "" || txtNewAccountPassword.Text == "" || txtNewAccountEmail.Text == "" || txtNewPersonName.Text == "" || txtNewPersonZipcode.Text == "" || txtNewPersonCity.Text == "" || txtNewPersonStreet.Text == "" || txtNewPersonPhonenumber.Text == "")
            {
                MessageBox.Show("Not all information has been entered, please check again.");
            }
            else
            {
                try
                {
                    InsertPerson();
                    InsertAccount();                 
                    insertaccess();
                    MessageBox.Show("Your account has been created succesfully!");
                    this.Close(); 
                }
                catch (Exception exception)
                {
                    MessageBox.Show("An error has occured: " + exception); 
                }
            }
        }
    }
}
