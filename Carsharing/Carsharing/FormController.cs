using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	internal static class FormController
	{
        private static Customer currentCustomer;

		/// <summary>
		/// Caches the logged in Customer.
		/// </summary>
		internal static Customer CurrentCustomer
        {
            get { return currentCustomer; }
            set { currentCustomer = value; }
        }
    }
}