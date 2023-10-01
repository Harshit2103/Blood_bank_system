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
    public partial class DeleteDonor : Form
    {
        function fd = new function();
        public DeleteDonor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtdonorID.Text != "")
            {
                string query = "select * from newDonor where did = " + txtdonorID.Text + "";
                DataSet ds = fd.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtfathername.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtmothername.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtgender.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtbloodgrp.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][10].ToString();

                }
                else
                {
                    MessageBox.Show("Record does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdonorID.Clear();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string query = "delete from newDonor where did = " + txtdonorID.Text + "";
                fd.setData(query);
            }
            
        }

        private void txtdonorID_TextChanged(object sender, EventArgs e)
        {
            if(txtdonorID.Text == "")
            {
                txtname.Clear();
                txtfathername.Clear();
                txtmothername.Clear();
                txtDOB.ResetText();
                txtMobile.Clear();
                txtgender.ResetText();
                txtEmail.Clear();
                txtbloodgrp.ResetText();
                txtCity.Clear();
                txtAddress.Clear();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtdonorID.Clear();
        }

        private void DeleteDonor_Load(object sender, EventArgs e)
        {

        }
    }
}
