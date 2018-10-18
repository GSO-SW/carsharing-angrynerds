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
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void userRegButton_Click(object sender, EventArgs e)
		{
			UserRegistrationForm urf = new UserRegistrationForm();
			urf.ShowDialog();
		}

        private void userDeleteButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}