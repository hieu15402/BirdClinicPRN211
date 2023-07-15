﻿using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBirdClinic
{
	public partial class frmService : Form
	{
		IServiceRepository repo = new ServiceRepository();
		BindingSource soure;
		public frmService()
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
			doctor.ShowDialog();
			this.Close();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			frmService service = new frmService();
			service.ShowDialog();
			this.Close();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			frmCustomer customer = new frmCustomer();
			customer.StartPosition = FormStartPosition.CenterScreen;
			customer.ShowDialog();
			this.Close();
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			frmBooking frmBookinig = new frmBooking();
			frmBookinig.StartPosition = FormStartPosition.CenterScreen;
			frmBookinig.ShowDialog();
			this.Close();
		}

		private void frmService_Load(object sender, EventArgs e)
		{
			LoadService(repo.getAllService());
		}
		public void LoadService(List<Service> list)
		{
			try
			{
				soure = new BindingSource();
				soure.DataSource = list;

				txtFee.DataBindings.Clear();
				txtServiceId.DataBindings.Clear();
				txtServiceName.DataBindings.Clear();
				txtStatus.DataBindings.Clear();

				txtFee.DataBindings.Add("Text", soure, "Fee");
				txtServiceId.DataBindings.Add("Text", soure, "ServiceId");
				txtServiceName.DataBindings.Add("Text", soure, "ServiceName");
				txtStatus.DataBindings.Add("Text", soure, "Status");

				dgvService.DataSource = null;
				dgvService.DataSource = soure;
			}
			catch (Exception ex) { }
		}
	}
}
