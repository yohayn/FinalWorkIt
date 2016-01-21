using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class frmTrainee : Form
    {
        public frmTrainee()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnGoToFrmShop_Click(object sender, EventArgs e)
        {
           // frmShop frmShop = new frmShop();
            //frmShop.Show();
            this.Close();
        }

        private void btnGoToFrmActivitiesDetails_Click(object sender, EventArgs e)
        {
            frmActivitiesDetails frmActivitiesDetails = new frmActivitiesDetails();
            frmActivitiesDetails.Show();
            this.Close();
        }
    }
}
