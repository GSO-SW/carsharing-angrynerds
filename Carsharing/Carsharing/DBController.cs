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
					
					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT ft.*, fm.Marke, fg.Getriebeart FROM Fahrzeugtyp ft JOIN Fahrzeugmarke fm USING (Fm_ID) JOIN Fahrzeuggetriebe fg USING (Fg_ID)", con))
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
				Vehicle rowVehicle = new Vehicle(String.Empty, 0.0, new DateTime(0), 0.0, new PointD(0,0), false, row["Marke"].ToString(), row["Modell"].ToString(), Convert.ToInt32(row["Leistung"].ToString()), Convert.ToInt32(row["Baujahr"].ToString()), row["Getriebeart"].ToString(), Convert.ToDouble(row["Max_Tankvolumen"].ToString()), Convert.ToDouble(row["Grundpreis"].ToString()), Convert.ToDouble(row["Preis/km"].ToString()), Convert.ToDouble(row["Preis/min"].ToString()));


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

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT Marke FROM Fahrzeugmarke", con))
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

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT Getriebeart FROM Fahrzeuggetriebe", con))
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

					using (MySqlCommand command = new MySqlCommand("INSERT INTO Fahrzeug VALUES(@F_ID, @Ft_ID, @Kennzeichen, @Kilometerstand, @LetzteWartung, @Tankfüllung, PointFromText(@Standort), @Verfügbarkeit)", connection))
					{
						command.Parameters.Add(new MySqlParameter("F_ID", null));
						command.Parameters.Add(new MySqlParameter("Ft_ID", vehicleTypeID));
						command.Parameters.Add(new MySqlParameter("Kennzeichen", vehicle.NumberPlate));
						command.Parameters.Add(new MySqlParameter("Kilometerstand", vehicle.Mileage));
						command.Parameters.Add(new MySqlParameter("LetzteWartung", vehicle.LastMaintenance.Date));
						command.Parameters.Add(new MySqlParameter("Tankfüllung", vehicle.TankFilling));
						command.Parameters.Add(new MySqlParameter("Standort", "POINT(" + vehicle.Position.ToString() + ")"));
						command.Parameters.Add(new MySqlParameter("Verfügbarkeit", vehicle.Available));

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

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					using (MySqlCommand command = new MySqlCommand(@"INSERT INTO Fahrzeugtyp VALUES(@Ft_ID, @Fm_ID, @Modell, @Leistung, @Baujahr, @Fg_ID, @Max_Tankvolumen, @Grundpreis, @PreisKm, @PreisMin)", connection))
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
		/// Method to add a customer to the database.
		/// </summary>
		/// <param name="c">The customer who should be added to the database.</param>
		/// <returns>Returns 0 if the operation was successful, 1 if a connection to the database could not be established or 2 if the email isn't unique.</returns>
		public static int AddCustomerToDB(Customer c)
		{
			int status = 0;
			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					// open connection to database
					con.Open();
					using (MySqlCommand command = new MySqlCommand("INSERT INTO Kunde VALUES(@K_ID, @Vorname, @Nachname, @email, @tel, @pw, @admin, @Geburtstag, @Straße, @Hausnummer, @PLZ, @Stadt, @Land)", con))
					{
						command.Parameters.AddWithValue("K_ID", null);
						command.Parameters.AddWithValue("Vorname", c.Name);
						command.Parameters.AddWithValue("Nachname", c.LastName);
						command.Parameters.AddWithValue("email", c.EmailAddress);
						command.Parameters.AddWithValue("tel", c.PhoneNumber);
						command.Parameters.AddWithValue("pw", c.Password);
						command.Parameters.AddWithValue("admin", c.IsAdmin);
						command.Parameters.AddWithValue("Geburtstag", c.Birthday);
						command.Parameters.AddWithValue("Straße", c.Street);
						command.Parameters.AddWithValue("Hausnummer", c.HouseNumber);
						command.Parameters.AddWithValue("PLZ", c.PLZ);
						command.Parameters.AddWithValue("Stadt", c.City);
						command.Parameters.AddWithValue("Land", c.Country);

						command.ExecuteNonQuery();
					}
				}
				catch (Exception e)
				{
					status = 1;
					if (((MySqlException)e).Number == 1062)
					{
						status = 2;
					}
				}
				finally
				{
					// close connection to database
					con.Close();
				}
				return status;
			}
		}

		/// <summary>
		/// Method to delete a customer from the DB.
		/// </summary>
		/// <param name="c">The customer, who is being deleted from the DB.</param>
		/// <returns>Returns a bool to determine the delete's success. True = successful delete, false = unsuccessful delete.</returns>
		public static bool DeleteUserFromDB(Customer c)
		{
			// The delete is successful at default
			bool result = true;
			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();
					// The sql delete command looks for the email address of the user in the DB
					using (MySqlCommand command = new MySqlCommand("DELETE FROM Kunde WHERE `E-Mail Adresse` = @email", con))
					{
						command.Parameters.AddWithValue("email", c.EmailAddress);

						command.ExecuteNonQuery();
					}
				}
				catch (Exception e)
				{
					// If something didn't work, set the result to false
					result = false;
				}
				finally
				{
					con.Close();
				}
				return result;
			}
		}

		/// <summary>
		/// Get a customer from the database by his email address.
		/// </summary>
		/// <param name="email">The email address which the customer should have.</param>
		/// <returns>Returns the customer as a Customer-object, or null if there is no customer with the specified email address.</returns>
		public static Customer GetCustomerByEmailFromDB(string email)
		{
			DataTable t = new DataTable();
			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();
					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM kunde WHERE `E-Mail Adresse` = @email", con))
					{
						a.SelectCommand.Parameters.AddWithValue("@email", email);
						a.Fill(t);
					}
				}
				catch (Exception e)
				{
					throw e;
				}
				finally
				{
					con.Close();
				}
			}

			if (t.Rows.Count == 1)
				return new Customer(t.Rows[0].Field<string>(1), t.Rows[0].Field<string>(2), t.Rows[0].Field<string>(3), t.Rows[0].Field<string>(4), t.Rows[0].Field<string>(5), t.Rows[0].Field<DateTime>(7), t.Rows[0].Field<string>(8), t.Rows[0].Field<string>(9), t.Rows[0].Field<string>(10), t.Rows[0].Field<string>(11), t.Rows[0].Field<string>(11), t.Rows[0].Field<bool>(6));
			else
				return null;
		}
	}
}

