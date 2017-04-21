using ProftaakEyectEvents;
using ProftaakEyectEvents.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProftaakEyeCT.Presentation_Layer
{
    public partial class EventPlatform : Form
    {

        private EventRepository eventrepo;
        private Event updateEvent;


        public EventPlatform()
        {
            InitializeComponent();
            eventrepo = new EventRepository(new EventSQLContext());
            UpdateControls();
        }

        private void UpdateControls()
        {
            lbAllEvents.Items.Clear();
            foreach (Event events in eventrepo.GetAllEvents())
            {
                lbAllEvents.Items.Add(events);
            }

            // It is only possible to edit and delete events when one is selected
            bool userSelected = lbAllEvents.SelectedItem != null;
        }

        private void InsertEvent()
        {
            Event events = null;
            try
            {
                events = new Event(txtEventDescription.Text, txtEventName.Text, txtEventLocation.Text, Convert.ToDateTime(dtpEventStartDate.Value.ToString("dd/MM/yyyy")), Convert.ToDateTime(dtpEventEndDate.Value.ToString("dd/MM/yyyy")));
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Adding event failed. Check if the field is valid.");
                return;
            }

            if (eventrepo.InsertEvent(events) != null)
            {
                updateEvent = eventrepo.GetByName(txtEventName.Text);
                for (int i = 1; i < 11; i++)
                {

                    eventrepo.InsertCampingspot(updateEvent, i, false);
                }
                UpdateControls();
                txtEventDescription.Text = "";
                txtEventName.Text = "";
                txtEventLocation.Text = "";
                dtpEventStartDate.Value = DateTime.Today;
                dtpEventEndDate.Value = DateTime.Today;
            }
            else
            {
                MessageBox.Show("Adding event failed. Check if the number is unique.");
            }
        }

        private void UpdateEvent()
        {

            updateEvent.description = txtEventDescription.Text;
            updateEvent.name = txtEventName.Text;
            updateEvent.location = txtEventLocation.Text;
            updateEvent.eventstartdate = dtpEventStartDate.Value;
            updateEvent.eventenddate = dtpEventEndDate.Value;

            /* Hiermee kan ik mogelijk de datetimepicker instellen dat het alleen een datum zonder tijd meegeeft
            updateEvent.eventenddate = Convert.ToDateTime(dtpEventEndDate.Value.ToString("dd/MM/yyyy")); */



            if (eventrepo.UpdateEvents(updateEvent))
            {
                UpdateControls();
                txtEventDescription.Text = "";
                txtEventName.Text = "";
                txtEventLocation.Text = "";
                dtpEventStartDate.Value = DateTime.Today;
                dtpEventEndDate.Value = DateTime.Today;
                updateEvent = null;
            }
            else
            {
                MessageBox.Show("Updating event failed. Check if the location is valid.");
            }
        }

        private void btnEventEdit_Click(object sender, EventArgs e)
        {

            updateEvent = (Event)lbAllEvents.SelectedItem;
            txtEventDescription.Text = updateEvent.description;
            txtEventName.Text = updateEvent.name;
            txtEventLocation.Text = updateEvent.location;
            dtpEventStartDate.Value = updateEvent.eventstartdate;
            dtpEventEndDate.Value = updateEvent.eventenddate;

        }

        private void lbAllEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEventEdit.Enabled = lbAllEvents.SelectedItem != null;
            btnEventRemove.Enabled = lbAllEvents.SelectedItem != null;
            btnEventUpdate.Enabled = lbAllEvents.SelectedItem != null;
        }

        private void btnEventUpdate_Click(object sender, EventArgs e)
        {
            updateEvent = (Event)lbAllEvents.SelectedItem;
            UpdateEvent();
        }

        private void btnEventRemove_Click(object sender, EventArgs e)
        {
            eventrepo.DeleteEvent(((Event)lbAllEvents.SelectedItem).id);
            UpdateControls();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(dtpEventEndDate.Value));
        }

        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            InsertEvent();
        }
    }
}
