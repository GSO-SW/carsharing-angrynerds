using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	class Booking
	{
		#region Attributes
		private Customer customer;
		private Vehicle vehicle;
		private DateTime startTime;
		private DateTime endTime;
		private double startMileage;
		private double endMileague;
		#endregion

		#region Propeties
		public Customer Customer
		{
			get { return customer; }
			set { customer = value; }
		}

		public Vehicle Vehicle
		{
			get { return vehicle; }
			set { vehicle = value; }
		}

		public DateTime StartTime
		{
			get { return startTime; }
			set { startTime = value; }
		}

		public DateTime EndTime
		{
			get { return endTime; }
			set { endTime = value; }
		}

		public double StartMileage
		{
			get { return startMileage; }
			set { startMileage = value; }
		}

		public double EndMileage
		{
			get { return endMileague; }
			set { endMileague = value; }
		}
		#endregion
	}
}
