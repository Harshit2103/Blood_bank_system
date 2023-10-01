﻿using System;
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
    public partial class AllDonorDetails : Form
    {
        function fn = new function();
        public AllDonorDetails()
        {
            InitializeComponent();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllDonorDetails_Load(object sender, EventArgs e)
        {
            string query = "select * from newDonor";
            DataSet ds=fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm=new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm,new Rectangle(0,0,this.dataGridView1.Width,this.dataGridView1.Height));   
            e.Graphics.DrawImage(bm,0,0);
        }
    }
}
