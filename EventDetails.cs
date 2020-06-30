using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPOpenHouseAdminConsole
{
    public partial class EventDetails : Form
    {
        int _eventID = 0;
        public EventDetails(int eventID)
        {
            InitializeComponent();
            _eventID = eventID;
        }

        private void EventDetails_Load(object sender, EventArgs e)
        {
            if (_eventID != 0)
            {
                using (var context = new TPOpenHouseEntities())
                {
                    var getEventDetails = (from x in context.Events
                                            where x.ID == _eventID
                                            select x).FirstOrDefault();
                    txtEventName.Text = getEventDetails.eventName;
                    txtEventVenue.Text = getEventDetails.eventVenue;
                    dateEvent.Value = getEventDetails.eventTime;
                    timeEvent.Value = getEventDetails.eventTime;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_eventID != 0)
            {
                this.Hide();
                (new ViewEvents()).ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                (new MainMenu()).ShowDialog();
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new TPOpenHouseEntities())
            {
                if (_eventID != 0)
                {
                    var getToEdit = (from x in context.Events
                                     where x.ID == _eventID
                                     select x).FirstOrDefault();
                    getToEdit.eventName = txtEventName.Text;
                    getToEdit.eventVenue = txtEventVenue.Text;
                    getToEdit.eventTime = dateEvent.Value.Date.Add(timeEvent.Value.TimeOfDay);
                    context.SaveChanges();
                    MessageBox.Show("Changes saved!", "Edit Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    (new ViewEvents()).ShowDialog();
                    this.Close();
                }
                else
                {
                    var newEvent = new Event()
                    {
                        eventName = txtEventName.Text,
                        eventVenue = txtEventVenue.Text,
                        eventTime = dateEvent.Value.Date.Add(timeEvent.Value.TimeOfDay)
                    };
                    context.Events.Add(newEvent);
                    context.SaveChanges();
                    MessageBox.Show("Changes saved!", "Add Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    (new ViewEvents()).ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
