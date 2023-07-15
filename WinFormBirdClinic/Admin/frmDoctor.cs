﻿using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBirdClinic
{
	public partial class frmDoctor : Form
	{
		public frmDoctor()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			frmDoctor doctor = new frmDoctor();
			doctor.StartPosition = FormStartPosition.CenterScreen;
			doctor.Show();
			this.Close();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			frmService service = new frmService();
			service.StartPosition = FormStartPosition.CenterScreen;
			service.Show();
			this.Close();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			frmCustomer customer = new frmCustomer();
			customer.StartPosition = FormStartPosition.CenterScreen;
			customer.Show();
			this.Close();
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			frmBookinig frmBookinig = new frmBookinig();
			frmBookinig.StartPosition = FormStartPosition.CenterScreen;
			frmBookinig.Show();
			this.Close();
		}

		private void frmDoctor_Load(object sender, EventArgs e)
		{
			LoadDoctorList(repo.GetAccountsByRole(3));
		}
		IAccountRepository repo = new AccountRepository();
		BindingSource source;
		public void LoadDoctorList(List<Account> list)
		{
			try
			{
				source = new BindingSource();
				source.DataSource = list;

				dtpBirth.DataBindings.Clear();
				txtFullName.DataBindings.Clear();
				txtPassword.DataBindings.Clear();
				txtUserName.DataBindings.Clear();
				txtStatus.DataBindings.Clear();

				dtpBirth.DataBindings.Add("Text", source, "DateOfBirth");
				txtFullName.DataBindings.Add("Text", source, "Name");
				txtPassword.DataBindings.Add("Text", source, "Password");
				txtUserName.DataBindings.Add("Text", source, "Username");
				txtStatus.DataBindings.Add("Text", source, "Status");
				dgvDoctor.DataSource = null;
				dgvDoctor.DataSource = source;

			}
			catch (Exception ex) { }
		}
	}
}
