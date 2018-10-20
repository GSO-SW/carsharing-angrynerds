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
		/// 
		/// </summary>
		public string NumberPlate
		{
			get { return numberPlate; }
			set { numberPlate = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public double Mileage
		{
			get { return mileage; }
			set { mileage = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public DateTime LastMaintenance
		{
			get { return lastMaintenance; }
			set { lastMaintenance = value; }
		}
		
		/// <summary>
		/// 
		/// </summary>
		public double TankFilling
		{
			get { return tankFilling; }
			set { tankFilling = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public PointD Position
		{
			get { return position; }
			set { position = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public bool Available
		{
			get { return available; }
			set { available = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public int Power
		{
			get { return power; }
			set { power = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public DateTime ConstructionYear
		{
			get { return constructionYear; }
			set { constructionYear = new DateTime(value.Year, 1, 1); }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Gear
		{
			get { return gearShift; }
			set { gearShift = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public double MaxTankFilling
		{
			get { return maxTankFilling; }
			set { maxTankFilling = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public double BasicPrice
		{
			get { return basicPrice; }
			set { basicPrice = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public double PricePerKilometre
		{
			get { return pricePerKilometre; }
			set { pricePerKilometre = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public double PricePerMinute
		{
			get { return pricePerMinute; }
			set { pricePerMinute = value; }
		}
		#endregion

		#region Constructor
		/// <summary>
		/// 
		/// </summary>
		/// <param name="numberPlate"></param>
		/// <param name="mileage"></param>
		/// <param name="lastMaintenance"></param>
		/// <param name="tankFilling"></param>
		/// <param name="position"></param>
		/// <param name="available"></param>
		/// <param name="brand"></param>
		/// <param name="model"></param>
		/// <param name="power"></param>
		/// <param name="constructionYear"></param>
		/// <param name="gear"></param>
		/// <param name="maxTankFilling"></param>
		/// <param name="basicPrice"></param>
		/// <param name="pricePerKilometre"></param>
		/// <param name="pricePerMinute"></param>
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
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetVehicleTypeString()
		{
			string s = Brand + ";" + Model + ";" + Power + ";" + ConstructionYear + ";" + Gear + ";" + MaxTankFilling + ";" + BasicPrice + ";" + PricePerKilometre + ";" + PricePerKilometre;
			return s;
		}
		#endregion
	}
}
