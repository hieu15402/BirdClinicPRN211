using Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormBirdClinic.User
{
	public partial class frmUserBooking : Form
	{
		public string Username { get; set; }
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
			frmUserBooking frmBooking = new frmUserBooking
			{
				Username = Username,
			};
			frmBooking.StartPosition = FormStartPosition.CenterScreen;
			frmBooking.ShowDialog();
			this.Close();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			frmUserService frmUserService = new frmUserService
			{
				Username = Username,
			};
			frmUserService.ShowDialog();
			frmUserService.StartPosition = FormStartPosition.CenterScreen;
			this.Close();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			frmUserProfile frmUserProfile = new frmUserProfile
			{
				Username = Username,
			};
			frmUserProfile.StartPosition = FormStartPosition.CenterScreen;
			frmUserProfile.ShowDialog();
			this.Close();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			frmUserBill frmUserBill = new frmUserBill
			{
				Username = Username,
			};
			frmUserBill.StartPosition = FormStartPosition.CenterScreen;
			frmUserBill.ShowDialog();
			this.Close();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			frmUserBird frmUserBird = new frmUserBird
			{
				Username = Username,
			};
			frmUserBird.StartPosition = FormStartPosition.CenterScreen;
			frmUserBird.ShowDialog();
			this.Close();
		}
		IBookingRepository repo = new BookingRepository();
		IAccountRepository acc = new AccountRepository();
		BindingSource source;
		private void frmUserBooking_Load(object sender, EventArgs e)
		{
			LoadService();
			LoadBird();
			LoadDoctor();
			LoadBooking(repo.getBookingUser(Username));

		}
		public void LoadBooking(List<Booking> list)
		{
			try
			{
				source = new BindingSource();
				source.DataSource = list;

				txtFee.DataBindings.Clear();
				cbBird.DataBindings.Clear();
				cbDoctor.DataBindings.Clear();
				cbService.DataBindings.Clear();
				dtpBooking.DataBindings.Clear();

				dgvBooking.DataSource = null;
				dgvBooking.DataSource = source;

				txtFee.DataBindings.Add("Text", source, "Fee");
				cbBird.DataBindings.Add("Text", source, "Patiend.BirdName");
				cbDoctor.DataBindings.Add("Text", source, "UsernameDoctor");
				string name = acc.Login(cbDoctor.Text.Trim()).Name.Trim();
				cbDoctor.Text = name;
				cbService.DataBindings.Add("Text", source, "Service.ServiceName");
				dtpBooking.DataBindings.Add("Text", source, "BookingDate");

			}
			catch (Exception ex) { }
		}
		IAccountRepository account_repo = new AccountRepository();
		IServiceRepository ser_repo = new ServiceRepository();
		IPatientBirdRepository patient_repo = new PatientBirdRepository();
		public void LoadDoctor()
		{
			try
			{
				var list = account_repo.GetAccountsByRole(3);
				cbDoctor.DataSource = list;
				cbDoctor.DisplayMember = "Name";
				cbDoctor.SelectedValue = "UsernameDoctor";
			}
			catch (Exception ex) { }

		}
		public void LoadService()
		{
			try
			{
				var list = ser_repo.getAllService();
				cbService.DataSource = list;
				cbService.DisplayMember = "ServiceName";
				cbService.ValueMember = "ServiceId";
			}
			catch (Exception ex) { }
		}
		public void LoadBird()
		{
			try
			{
				var list = patient_repo.GetListBirdByUser(Username);
				cbBird.DataSource = list;
				cbBird.DisplayMember = "BirdName";
				cbBird.ValueMember = "PatientId";
			}
			catch (Exception ex) { }
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void dtpBooking_ValueChanged(object sender, EventArgs e)
		{
			DateTime date = dtpBooking.Value;
			string Date = date.ToString("yyyy-MM-dd");
			var list = account_repo.getSchedules(DateTime.Parse(Date));
			for(int i = 0; i < list.Count; i++)
			{
				cbDoctor.DisplayMember = acc.Login(list[i].Username).Name;
				cbDoctor.ValueMember = list[i].Username;
			}
		}
	}
}
