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
            // Show MessageBox to confirm the user's intention
            DialogResult prompt = MessageBox.Show("Wollen Sie wirklich Ihren Account löschen?\nAll Ihre Daten gehen verloren.", "Achtung!", MessageBoxButtons.YesNo);
            if(prompt == DialogResult.Yes)
            {

            }
        }
    }
}