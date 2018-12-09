using System;
using System.Drawing;
using System.Windows.Forms;

namespace Carsharing
{
	internal partial class MainView : Form
	{
		private Button[] selectableButtons;
		bool leftMouseDownOnPanel;
		Point clickPoint;

		internal MainView()
		{
			InitializeComponentBefore();
			InitializeComponent();
			InitializeComponentAfter();
			// to prevent graphic glitch
			((UserControl)userStatus1).BringToFront();

			DoubleBuffered = true;

            leftMouseDownOnPanel = false;

            FormController.MainView = this;
		}

		private void InitializeComponentBefore()
		{
			this.adminUsers1 = new Carsharing.MainViewAdminUsers();
			this.userBooking1 = new Carsharing.MainViewUserBooking();
			this.adminVehicles1 = new Carsharing.MainViewAdminVehicle();
			this.userStatus1 = new Carsharing.MainViewUserStatus();
		}

		private void InitializeComponentAfter()
		{
			this.buttonUsers.Tag = this.adminUsers1;

			// 
			// adminUsers1
			// 
			this.adminUsers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.adminUsers1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.adminUsers1.Location = new System.Drawing.Point(0, 0);
			this.adminUsers1.Name = "adminUsers1";
			this.adminUsers1.Size = new System.Drawing.Size(1100, 600);
			this.adminUsers1.TabIndex = 15;

			this.buttonBooking.Tag = this.userBooking1;
			
			// 
			// userBooking1
			// 
			this.userBooking1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.userBooking1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userBooking1.Location = new System.Drawing.Point(200, 25);
			this.userBooking1.Name = "userBooking1";
			this.userBooking1.Size = new System.Drawing.Size(900, 575);
			this.userBooking1.TabIndex = 12;

			this.buttonVehicles.Tag = this.adminVehicles1;
			
			// 
			// adminVehicles1
			// 
			this.adminVehicles1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.adminVehicles1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.adminVehicles1.Location = new System.Drawing.Point(0, 0);
			this.adminVehicles1.Name = "adminVehicles1";
			this.adminVehicles1.Size = new System.Drawing.Size(1100, 600);
			this.adminVehicles1.TabIndex = 16;

			this.buttonStatus.Tag = this.userStatus1;

			// 
			// userStatus1
			// 
			this.userStatus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.userStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userStatus1.Location = new System.Drawing.Point(200, 25);
			this.userStatus1.Name = "userStatus1";
			this.userStatus1.Size = new System.Drawing.Size(900, 575);
			this.userStatus1.TabIndex = 13;

			this.Controls.Add(this.userStatus1);
			this.Controls.Add(this.userBooking1);
			this.Controls.Add(this.adminVehicles1);
			this.Controls.Add(this.adminUsers1);

		}

		private void MainView_Load(object sender, EventArgs e)
		{
			if (FormController.CurrentCustomer.IsAdmin) //admin
			{
				selectableButtons = new Button[] { buttonStatus, buttonBooking, buttonVehicles, buttonUsers };
			}
			else //user
			{
				selectableButtons = new Button[] { buttonStatus, buttonBooking };
				buttonVehicles.Visible = false;
				buttonUsers.Visible = false;
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonStatus_Click(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;

			foreach (Button button in selectableButtons)
			{
				if (button == clickedButton)
					button.BackColor = Color.FromArgb(255, 40, 72);
				else
					button.BackColor = Color.FromArgb(255, 61, 90);
			}

			panelSelect.Top = clickedButton.Top;

			((UserControl)clickedButton.Tag).BringToFront();
            // Updates form after switching between them
            if (((UserControl)clickedButton.Tag) is MainViewUserStatus)
                ((MainViewUserStatus)clickedButton.Tag).UpdateForm();

            if (((UserControl)clickedButton.Tag) is MainViewUserBooking)
                ((MainViewUserBooking)clickedButton.Tag).UpdateForm();

            if (((UserControl)clickedButton.Tag) is MainViewAdminVehicle)
                ((MainViewAdminVehicle)clickedButton.Tag).UpdateTable();

            if (((UserControl)clickedButton.Tag) is MainViewAdminUsers)
                ((MainViewAdminUsers)clickedButton.Tag).UpdateTable();

        }

		internal void UpdateVehicleList()
		{
			adminVehicles1.UpdateTable();
			userBooking1.UpdateTable();
		}

		internal void UpdateCustomersList()
		{
			adminUsers1.UpdateTable();
		}

		#region main window moveable
		private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (!leftMouseDownOnPanel)
            {
                clickPoint = e.Location;
            }
            if (e.Button == MouseButtons.Left)
            {
                leftMouseDownOnPanel = true;
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftMouseDownOnPanel)
            {
                var x = e.Location - (Size)clickPoint;
                Location += (Size)x;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            leftMouseDownOnPanel = false;
        }
		#endregion
	}
}