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

namespace ProftaakEyeCT
{
    public partial class Form1 : Form
    {
        private PersonRepository personrepo;
        private Person updatePerson;
        public Form1()
        {
            InitializeComponent();
            personrepo = new PersonRepository(new PersonSQLContext());
            UpdateControls();


        }
        //code voor person
        private void UpdateControls()
        {
            lbAllPersons.Items.Clear();
            foreach (Person person in personrepo.GetAll())
            {
                lbAllPersons.Items.Add(person);
            }

            // It is only possible to edit and delete students when one is selected
            bool userSelected = lbAllPersons.SelectedItem != null;


        }

        private void InsertPerson()
        {
            Person person = null;
            try
            {
                person = new Person(txtPersonName.Text, txtPersonZipcode.Text, txtPersonCity.Text, txtPersonStreet.Text, (int)nudPersonHousenumber.Value, (int)nudPersonPhonenumber.Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("Adding person failed. Check if the field is valid.");
                return;
            }

            if (personrepo.Insert(person) != null)
            {
                UpdateControls();
                txtPersonName.Text = "";
                txtPersonZipcode.Text = "";
                txtPersonCity.Text = "";
                txtPersonStreet.Text = "";
                nudPersonHousenumber.Value = 0;
                nudPersonPhonenumber.Value = 0;
            }
            else
            {
                MessageBox.Show("Adding person failed. Check if the number is unique.");
            }
        }

        private void UpdatePerson()
        {
            updatePerson.Name = txtPersonName.Text;
            updatePerson.Zipcode = txtPersonZipcode.Text;
            updatePerson.City = txtPersonCity.Text;
            updatePerson.Street = txtPersonStreet.Text;
            updatePerson.Number = (int)nudPersonHousenumber.Value;
            updatePerson.Phonenumber = (int)nudPersonPhonenumber.Value;

            if (personrepo.Update(updateUser))
            {
                UpdateControls();
                txtUsername.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                nudRating.Value = 0;
                updateUser = null;
            }
            else
            {
                MessageBox.Show("Updating student failed. Check if the email address is valid.");
            }
        }
    }
}
