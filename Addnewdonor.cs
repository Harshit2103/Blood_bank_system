using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bloodbank
{
    public partial class Addnewdonor : Form
    {
        function fn = new function();
        public Addnewdonor()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtfathername.Clear();
            txtmother.Clear();
            txtdob.ResetText();
            txtmobile.Clear();
            cmbgender.ResetText();
            txtemail.Clear();
            txtbloodgrp.ResetText();
            txtcity.Clear();
            richtxtaddress.Clear();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtname.Text!="" && txtfathername.Text!="" && txtmother.Text!="" && txtdob.Text!="" && txtmobile.Text!="" && cmbgender.Text!="" && txtemail.Text!="" && txtbloodgrp.Text!="" && txtcity.Text!="" && richtxtaddress.Text!="")
            {
                string dname=txtname.Text;
                string fname=txtfathername.Text;
                string mname=txtmother.Text;
                string dob=txtdob.Text;
                Int64 mobile=Int64.Parse(txtmobile.Text);
                string gender=cmbgender.Text;
                string emial=txtemail.Text;
                string bgroup=txtbloodgrp.Text;
                string city=txtcity.Text;
                string address=richtxtaddress.Text;
                string query = "insert into newDonor (dname,fname,mnane,dob,mobile,gender,email,bloodgroup,city,daddress) values('" + txtname.Text + "','" + txtfathername.Text + "','" + txtmother.Text + "','" + txtdob.Text + "'," + mobile + ",'" + cmbgender.Text + "','" + txtemail.Text + "','" + txtbloodgrp.Text + "','" + txtcity.Text + "','" + richtxtaddress.Text + "')";
                fn.setData(query);
               
            }
            else
            {
                MessageBox.Show("Fill all fields.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void Addnewdonor_Load(object sender, EventArgs e)
        {
            string query = "select max(did) from newDonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtnewdonorid.Text = (count + 1).ToString();
        }
    }
}