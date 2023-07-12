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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
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
            doctor.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmService service = new frmService();
            service.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.Show();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmBookinig frmBookinig = new frmBookinig();
            frmBookinig.Show();
            this.Close();
        }
    }
}
