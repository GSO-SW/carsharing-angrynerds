using System;
using System.Windows.Forms;

namespace Carsharing
{
	internal partial class LoginView : Form
	{
		internal enum StartState { Default, Login, Registration };

		private StartState state;
		internal StartState State
		{
			get { return state; }
			set
			{
				if (value != state)
				{
					state = value;
					ShowState();
				}
			}
		}

		internal LoginView(StartState startState)
		{
			this.login = new Carsharing.LoginViewLogin();
			this.registration = new Carsharing.LoginViewRegistration();
			InitializeComponent();
			InitializeComponentAfter();

			State = startState;

			FormController.StartView = this;
		}

		private void InitializeComponentAfter()
		{
			// 
			// login
			// 
			this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.login.Dock = System.Windows.Forms.DockStyle.Fill;
			this.login.Location = new System.Drawing.Point(275, 25);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(525, 425);
			this.login.TabIndex = 1;
			// 
			// registration
			// 
			this.registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.registration.Location = new System.Drawing.Point(275, 25);
			this.registration.Name = "registration";
			this.registration.Size = new System.Drawing.Size(525, 425);
			this.registration.TabIndex = 11;

			this.Controls.Add(this.login);
			this.Controls.Add(this.registration);
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		protected override void OnClosed(EventArgs e)
		{
			FormController.StartView = null;
			base.OnClosed(e);
		}

		private void ShowState()
		{
			switch (State)
			{
				case StartState.Login:
					login.BringToFront();
					registration.Renew();
					break;
				case StartState.Registration:
					registration.BringToFront();
					login.Renew();
					break;
			}
		}
	}
}
