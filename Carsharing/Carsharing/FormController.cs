using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	public static class FormController
	{
		private static Customer currentCustomer;
		private static UserStartView startView;
		private static Main mainView;

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
		public static UserStartView StartView
		{
			get { return startView; }
			set { startView = value; }
		}

		/// <summary>
		/// Caches the main View
		/// </summary>
		public static Main MainView
		{
			get { return mainView; }
			set { mainView = value; }
		}
	}
}