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
	public partial class EditDataView : Form
	{
		/// <summary>
		/// Create
		/// </summary>
		/// <param name="c"></param>
		public EditDataView(Customer c)
		{
			InitializeComponent();

			EditDataViewUser editDataViewUser = new EditDataViewUser(c);
			editDataViewUser.Location = new Point(0, 25);
			Controls.Add(editDataViewUser);
		}

		//public EditDataView(Vehicle v)
		//{
		//	InitializeComponent();
		//}

		public EditDataView()
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
