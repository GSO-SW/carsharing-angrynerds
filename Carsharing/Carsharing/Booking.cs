using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	internal class Booking
	{
		#region Attributes
		private Customer customer;
		private Vehicle vehicle;
		private DateTime startTime;
		private DateTime endTime;
		private double startMileage;
		private double? endMileage;
		private bool open;
		#endregion

		#region Propeties
		/// <summary>
		/// 
		/// </summary>
		internal Customer Customer
		{
			get { return customer; }
			set { customer = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal Vehicle Vehicle
		{
			get { return vehicle; }
			set { vehicle = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal DateTime StartTime
		{
			get { return startTime; }
			set { startTime = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal DateTime EndTime
		{
			get { return endTime; }
			set { endTime = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		internal double StartMileage
		{
			get { return startMileage; }
			set { startMileage = value; }
		}
		
		/// <summary>
		/// 
		/// </summary>
		internal double? EndMileage
		{
			get { return endMileage; }
			set { endMileage = value; }
		}
		
		/// <summary>
		/// 
		/// </summary>
		internal bool Open
		{
			get { return open; }
			set { open = value; }
		}
		#endregion

		internal Booking(Customer customer, Vehicle vehicle, DateTime startTime, DateTime endTime, double startMileage,double? endMileage, bool open)
		{
			this.customer = customer;
			this.vehicle = vehicle;
			this.startTime = startTime;
			this.endTime = endTime;
			this.startMileage = startMileage;
			this.endMileage = endMileage;
			this.open = open;
		}
	}
}
