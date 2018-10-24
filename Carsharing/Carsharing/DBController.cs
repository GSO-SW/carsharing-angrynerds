using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Carsharing
{
	public static class DBController
	{
		static string connectionString = @"host=localhost;user=root;database=carsharingdb";

		/// <summary>
		/// Method to get the vehicle type ID from a vehicle.
		/// </summary>
		/// <param name="vehicle">Vehicle from which the vehicle type ID is to be searched for</param>
		/// <param name="VehicleTypeID">Vehicle type ID from the vehicle. 'null', if the vehicle type isn't in the DB.</param>
		/// <returns>Returns true if the connection to the database worked. False if not.</returns>
		public static bool GetVehicleTypeID(Vehicle vehicle, out int? VehicleTypeID)
		{
			DataTable table = new DataTable();
			VehicleTypeID = null;

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();
					
					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT ft.*, fm.Marke, fg.Getriebeart, ks.Kraftstoffart FROM Fahrzeugtyp ft JOIN Fahrzeugmarke fm USING (Fm_ID) JOIN Fahrzeuggetriebe fg USING (Fg_ID) JOIN Kraftstoffart ks USING (Ks_ID)", con))
					{
						a.Fill(table);
					}
				}
				catch (Exception)
				{
					return false;
				}
				finally
				{
					con.Close();
				}
			}


			foreach (DataRow row in table.Rows)
			{
				//Creates a vehicle for the current table line with all vehicle type information.
				Vehicle rowVehicle = new Vehicle(String.Empty, 0.0, new DateTime(0), 0.0, new PointD(0,0), false, row["Marke"].ToString(), row["Modell"].ToString(), Convert.ToInt32(row["Leistung"].ToString()), Convert.ToInt32(row["Baujahr"].ToString()), row["Getriebeart"].ToString(), Convert.ToDouble(row["Max_Tankvolumen"].ToString()), Convert.ToDouble(row["Grundpreis"].ToString()), Convert.ToDouble(row["Preis/km"].ToString()), Convert.ToDouble(row["Preis/min"].ToString()), new DateTime(), Convert.ToInt32(row["Anzahl der Sitze"].ToString()), row["Kraftstoffart"].ToString(), 0.0, false, false, false, false, false, false, false, false, false, false, false, false);


				//Checks whether the parameter vehicle has the same vehicle type as the created vehicle.
				if (vehicle.GetVehicleTypeString() == rowVehicle.GetVehicleTypeString())
				{
					VehicleTypeID = Convert.ToInt32(row["Ft_ID"].ToString());
					return true;
				}
			}
			return true;
		}

		/// <summary>
		/// Method to get the brand ID from a brand-string.
		/// </summary>
		/// <param name="brand">Brand from which the brand ID is to be searched for</param>
		/// <param name="vehicleBrandID">brand ID from the brand. 'null', if the brand isn't in the DB.</param>
		/// <returns>Returns true if the connection to the database worked. False if not.</returns>
		public static bool GetVehicleBrandID(string brand, out int? vehicleBrandID)
		{
			DataTable table = new DataTable();
			vehicleBrandID = null;

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM Fahrzeugmarke", con))
					{
						a.Fill(table);
					}
				}
				catch (Exception)
				{
					return false;
				}
				finally
				{
					con.Close();
				}
			}

			foreach (DataRow row in table.Rows)
			{
				//Checks whether the brand in the current row is equal to the parameter brand.
				if (row["Marke"].ToString() == brand)
				{
					vehicleBrandID = Convert.ToInt32(row["Fm_ID"].ToString());
					return true;
				}
			}
			return true;
		}

		/// <summary>
		/// Method to get the gear ID from a gear-string.
		/// </summary>
		/// <param name="gear">Gear from which the gear ID is to be searched for</param>
		/// <param name="gearID">Gear ID from the gear, 'null', if the gear isn't in the DB.</param>
		/// <returns>Returns true if the connection to the database worked. False if not.</returns>
		public static bool GetVehicleGearID(string gear, out int? gearID)
		{
			DataTable table = new DataTable();
			gearID = null;

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM Fahrzeuggetriebe", con))
					{
						a.Fill(table);
					}
				}
				catch (Exception)
				{
					return false;
				}
				finally
				{
					con.Close();
				}
			}

			foreach (DataRow row in table.Rows)
			{
				//Checks whether the gear in the current row is equal to the parameter gear.
				if (row["Getriebeart"].ToString() == gear)
				{
					gearID = Convert.ToInt32(row["Fg_ID"].ToString());
					return true;
				}
			}
			return true;
		}

		/// <summary>
		/// Method to get the fuel type ID from a gear-string.
		/// </summary>
		/// <param name="fuel">Fuel type from which the fuel type ID is to be searched for</param>
		/// <param name="fuelID">Fuel type ID from the fuel typ, 'null', if the fuel typ isn't in the DB.</param>
		/// <returns>Returns true if the connection to the database worked. False if not.</returns>
		public static bool GetFuelTypeID(string fuel, out int? fuelID)
		{
			DataTable table = new DataTable();
			fuelID = null;

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM kraftstoffart", con))
					{
						a.Fill(table);
					}
				}
				catch (Exception)
				{
					return false;
				}
				finally
				{
					con.Close();
				}
			}

			foreach (DataRow row in table.Rows)
			{
				//Checks whether the fuel type in the current row is equal to the parameter fuel typ.
				if (row["kraftstoffart"].ToString() == fuel)
				{
					fuelID = Convert.ToInt32(row["Ks_ID"].ToString());
					return true;
				}
			}
			return true;
		}

		/// <summary>
		/// Method to get a list with all number plates.
		/// </summary>
		/// <param name="numberPlates">List with all number plates</param>
		/// <returns>Returns true if the connection to the database worked. False if not.</returns>
		public static bool GetVehicleNumberPlates(out List<string> numberPlates)
		{
			DataTable table = new DataTable();
			numberPlates = new List<string>();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT Kennzeichen FROM Fahrzeug", con))
					{
						a.Fill(table);
					}
				}
				catch (Exception)
				{
					return false;
				}
				finally
				{
					con.Close();
				}
			}

			foreach (DataRow item in table.Rows)
			{
				//Add the number plate in the current row to the list.
				numberPlates.Add(item[0].ToString());
			}

			return true;
		}

		/// <summary>
		/// Method to get a list with all brands.
		/// </summary>
		/// <param name="brand">List with all brands</param>
		/// <returns>Returns true if the connection to the database worked. False if not.</returns>
		public static bool GetVehicleBrands(out List<string> brand)
		{
			DataTable table = new DataTable();
			brand = new List<string>();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT Marke FROM Fahrzeugmarke ORDER BY Fm_ID", con))
					{
						a.Fill(table);
					}
				}
				catch (Exception)
				{
					return false;
				}
				finally
				{
					con.Close();
				}
			}

			foreach (DataRow item in table.Rows)
			{
				//Add the brand in the current row to the list.
				brand.Add(item[0].ToString());
			}

			return true;
		}

		/// <summary>
		/// Method to get a list with all gears.
		/// </summary>
		/// <param name="gear">List with all gears</param>
		/// <returns>Returns true if the connection to the database worked. False if not.</returns>
		public static bool GetVehicleGears(out List<string> gear)
		{
			DataTable table = new DataTable();
			gear = new List<string>();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT Getriebeart FROM Fahrzeuggetriebe ORDER BY Fg_ID", con))
					{
						a.Fill(table);
					}
				}
				catch (Exception)
				{
					return false;
				}
				finally
				{
					con.Close();
				}
			}

			foreach (DataRow item in table.Rows)
			{
				//Add the gear in the current row to the list.
				gear.Add(item[0].ToString());
			}
			return true;
		}

		/// <summary>
		/// Method to get a list with all fuel types.
		/// </summary>
		/// <param name="fuel">List with all fuel types</param>
		/// <returns>Returns true if the connection to the database worked. False if not.</returns>
		public static bool GetFuelTypes(out List<string> fuel)
		{
			DataTable table = new DataTable();
			fuel = new List<string>();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT Kraftstoffart FROM kraftstoffart ORDER BY Ks_ID", con))
					{
						a.Fill(table);
					}
				}
				catch (Exception)
				{
					return false;
				}
				finally
				{
					con.Close();
				}
			}

			foreach (DataRow item in table.Rows)
			{
				//Add the gear in the current row to the list.
				fuel.Add(item[0].ToString());
			}
			return true;
		}

		/// <summary>
		/// Method to add a vehicle to the DB.
		/// </summary>
		/// <param name="vehicle">Vehicle to be added</param>
		/// <returns>Returns true if the connection to the database worked and the vehicle was added. False if not.</returns>
		public static bool AddVehicle(Vehicle vehicle)
		{
			//Get the vehicle type ID
			if (!GetVehicleTypeID(vehicle, out int? vehicleTypeID))
				return false;

			//Checks if the vehicle type is in the DB.
			if (vehicleTypeID == null)
			{
				//Adds the vehicle type to the DB
				if (!AddVehicleType(vehicle))
					return false;
				//Get the vehicle type ID
				if (!GetVehicleTypeID(vehicle, out vehicleTypeID))
					return false;
			}
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					using (MySqlCommand command = new MySqlCommand("INSERT INTO Fahrzeug VALUES(@Kennzeichen, @Ft_ID, @Kilometerstand, @LetzteWartung, @Tankfüllung, PointFromText(@Standort), @Verfügbarkeit, @Erstzulassung, @Kraftstoffverbrauch, @Klimaanlage, @Tempomat, @Radio, @Bluetooth, @USB, @CDSpieler, @Navi, @ABS, @ESP, @Sitzheizung, @Winter, @Raucher)", connection))
					{
						command.Parameters.Add(new MySqlParameter("Kennzeichen", vehicle.NumberPlate));
						command.Parameters.Add(new MySqlParameter("Ft_ID", vehicleTypeID));
						command.Parameters.Add(new MySqlParameter("Kilometerstand", vehicle.Mileage));
						command.Parameters.Add(new MySqlParameter("LetzteWartung", vehicle.LastMaintenance.Date));
						command.Parameters.Add(new MySqlParameter("Tankfüllung", vehicle.TankFilling));
						command.Parameters.Add(new MySqlParameter("Standort", "POINT(" + vehicle.Position.ToString() + ")"));
						command.Parameters.Add(new MySqlParameter("Verfügbarkeit", vehicle.Available));
						command.Parameters.Add(new MySqlParameter("Erstzulassung", vehicle.LastMaintenance.Date));
						command.Parameters.Add(new MySqlParameter("Kraftstoffverbrauch", vehicle.FuelConsumption));
						command.Parameters.Add(new MySqlParameter("Klimaanlage", vehicle.AirConditioner));
						command.Parameters.Add(new MySqlParameter("Tempomat", vehicle.CruiseControl));
						command.Parameters.Add(new MySqlParameter("Radio", vehicle.Radio));
						command.Parameters.Add(new MySqlParameter("Bluetooth", vehicle.Bluetooth));
						command.Parameters.Add(new MySqlParameter("USB", vehicle.USB));
						command.Parameters.Add(new MySqlParameter("CDSpieler", vehicle.CDPlayer));
						command.Parameters.Add(new MySqlParameter("Navi", vehicle.Navi));
						command.Parameters.Add(new MySqlParameter("ABS", vehicle.ABS));
						command.Parameters.Add(new MySqlParameter("ESP", vehicle.ESP));
						command.Parameters.Add(new MySqlParameter("Sitzheizung", vehicle.SeatHeating));
						command.Parameters.Add(new MySqlParameter("Winter", vehicle.WinterTire));
						command.Parameters.Add(new MySqlParameter("Raucher", vehicle.Smoker));
						
						command.ExecuteNonQuery();
					}
				}
				catch (Exception)
				{
					return false;
				}
				finally
				{
					connection.Close();
				}
			}
			return true;
		}

		/// <summary>
		/// Method to add a vehicle type to the DB.
		/// </summary>
		/// <param name="vehicle">Vehicle whose type is to be added</param>
		/// <returns>Returns true if the connection to the database worked and the vehicle type was added. False if not.</returns>
		private static bool AddVehicleType(Vehicle vehicle)
		{
			//Get the brand ID from the parameter vehicle
			if(!GetVehicleBrandID(vehicle.Brand, out int? brand))
				return false;

			//Get the gear ID from the parameter vehicle
			if (!GetVehicleGearID(vehicle.Gear, out int? gear))
				return false;

			//Get the fuel type ID from the parameter vehicle
			if (!GetFuelTypeID(vehicle.FuelType, out int? fuel))
				return false;

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					using (MySqlCommand command = new MySqlCommand(@"INSERT INTO Fahrzeugtyp VALUES(@Ft_ID, @Fm_ID, @Modell, @Leistung, @Baujahr, @Fg_ID, @Max_Tankvolumen, @Grundpreis, @PreisKm, @PreisMin, @Ks_ID, @Sitze)", connection))
					{
						command.Parameters.Add(new MySqlParameter("Ft_ID", null));
						command.Parameters.Add(new MySqlParameter("Fm_ID", brand));
						command.Parameters.Add(new MySqlParameter("Modell", vehicle.Model));
						command.Parameters.Add(new MySqlParameter("Leistung", vehicle.Power));
						command.Parameters.Add(new MySqlParameter("Baujahr", vehicle.ConstructionYear.Year));
						command.Parameters.Add(new MySqlParameter("Fg_ID", gear));
						command.Parameters.Add(new MySqlParameter("Max_Tankvolumen", vehicle.MaxTankFilling));
						command.Parameters.Add(new MySqlParameter("Grundpreis", vehicle.BasicPrice));
						command.Parameters.Add(new MySqlParameter("PreisKm", vehicle.PricePerKilometre));
						command.Parameters.Add(new MySqlParameter("PreisMin", vehicle.PricePerMinute));
						command.Parameters.Add(new MySqlParameter("Ks_ID", fuel));
						command.Parameters.Add(new MySqlParameter("Sitze", vehicle.Seats));

						command.ExecuteNonQuery();
					}

				}
				catch (Exception)
				{
					return false;
				}
				finally
				{
					connection.Close();
				}
			}
			return true;
		}
	}
}
