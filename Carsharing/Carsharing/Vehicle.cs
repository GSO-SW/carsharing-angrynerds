using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	public class Vehicle
	{
		#region Attributes
		private string numberPlate;
		private double mileage;
		private DateTime lastMaintenance;
		private double tankFilling;
		private PointD position;
		private bool available;
		private string brand;
		private string model;
		private int power;
		private DateTime constructionYear;
		private string gearShift;
		private double maxTankFilling;
		private double basicPrice;
		private double pricePerKilometre;
		private double pricePerMinute;
		#endregion

		#region Propeties
		/// <summary>
		/// Number plate of the vehicle
		/// </summary>
		public string NumberPlate
		{
			get { return numberPlate; }
			set { numberPlate = value; }
		}

		/// <summary>
		/// Mileage of the vehicle
		/// </summary>
		public double Mileage
		{
			get { return mileage; }
			set { mileage = value; }
		}

		/// <summary>
		/// Last maintenance date of the vehicle
		/// </summary>
		public DateTime LastMaintenance
		{
			get { return lastMaintenance; }
			set { lastMaintenance = value; }
		}
		
		/// <summary>
		/// Tank filling of the vehicle
		/// </summary>
		public double TankFilling
		{
			get { return tankFilling; }
			set { tankFilling = value; }
		}

		/// <summary>
		/// Position of the vehicle
		/// </summary>
		public PointD Position
		{
			get { return position; }
			set { position = value; }
		}

		/// <summary>
		/// Available state of the vehicle
		/// </summary>
		public bool Available
		{
			get { return available; }
			set { available = value; }
		}

		/// <summary>
		/// Brand of the vehicle
		/// </summary>
		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		/// <summary>
		/// Model of the vehicle
		/// </summary>
		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		/// <summary>
		/// Power of the vehicle
		/// </summary>
		public int Power
		{
			get { return power; }
			set { power = value; }
		}

		/// <summary>
		/// Construction year of the vehicle
		/// </summary>
		public DateTime ConstructionYear
		{
			get { return constructionYear; }
			set { constructionYear = new DateTime(value.Year, 1, 1); }
		}

		/// <summary>
		/// Gear of the vehicle
		/// </summary>
		public string Gear
		{
			get { return gearShift; }
			set { gearShift = value; }
		}

		/// <summary>
		/// Maximum tank filling of the vehicle
		/// </summary>
		public double MaxTankFilling
		{
			get { return maxTankFilling; }
			set { maxTankFilling = value; }
		}

		/// <summary>
		/// Basic price of the vehicle
		/// </summary>
		public double BasicPrice
		{
			get { return basicPrice; }
			set { basicPrice = value; }
		}

		/// <summary>
		/// Price per kilometre of the vehicle
		/// </summary>
		public double PricePerKilometre
		{
			get { return pricePerKilometre; }
			set { pricePerKilometre = value; }
		}

		/// <summary>
		/// Price per minute of the vehicle
		/// </summary>
		public double PricePerMinute
		{
			get { return pricePerMinute; }
			set { pricePerMinute = value; }
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Create a new instance of type vehicle
		/// </summary>
		/// <param name="numberPlate">Number plate of the vehicle</param>
		/// <param name="mileage">Mileage of the vehicle</param>
		/// <param name="lastMaintenance">Last maintenance date of the vehicle</param>
		/// <param name="tankFilling">Tank filling of the vehicle</param>
		/// <param name="position">Position of the vehicle</param>
		/// <param name="available">Available state of the vehicle</param>
		/// <param name="brand">Brand of the vehicle</param>
		/// <param name="model">Model of the vehicle</param>
		/// <param name="power">Power of the vehicle</param>
		/// <param name="constructionYear">Construction year of the vehicle</param>
		/// <param name="gear">Gear of the vehicle</param>
		/// <param name="maxTankFilling">Max tank filling of the vehicle</param>
		/// <param name="basicPrice">Basic price of the vehicle</param>
		/// <param name="pricePerKilometre">price per kilometre of the vehicle</param>
		/// <param name="pricePerMinute">price per minute of the vehicle</param>
		public Vehicle(string numberPlate, double mileage, DateTime lastMaintenance, double tankFilling, PointD position, bool available, string brand, string model, int power, int constructionYear, string gear, double maxTankFilling, double basicPrice, double pricePerKilometre, double pricePerMinute)
		{
			NumberPlate = numberPlate;
			Mileage = mileage;
			LastMaintenance = lastMaintenance;
			TankFilling = tankFilling;
			Position = position;
			Available = available;
			Brand = brand;
			Model = model;
			Power = power;
			ConstructionYear = new DateTime(constructionYear, 1, 1);
			Gear = gear;
			MaxTankFilling = maxTankFilling;
			BasicPrice = basicPrice;
			PricePerKilometre = pricePerKilometre;
			PricePerMinute = pricePerMinute;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Return all vehicle type informations.
		/// </summary>
		/// <returns>All vehicle type informations</returns>
		public string GetVehicleTypeString()
		{
			string s = Brand + ";" + Model + ";" + Power + ";" + ConstructionYear + ";" + Gear + ";" + MaxTankFilling + ";" + BasicPrice + ";" + PricePerKilometre + ";" + PricePerKilometre;
			return s;
		}
		#endregion
	}
}
