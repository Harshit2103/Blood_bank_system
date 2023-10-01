using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bloodbank
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm=new Form1();
            fm.Show();
            this.Hide();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addnewdonor add=new Addnewdonor();
            add.Show();
        }

        private void updateDeatailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDonorDetail udd=new updateDonorDetail();
            udd.Show();
        }

        private void allDonorDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails all=new AllDonorDetails();
            all.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBloodDonorAddress sad=new SearchBloodDonorAddress();
            sad.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorByBlood sdbb=new SearchDonorByBlood();
            sdbb.Show();
        }

        private void increasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockincrease si=new stockincrease();
            si.Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockdecrease std=new stockdecrease();
            std.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock st = new stock();
            st.Show();
        }

        private void deleteDonorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteDonor dnt=new DeleteDonor();
            dnt.Show();
        }
    }
}
