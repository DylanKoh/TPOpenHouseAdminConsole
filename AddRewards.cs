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
    public partial class AddRewards : Form
    {
        public AddRewards()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MainMenu()).ShowDialog();
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            using (var context = new TPOpenHouseEntities())
            {
                for (int i = 0; i < nudTotalAvailable.Value; i++)
                {
                    context.Rewards.Add(new Reward { ID = Guid.NewGuid(), rewardName = txtName.Text, pointsRequired = Convert.ToInt32(nudPointsRequired.Value) });
                    context.SaveChanges();
                }
                MessageBox.Show("Completed adding rewards!", "Add Rewards", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = string.Empty;
                nudPointsRequired.Value = 0;
                nudTotalAvailable.Value = 0;
            }
        }
    }
}
