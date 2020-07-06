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
    public partial class ApproveReward : Form
    {
        public ApproveReward()
        {
            InitializeComponent();
        }

        private void ApproveReward_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MainMenu()).ShowDialog();
            this.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            using (var context = new TPOpenHouseEntities())
            {
                var rewardID = Guid.Parse(txtRewardID.Text);
                var getClaim = (from x in context.UserClaims
                                where x.rewardsIDFK == rewardID
                                select x).FirstOrDefault();
                if (getClaim == null)
                {
                    MessageBox.Show("Voucher code is not assigned to anyone or has been redeemed!", "Approve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    getClaim.isClaimed = true;
                    MessageBox.Show("Voucher code is approved and redeemed!", "Approve", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    context.SaveChanges();
                    txtRewardID.Text = string.Empty;
                }
            }
        }
    }
}
