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

namespace WinFormBirdClinic
{
	public partial class frmBooking : Form
	{
		IBookingRepository repo = new BookingRepository();
		BindingSource source;
		public frmBooking()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
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
			service.StartPosition = FormStartPosition.CenterScreen;
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

		private void frmBooking_Load(object sender, EventArgs e)
		{
			LoadBooking(repo.getAllBooking());
		}
		public void LoadBooking(List<Booking> list)
		{
			try
			{
				source = new BindingSource();
				source.DataSource = list;

				txtBookingId.DataBindings.Clear();
				txtCustomer.DataBindings.Clear();
				txtDoctor.DataBindings.Clear();
				txtFee.DataBindings.Clear();
				txtPatientName.DataBindings.Clear();
				txtService.DataBindings.Clear();
				txtStatus.DataBindings.Clear();
				dtpBooking.DataBindings.Clear();

				txtBookingId.DataBindings.Add("Text",source,"BookingId");
				txtCustomer.DataBindings.Add("Text", source, "UsernameCustomer");
				txtDoctor.DataBindings.Add("Text", source, "UsernameDoctor");
				txtFee.DataBindings.Add("Text", source, "Fee");
				txtPatientName.DataBindings.Add("Text", source, "Patiend.BirdName");
				txtService.DataBindings.Add("Text", source, "Service.ServiceName");
				txtStatus.DataBindings.Add("Text", source, "Status.Name");
				dtpBooking.DataBindings.Add("Text", source, "BookingDate");

				dgvBooking.DataSource = null;
				dgvBooking.DataSource = source;

			}catch (Exception ex) { }
		}
	}
}
