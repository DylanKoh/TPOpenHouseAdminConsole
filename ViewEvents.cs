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
    public partial class ViewEvents : Form
    {
        public ViewEvents()
        {
            InitializeComponent();
        }

        private void ViewEvents_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void LoadEvents()
        {
            using (var context = new TPOpenHouseEntities())
            {
                var getEvents = (from x in context.Events
                                 orderby x.eventTime
                                 select x);
                foreach (var item in getEvents)
                {
                    var newRow = new List<string>()
                    {item.ID.ToString() , item.eventName, item.eventVenue, item.eventTime.ToString("dd/MM/yyyy HH:mm")  };
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MainMenu()).ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an event to edit!", "Edit Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var getEventID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.Hide();
                (new EventDetails(getEventID)).ShowDialog();
                this.Close();
            }
        }
    }
}
