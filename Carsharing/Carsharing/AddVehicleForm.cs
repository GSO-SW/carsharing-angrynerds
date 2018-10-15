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
	public partial class AddVehicleForm : Form
	{
		public AddVehicleForm()
		{
			InitializeComponent();
			MaximizeBox = false;
			MinimizeBox = false;
			dateTimeConstructionYear.CustomFormat = "yyyy";
			dateTimeConstructionYear.ShowUpDown = true;
		}
	}
}
