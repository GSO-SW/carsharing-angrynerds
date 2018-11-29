using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	public static class FormController
	{
		private static Customer currentCustomer;
		private static LoginView startView;
		private static MainView mainView;

		/// <summary>
		/// Caches the logged in Customer.
		/// </summary>
		public static Customer CurrentCustomer
		{
			get { return currentCustomer; }
			set { currentCustomer = value; }
		}

		/// <summary>
		/// Caches the start view.
		/// </summary>
		public static LoginView StartView
		{
			get { return startView; }
			set { startView = value; }
		}

		/// <summary>
		/// Caches the main View
		/// </summary>
		public static MainView MainView
		{
			get { return mainView; }
			set { mainView = value; }
		}

		public static Color BackgroundColor
		{
			get { return Color.FromArgb(224, 224, 224); }
		}

	}
}