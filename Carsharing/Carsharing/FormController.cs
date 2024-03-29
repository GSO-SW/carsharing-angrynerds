﻿using System.Drawing;

namespace Carsharing
{
	internal static class FormController
	{
		private static Customer currentCustomer;
		private static LoginView startView;
		private static MainView mainView;

		/// <summary>
		/// Caches the logged in Customer.
		/// </summary>
		internal static Customer CurrentCustomer
		{
			get { return currentCustomer; }
			set { currentCustomer = value; }
		}

		/// <summary>
		/// Caches the start view.
		/// </summary>
		internal static LoginView StartView
		{
			get { return startView; }
			set { startView = value; }
		}

		/// <summary>
		/// Caches the main View
		/// </summary>
		internal static MainView MainView
		{
			get { return mainView; }
			set { mainView = value; }
		}

		internal static Color BackgroundColor
		{
			get { return Color.FromArgb(224, 224, 224); }
		}

		internal static string Placeholder
		{
			get { return "----------------"; }
		}
	}
}