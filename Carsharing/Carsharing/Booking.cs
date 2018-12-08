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

        /// <summary>
        /// Closes the booking locally.
        /// </summary>
        /// <param name="endTime">The point in time, when the booking has been closed.</param>
        /// <param name="endMileage">The mileage of the car, after the user has returned it.</param>
        internal void Close(DateTime endTime, double endMileage)
        {
            if (Open)
            {
                // Updates the booking's missing attributes
                EndTime = endTime;
                EndMileage = endMileage;
                Open = false;

                // Updates the vehicle to simulate it has been actually used
                Vehicle.Mileage = endMileage;
                Vehicle.TankFilling = Vehicle.TankFilling - Vehicle.FuelConsumption / 100 * (endMileage - StartMileage); // Fuel consumption is in 1l per 100 km, hence dividing here by 100.
            }
        }

        /// <summary>
        /// Calculates the cost of a closed booking
        /// </summary>
        /// <returns></returns>
        internal double CalculateCost()
        {
            double cost;
            if (!open)
            {
                cost = Vehicle.BasicPrice + Vehicle.PricePerKilometre * ((double)EndMileage - StartMileage) + Vehicle.PricePerMinute * EndTime.Subtract(StartTime).TotalMinutes;
            }
            else
            {
                cost = 0;
            }
            return cost;
        }

        public override string ToString()
        {
			if (open)
				return vehicle.Brand + " " + vehicle.Model + " am: " + startTime.ToString("dd.MM.yyyy") + ", offen";
			return vehicle.Brand + " " + vehicle.Model + " am: " + startTime.ToString("dd.MM.yyyy") + ", geschlossen";
		}
    }
}