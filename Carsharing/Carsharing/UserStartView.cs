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
	public partial class UserStartView : Form
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

		public UserStartView(StartState startState)
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
					accountLogin1.Visible = true;
					accountRegistration1.Visible = false;
					accountRegistration1.Renew();
					break;
				case StartState.Registration:
					accountLogin1.Visible = false;
					accountRegistration1.Visible = true;
					accountLogin1.Renew();
					break;
			}
		}
	}
}
