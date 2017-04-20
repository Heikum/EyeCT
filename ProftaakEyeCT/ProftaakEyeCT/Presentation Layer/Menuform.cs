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
    public partial class Menuform : Form
    {
        private PersonRepository personrepo;
        private Person updatePerson;
        private AccountRepository accountrepo;
        private Account updateAccount;
        private MediaRepository mediarepo;
        private Media updateMedia;
        private MaterialRepository materialrepo;
        private CampingspotRepository campingspotrepo;
        private CampingSpot updateCampingspot;
        public Menuform()
        {
            InitializeComponent();
            personrepo = new PersonRepository(new PersonSQLContext());
            //mediarepo = new MediaRepository(new MediaSQLContext());
            accountrepo = new AccountRepository(new AccountSQLContext());
            materialrepo = new MaterialRepository(new MaterialSQLContext());
            campingspotrepo = new CampingspotRepository(new CampingspotSQLContext());
            UpdateControls();


        }
        //code voor person
        private void UpdateControls()
        {
            lbAllAccounts.Items.Clear();
            foreach (Account account in accountrepo.GetAllAccounts())
            {
                lbAllAccounts.Items.Add(account);
            }

            // It is only possible to edit and delete students when one is selected
            bool userSelected = lbAllAccounts.SelectedItem != null;

            lbAllMaterials.Items.Clear();
            foreach (Material material in materialrepo.GetAll())
            {
                lbAllMaterials.Items.Add(material);
            }
            lbAvailable.Items.Clear();
            foreach (CampingSpot campingspot in campingspotrepo.GetAllAvailable()) ;


        }



        private void UpdatePerson()
        {

            updatePerson.Name = txtPersonName.Text;
            updatePerson.Zipcode = txtPersonZipcode.Text;
            updatePerson.City = txtPersonCity.Text;
            updatePerson.Street = txtPersonStreet.Text;
            updatePerson.Number = (int)nudPersonHousenumber.Value;
            updatePerson.Phonenumber = txtPersonPhonenumber.Text;

            if (personrepo.Update(updatePerson))
            {
                UpdateControls();
                txtPersonName.Text = "";
                txtPersonZipcode.Text = "";
                txtPersonCity.Text = "";
                txtPersonStreet.Text = "";
                nudPersonHousenumber.Value = 0;
                txtPersonPhonenumber.Text = "";
                updatePerson = null;
            }
            else
            {
                MessageBox.Show("Updating person failed. Check if the email address is valid.");
            }
        }
        private void UpdateAccount()
        {

            updateAccount.Username = txtAccountUsername.Text;
            updateAccount.Password = txtAccountPassword.Text;
            updateAccount.Emailadress = txtAccountEmail.Text;

            if (accountrepo.UpdateAccount(updateAccount))
            {
                txtAccountUsername.Text = "";
                txtAccountPassword.Text = "";
                txtAccountEmail.Text = "";
                updateAccount = null;
            }
            else
            {
                MessageBox.Show("Updating account failed. Check if the email address is valid.");
            }
        }


        private void lbAllPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPersonEdit.Enabled = lbAllAccounts.SelectedItem != null;
            btnPersonRemove.Enabled = lbAllAccounts.SelectedItem != null;
            btnPersonUpdate.Enabled = lbAllAccounts.SelectedItem != null;

        }

        private void btnPersonUpdate_Click(object sender, EventArgs e)
        {
            updatePerson = personrepo.GetById(updateAccount.Personid);
            updateAccount = (Account)lbAllAccounts.SelectedItem;
            UpdatePerson();
            UpdateAccount();
            UpdateControls();
        }

        private void btnPersonRemove_Click(object sender, EventArgs e)
        {
            personrepo.Delete(((Person)lbAllAccounts.SelectedItem).Id);
            UpdateControls();
        }

        private void btnPersonEdit_Click(object sender, EventArgs e)
        {
            updateAccount = (Account)lbAllAccounts.SelectedItem;
            updatePerson = personrepo.GetById(updateAccount.Personid);
            txtAccountUsername.Text = updateAccount.Username;
            txtAccountPassword.Text = updateAccount.Password;
            txtAccountEmail.Text = updateAccount.Emailadress;
            txtPersonName.Text = updatePerson.Name;
            txtPersonZipcode.Text = updatePerson.Zipcode;
            txtPersonCity.Text = updatePerson.City;
            txtPersonStreet.Text = updatePerson.Street;
            nudPersonHousenumber.Value = updatePerson.Number;
            txtPersonPhonenumber.Text = updatePerson.Phonenumber;


            //updatePerson = (Person)lbAllPersons.SelectedItem;
            //txtPersonName.Text = updatePerson.Name;
            //txtPersonZipcode.Text = updatePerson.Zipcode;
            //txtPersonCity.Text = updatePerson.City;
            //txtPersonStreet.Text = updatePerson.Street;
            //nudPersonHousenumber.Value = updatePerson.Number;
            //txtPersonPhonenumber.Text = updatePerson.Phonenumber;
        }

        private void btnAccountConfirm_Click(object sender, EventArgs e)
        {

            UpdateControls();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            InsertMaterial();
        }

        private void InsertMaterial()
        {
            materialrepo.Insert(new Material(txtMaterialName.Text, Convert.ToDecimal(txtMaterialPrice.Text), Convert.ToInt32(nudMaterialStock.Value)));
            UpdateControls();

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registerform register = new Registerform();
            register.Show();
        }

        private void btnMedia_Click_1(object sender, EventArgs e)
        {
            MediaPlatform mediaPlatform = new MediaPlatform();

            mediaPlatform.Show();
        }
    }
}
