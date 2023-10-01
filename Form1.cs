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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                txtpassword.PasswordChar = '\0';
                   
            }
            else
            {
                btnHideShow.Text = "Show";
                txtpassword.PasswordChar = '*';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true) {
                btnlogin.Enabled = true;
            }
            else { btnlogin.Enabled = false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogin.Enabled=false;
               
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text=="Thala" && txtpassword.Text=="Msd")
            {
                Dashboard db=new Dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid username and password.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
