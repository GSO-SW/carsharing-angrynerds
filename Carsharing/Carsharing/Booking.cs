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
		private DateTime startTimePoint;
		private DateTime endTimePoint;
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

		public DateTime StartTimePoint
		{
			get { return startTimePoint; }
			set { startTimePoint = value; }
		}

		public DateTime EndTimePoint
		{
			get { return endTimePoint; }
			set { endTimePoint = value; }
		}

		public double StartMilieage
		{
			get { return startMileage; }
			set { startMileage = value; }
		}

		public double EndMileague
		{
			get { return endMileague; }
			set { endMileague = value; }
		}
		#endregion
	}
}
