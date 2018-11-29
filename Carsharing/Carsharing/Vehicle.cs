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
		private int constructionYear;
		private string gearShift;
		private double maxTankFilling;
		private double basicPrice;
		private double pricePerKilometre;
		private double pricePerMinute;
		private DateTime registration;
		private int seats;
		private string fuelType;
		private double fuelConsumption;
		private bool airConditioner;
		private bool cruiseControl;
		private bool radio;
		private bool bluetooth;
		private bool usb;
		private bool cdPlayer;
		private bool navigationDevice;
		private bool abs;
		private bool esp;
		private bool seatHeating;
		private bool winterTire;
		private bool smoker;
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
		public int ConstructionYear
		{
			get { return constructionYear; }
			set { constructionYear = value; }
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

		/// <summary>
		/// Registration day of the vehicle
		/// </summary>
		public DateTime Registration
		{
			get { return registration; }
			set { registration = value; }
		}

		/// <summary>
		/// Number of seats of the vehicle
		/// </summary>
		public int Seats
		{
			get { return seats; }
			set { seats = value; }
		}

		/// <summary>
		/// Fuel type of the vehicle
		/// </summary>
		public string FuelType
		{
			get { return fuelType; }
			set { fuelType = value; }
		}

		/// <summary>
		/// Fuel consumption of the vehicle
		/// </summary>
		public double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}

		/// <summary>
		/// Air conditioner state of the vehicle
		/// </summary>
		public bool AirConditioner
		{
			get { return airConditioner; }
			set { airConditioner = value; }
		}

		/// <summary>
		/// Cruise control state of the vehicle
		/// </summary>
		public bool CruiseControl
		{
			get { return cruiseControl; }
			set { cruiseControl = value; }
		}

		/// <summary>
		/// Radio state of the vehicle
		/// </summary>
		public bool Radio
		{
			get { return radio; }
			set { radio = value; }
		}

		/// <summary>
		/// Bluetooth state of the vehicle
		/// </summary>
		public bool Bluetooth
		{
			get { return bluetooth; }
			set { bluetooth = value; }
		}

		/// <summary>
		/// USB state of the vehicle
		/// </summary>
		public bool USB
		{
			get { return usb; }
			set { usb = value; }
		}

		/// <summary>
		/// CD player state of the vehicle
		/// </summary>
		public bool CDPlayer
		{
			get { return cdPlayer; }
			set { cdPlayer = value; }
		}

		/// <summary>
		/// Navi state of the vehicle
		/// </summary>
		public bool Navi
		{
			get { return navigationDevice; }
			set { navigationDevice = value; }
		}

		/// <summary>
		/// ABS state of the vehicle
		/// </summary>
		public bool ABS
		{
			get { return abs; }
			set { abs = value; }
		}

		/// <summary>
		/// ESP state of the vehicle
		/// </summary>
		public bool ESP
		{
			get { return esp; }
			set { esp = value; }
		}

		/// <summary>
		/// Seat heating state of the vehicle
		/// </summary>
		public bool SeatHeating
		{
			get { return seatHeating; }
			set { seatHeating = value; }
		}

		/// <summary>
		/// Winter tire state of the vehicle
		/// </summary>
		public bool WinterTire
		{
			get { return winterTire; }
			set { winterTire = value; }
		}

		/// <summary>
		/// Smoker state of the vehicle
		/// </summary>
		public bool Smoker
		{
			get { return smoker; }
			set { smoker = value; }
		}

		public string DisplayMember
		{
			get { return brand + " " + model + ", \"" + numberPlate + "\""; }
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
		/// <param name="registration"></param>
		/// <param name="seats"></param>
		/// <param name="fuelType"></param>
		/// <param name="fuelConsumption"></param>
		/// <param name="airCond"></param>
		/// <param name="cruiseControl"></param>
		/// <param name="radio"></param>
		/// <param name="bluetooth"></param>
		/// <param name="usb"></param>
		/// <param name="cdPlayer"></param>
		/// <param name="navi"></param>
		/// <param name="abs"></param>
		/// <param name="esp"></param>
		/// <param name="seatHeating"></param>
		/// <param name="winter"></param>
		/// <param name="smoker"></param>
		public Vehicle(
			string numberPlate, double mileage, DateTime lastMaintenance, double tankFilling, PointD position, bool available, string brand, string model, 
			int power, int constructionYear, string gear, double maxTankFilling, double basicPrice, double pricePerKilometre, double pricePerMinute, DateTime registration, 
			int seats, string fuelType, double fuelConsumption, bool airCond, bool cruiseControl, bool radio, bool bluetooth, bool usb, 
			bool cdPlayer, bool navi, bool abs, bool esp, bool seatHeating, bool winter, bool smoker)
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
			ConstructionYear = constructionYear;
			Gear = gear;
			MaxTankFilling = maxTankFilling;
			BasicPrice = basicPrice;
			PricePerKilometre = pricePerKilometre;
			PricePerMinute = pricePerMinute;
			Registration = registration;
			Seats = seats;
			FuelType = fuelType;
			FuelConsumption = fuelConsumption;
			AirConditioner = airCond;
			CruiseControl = cruiseControl;
			Radio = radio;
			Bluetooth = bluetooth;
			USB = usb;
			CDPlayer = cdPlayer;
			Navi = navi;
			ABS = abs;
			ESP = esp;
			SeatHeating = seatHeating;
			WinterTire = winter;
			Smoker = smoker;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Return all vehicle type informations.
		/// </summary>
		/// <returns>All vehicle type informations</returns>
		public string GetVehicleTypeString()
		{
			string s = Brand + ";" + Model + ";" + Power + ";" + ConstructionYear + ";" + Gear + ";" + MaxTankFilling + ";" + BasicPrice + ";" + PricePerKilometre + ";" + PricePerKilometre + ";" + FuelType + ";" + Seats;
			return s;
		}

		public override string ToString()
		{
			return DisplayMember;
		}
		#endregion
	}
}
