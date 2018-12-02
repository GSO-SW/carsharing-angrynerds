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
	 partial class EditDataView : Form
	{
		/// <summary>
		/// Create
		/// </summary>
		/// <param name="c"></param>
		internal EditDataView(Customer c)
		{
			InitializeComponent();

			EditDataViewUser editDataViewUser = new EditDataViewUser(c);
			editDataViewUser.Location = new Point(0, 25);
			Controls.Add(editDataViewUser);
		}

		internal EditDataView(Vehicle v)
		{
			InitializeComponent();

			EditDataViewVehicle editDataViewVehicle = new EditDataViewVehicle(v);
			editDataViewVehicle.Location = new Point(0, 25);
			Controls.Add(editDataViewVehicle);
		}

		internal EditDataView()
		{
			InitializeComponent();

			EditDataViewVehicle editDataViewVehicle = new EditDataViewVehicle();
			editDataViewVehicle.Location = new Point(0, 25);
			Controls.Add(editDataViewVehicle);
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
