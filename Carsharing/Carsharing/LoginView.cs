﻿using System;
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

			State = startState;

			FormController.StartView = this;
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
