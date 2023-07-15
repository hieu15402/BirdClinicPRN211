﻿namespace WinFormBirdClinic
{
	partial class frmCustomer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
			label1 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			txtUserName = new System.Windows.Forms.TextBox();
			txtPassword = new System.Windows.Forms.TextBox();
			txtFullName = new System.Windows.Forms.TextBox();
			dgvCustomer = new System.Windows.Forms.DataGridView();
			button1 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			panel1 = new System.Windows.Forms.Panel();
			label2 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			pictureBox9 = new System.Windows.Forms.PictureBox();
			pictureBox7 = new System.Windows.Forms.PictureBox();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			label4 = new System.Windows.Forms.Label();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			txtStatus = new System.Windows.Forms.TextBox();
			dtpBirth = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label1.Location = new System.Drawing.Point(549, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(312, 46);
			label1.TabIndex = 2;
			label1.Text = "Manage Customer";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label3.Location = new System.Drawing.Point(300, 75);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(127, 31);
			label3.TabIndex = 3;
			label3.Text = "User name";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label8.Location = new System.Drawing.Point(300, 175);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(114, 31);
			label8.TabIndex = 3;
			label8.Text = "Password";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label11.Location = new System.Drawing.Point(300, 275);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(119, 31);
			label11.TabIndex = 3;
			label11.Text = "Full name";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label12.Location = new System.Drawing.Point(800, 75);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(157, 31);
			label12.TabIndex = 3;
			label12.Text = "Date Of Birth";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label13.Location = new System.Drawing.Point(800, 175);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(80, 31);
			label13.TabIndex = 3;
			label13.Text = "Status";
			// 
			// txtUserName
			// 
			txtUserName.Enabled = false;
			txtUserName.Location = new System.Drawing.Point(300, 120);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new System.Drawing.Size(280, 27);
			txtUserName.TabIndex = 4;
			// 
			// txtPassword
			// 
			txtPassword.Enabled = false;
			txtPassword.Location = new System.Drawing.Point(300, 220);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new System.Drawing.Size(280, 27);
			txtPassword.TabIndex = 4;
			// 
			// txtFullName
			// 
			txtFullName.Enabled = false;
			txtFullName.Location = new System.Drawing.Point(300, 320);
			txtFullName.Name = "txtFullName";
			txtFullName.Size = new System.Drawing.Size(280, 27);
			txtFullName.TabIndex = 4;
			// 
			// dgvCustomer
			// 
			dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCustomer.Location = new System.Drawing.Point(291, 364);
			dgvCustomer.Name = "dgvCustomer";
			dgvCustomer.RowHeadersWidth = 51;
			dgvCustomer.RowTemplate.Height = 29;
			dgvCustomer.Size = new System.Drawing.Size(887, 244);
			dgvCustomer.TabIndex = 7;
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(650, 312);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(94, 29);
			button1.TabIndex = 8;
			button1.Text = "Update";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new System.Drawing.Point(780, 312);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(94, 29);
			button2.TabIndex = 8;
			button2.Text = "Create";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Enabled = false;
			button3.Location = new System.Drawing.Point(910, 312);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(94, 29);
			button3.TabIndex = 8;
			button3.Text = "Save";
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Enabled = false;
			button4.Location = new System.Drawing.Point(1040, 312);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(94, 29);
			button4.TabIndex = 8;
			button4.Text = "Cancel";
			button4.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(pictureBox9);
			panel1.Controls.Add(pictureBox7);
			panel1.Controls.Add(pictureBox5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(pictureBox4);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(261, 622);
			panel1.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label2.ForeColor = System.Drawing.Color.Black;
			label2.Location = new System.Drawing.Point(114, 553);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(109, 33);
			label2.TabIndex = 3;
			label2.Text = "Logout";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label9.Font = new System.Drawing.Font("Arial", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label9.ForeColor = System.Drawing.Color.Black;
			label9.Location = new System.Drawing.Point(114, 353);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(133, 35);
			label9.TabIndex = 3;
			label9.Text = "Booking";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label7.Font = new System.Drawing.Font("Arial", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label7.ForeColor = System.Drawing.Color.Black;
			label7.Location = new System.Drawing.Point(107, 253);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(155, 35);
			label7.TabIndex = 3;
			label7.Text = "Customer";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label5.Font = new System.Drawing.Font("Arial", 19.7999973F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label5.ForeColor = System.Drawing.Color.Black;
			label5.Location = new System.Drawing.Point(114, 151);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(134, 38);
			label5.TabIndex = 2;
			label5.Text = "Service";
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new System.Drawing.Point(55, 542);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(46, 47);
			pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 2;
			pictureBox2.TabStop = false;
			// 
			// pictureBox9
			// 
			pictureBox9.Image = (System.Drawing.Image)resources.GetObject("pictureBox9.Image");
			pictureBox9.Location = new System.Drawing.Point(12, 312);
			pictureBox9.Name = "pictureBox9";
			pictureBox9.Size = new System.Drawing.Size(89, 77);
			pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox9.TabIndex = 2;
			pictureBox9.TabStop = false;
			pictureBox9.Click += pictureBox9_Click;
			// 
			// pictureBox7
			// 
			pictureBox7.Image = (System.Drawing.Image)resources.GetObject("pictureBox7.Image");
			pictureBox7.Location = new System.Drawing.Point(12, 212);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new System.Drawing.Size(89, 77);
			pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox7.TabIndex = 2;
			pictureBox7.TabStop = false;
			pictureBox7.Click += pictureBox7_Click;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new System.Drawing.Point(12, 112);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new System.Drawing.Size(89, 77);
			pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 2;
			pictureBox5.TabStop = false;
			pictureBox5.Click += pictureBox5_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Arial", 19.7999973F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label4.ForeColor = System.Drawing.Color.Black;
			label4.Location = new System.Drawing.Point(114, 51);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(122, 38);
			label4.TabIndex = 2;
			label4.Text = "Doctor";
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new System.Drawing.Point(12, 12);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(89, 77);
			pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 1;
			pictureBox4.TabStop = false;
			pictureBox4.Click += pictureBox4_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(1158, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(31, 34);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 12;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// txtStatus
			// 
			txtStatus.Enabled = false;
			txtStatus.Location = new System.Drawing.Point(800, 220);
			txtStatus.Name = "txtStatus";
			txtStatus.Size = new System.Drawing.Size(280, 27);
			txtStatus.TabIndex = 14;
			// 
			// dtpBirth
			// 
			dtpBirth.Enabled = false;
			dtpBirth.Location = new System.Drawing.Point(800, 118);
			dtpBirth.Name = "dtpBirth";
			dtpBirth.Size = new System.Drawing.Size(250, 27);
			dtpBirth.TabIndex = 15;
			// 
			// frmCustomer
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.ControlLight;
			ClientSize = new System.Drawing.Size(1190, 620);
			Controls.Add(dtpBirth);
			Controls.Add(txtStatus);
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(dgvCustomer);
			Controls.Add(txtFullName);
			Controls.Add(txtPassword);
			Controls.Add(txtUserName);
			Controls.Add(label11);
			Controls.Add(label13);
			Controls.Add(label12);
			Controls.Add(label8);
			Controls.Add(label3);
			Controls.Add(label1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Name = "frmCustomer";
			Text = "frmDoctor";
			Load += frmCustomer_Load;
			((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.DataGridView dgvCustomer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.DateTimePicker dtpBirth;
	}
}