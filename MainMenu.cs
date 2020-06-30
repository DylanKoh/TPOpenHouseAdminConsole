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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddRewards_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new AddRewards()).ShowDialog();
            this.Close();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new EventDetails(0)).ShowDialog();
            this.Close();
        }

        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new ViewEvents()).ShowDialog();
            this.Close();
        }
    }
}
