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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void btnGoToFrmActivities_Click(object sender, EventArgs e)
        {
            frmActivities frmActivities = new frmActivities();
            this.Hide();
            frmActivities.ShowDialog();
        }
    }
}
