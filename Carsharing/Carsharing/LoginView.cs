using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing
{
	public partial class LoginView : Form
	{
		public enum StartState { Default, Login, Registration };

		private StartState state;
		public StartState State
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

		public LoginView(StartState startState)
		{
			InitializeComponent();
			ActiveControl = labelName;
			
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
					accountLogin1.BringToFront();
					accountRegistration1.Renew();
					break;
				case StartState.Registration:
					accountRegistration1.BringToFront();
					accountLogin1.Renew();
					break;
			}
		}
	}
}
