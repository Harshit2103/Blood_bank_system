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
    public partial class updateDonorDetail : Form
    {
        function fn = new function();
        public updateDonorDetail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtDonorID.Text.ToString());
            string query = "select *from newDonor where did=" + id + "";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count !=0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][2].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][3].ToString();
                txtDob.Text = ds.Tables[0].Rows[0][4].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][6].ToString();
                txtEmail.Text =ds.Tables[0].Rows[0][7].ToString();
                txtBloodgrp.Text = ds.Tables[0].Rows[0][8].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void updateDonorDetail_Load(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if(txtDonorID.Text =="")
            {
                txtName.Clear();
                txtFather.Clear();
                txtMother.Clear();
                txtDob.ResetText();
                txtMobile.Clear();
                txtGender.ResetText();
                txtEmail.Clear();
                txtBloodgrp.ResetText();
                txtCity.Clear();
                txtAddress.Clear();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string query = "update newDonor set dname='" + txtName.Text + "',fname='" + txtFather.Text + "',mnane='" + txtMother.Text + "',dob='" + txtDob.Text + "',mobile=" + txtMobile.Text + ",gender='" + txtGender.Text + "',email='" + txtEmail.Text + "',bloodgroup='" + txtBloodgrp.Text + "',city='" + txtCity.Text + "',daddress='" + txtAddress.Text + "' where did=" + txtDonorID.Text + "";
            fn.setData(query);
            updateDonorDetail_Load(this,null);
        }

        private void txtDob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
