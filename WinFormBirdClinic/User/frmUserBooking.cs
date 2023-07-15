﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBirdClinic.User
{
    public partial class frmUserBooking : Form
    {
        public frmUserBooking()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmUserBooking frmBooking = new frmUserBooking();
            frmBooking.StartPosition = FormStartPosition.CenterScreen;
            frmBooking.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmUserService frmUserService = new frmUserService();
            frmUserService.ShowDialog();
            frmUserService.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmUserProfile frmUserProfile = new frmUserProfile();
            frmUserProfile.StartPosition = FormStartPosition.CenterScreen;
            frmUserProfile.ShowDialog();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmUserBill frmUserBill = new frmUserBill();
            frmUserBill.StartPosition = FormStartPosition.CenterScreen;
            frmUserBill.ShowDialog();
            this.Close();
        }
    }
}
