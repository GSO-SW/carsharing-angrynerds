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
		private string position;
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
		public string NumberPlate
		{
			get { return numberPlate; }
			set { numberPlate = value; }
		}

		public double Mileage
		{
			get { return mileage; }
			set { mileage = value; }
		}

		public DateTime LastMaintenance
		{
			get { return lastMaintenance; }
			set { lastMaintenance = value; }
		}

		public double TankFilling
		{
			get { return tankFilling; }
			set { tankFilling = value; }
		}

		public string Position
		{
			get { return position; }
			set { position = value; }
		}

		public bool Available
		{
			get { return available; }
			set { available = value; }
		}

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public int Power
		{
			get { return power; }
			set { power = value; }
		}

		public DateTime ConstructionYear
		{
			get { return constructionYear; }
			set { constructionYear = new DateTime(value.Year, 1, 1); }
		}

		public string GearShift
		{
			get { return gearShift; }
			set { gearShift = value; }
		}

		public double MaxTankFilling
		{
			get { return maxTankFilling; }
			set { maxTankFilling = value; }
		}

		public double BasicPrice
		{
			get { return basicPrice; }
			set { basicPrice = value; }
		}

		public double PricePerKilometre
		{
			get { return pricePerKilometre; }
			set { pricePerKilometre = value; }
		}

		public double PricePerMinute
		{
			get { return pricePerMinute; }
			set { pricePerMinute = value; }
		}
		#endregion

		#region Constructor
		public Vehicle(string numberPlate, double mileage, DateTime lastMaintenance, double tankFilling, string position, bool available, string brand, string model, int power, int constructionYear, string gearShift, double maxTankFilling, double basicPrice, double pricePerKilometre, double pricePerMinute)
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
			GearShift = gearShift;
			MaxTankFilling = maxTankFilling;
			BasicPrice = basicPrice;
			PricePerKilometre = pricePerKilometre;
			PricePerMinute = pricePerMinute;
		}
		#endregion

		#region Methods
		public string GetVehicleTypeString()
		{
			string s = Brand + ";" + Model + ";" + Power + ";" + ConstructionYear + ";" + GearShift + ";" + MaxTankFilling + ";" + BasicPrice + ";" + PricePerKilometre + ";" + PricePerKilometre;
			return s;
		}
		#endregion
	}
}
