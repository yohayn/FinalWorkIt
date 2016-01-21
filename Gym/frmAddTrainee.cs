using GYM;
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
    public partial class frmAddTrainee : Form
    {
        public frmAddTrainee()
        {
            InitializeComponent();
        }


        private void btnInsertToDB_Click_1(object sender, EventArgs e)
        {
            DataQueries.InsertTrainee(
               txtBoxTraineeID.Text, txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxAge.Text, txtBoxCity.Text
               );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTraineesManagement frmTraineesManagement = new frmTraineesManagement();
            frmTraineesManagement.Show();
            this.Close();
        }

    }
}
