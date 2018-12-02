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
    internal static class DBController
    {
        private static readonly string connectionString = @"host=localhost;user=root;database=carsharingdb";

        #region Database information
        /// <summary>
        /// Test, if the connection to the Database is available.
        /// </summary>
        /// <returns>Return true, if the connection is available, otherwise false.</returns>
        internal static bool ConnectionAvailable()
        {
            bool result;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
                }
                finally
                {
                    con.Close();
                }
            }
            return result;
        }
        #endregion

        #region Vehicle
        /// <summary>
        /// Method to get the vehicle type ID from a vehicle.
        /// </summary>
        /// <param name="vehicle">Vehicle from which the vehicle type ID is to be searched for</param>
        /// <param name="VehicleTypeID">Vehicle type ID from the vehicle. 'null', if the vehicle type isn't in the DB.</param>
        /// <returns>Returns true if the connection to the database worked. False if not.</returns>
        internal static bool GetVehicleTypeID(Vehicle vehicle, out int? VehicleTypeID)
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
                Vehicle rowVehicle = new Vehicle(String.Empty, 0.0, new DateTime(0), 0.0, new PointD(0, 0), false, row["Marke"].ToString(), row["Modell"].ToString(), Convert.ToInt32(row["Leistung"].ToString()), Convert.ToInt32(row["Baujahr"].ToString()), row["Getriebeart"].ToString(), Convert.ToDouble(row["Max_Tankvolumen"].ToString()), Convert.ToDouble(row["Grundpreis"].ToString()), Convert.ToDouble(row["Preis/km"].ToString()), Convert.ToDouble(row["Preis/min"].ToString()), new DateTime(), Convert.ToInt32(row["Anzahl der Sitze"].ToString()), row["Kraftstoffart"].ToString(), 0.0, false, false, false, false, false, false, false, false, false, false, false, false);


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
        internal static bool GetVehicleBrandID(string brand, out int? vehicleBrandID)
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
        internal static bool GetVehicleGearID(string gear, out int? gearID)
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
        internal static bool GetFuelTypeID(string fuel, out int? fuelID)
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
        internal static bool GetVehicleNumberPlates(out List<string> numberPlates)
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
        internal static bool GetVehicleBrands(out List<string> brand)
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
        internal static bool GetVehicleGears(out List<string> gear)
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
        internal static bool GetFuelTypes(out List<string> fuel)
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
        internal static bool AddVehicle(Vehicle vehicle)
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
		/// Method to check if a vehicle is used in open bookings.
		/// </summary>
		/// <param name="v">The vehicle, whose bookings require a check.</param>
		/// <param name="result">Is true, if the customer has open bookings in the DB. Is false, if he doesn't.</param>
		/// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
		internal static bool CheckOpenBookingVehicle(Vehicle v, out bool result)
		{
			// The result of the check is false at default
			result = true;
			bool status = true;
			DataTable table = new DataTable();
			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();
					// Get a list of all B_IDs matching the customer's email-address and checks,
					// if the ending mileage equals NULL, indicating the booking is still open.
					using (MySqlCommand command = new MySqlCommand("Select B_ID FROM buchung WHERE `Kennzeichen` = @kennzeichen AND Endkilometerstand IS NULL", con))
					{
						command.Parameters.AddWithValue("kennzeichen", v.NumberPlate);
						// Transfer the found B_IDs into a table via the MySqlDataAdapter...
						using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
						{
							adapter.Fill(table);
						}
					}
				}
				catch (Exception)
				{
					status = false;
				}
				finally
				{
					con.Close();
				}
			}
			// The rows length is > 0, when B_IDs have been found, hence give a positive result
			if (table.Rows.Count == 0)
			{
				result = false;
			}
			return status;
		}
		
		internal static bool GetAllVehiclesFromDB(out List<Vehicle> vehicles)
		{
			DataTable table = new DataTable();
			vehicles = new List<Vehicle>();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();
					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM `fahrzeug` JOIN `fahrzeugtyp` USING(`Ft_ID`) JOIN `fahrzeugmarke` USING(`Fm_ID`) JOIN `fahrzeuggetriebe` USING(`Fg_ID`) JOIN `kraftstoffart` USING(`Ks_ID`)", con))
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
				vehicles.Add(GetVehicleFromDataRow(item));
			}

			return true;
		}

		private static Vehicle GetVehicleFromDataRow(DataRow row)
		{
			Vehicle v = new Vehicle();

			try
			{
				v.ABS = row.Field<bool>("ABS");
				v.AirConditioner = row.Field<bool>("Klimaanlage");
				v.Available = row.Field<bool>("Verfuegbarkeit");
				v.BasicPrice = row.Field<double>("Grundpreis");
				v.Bluetooth = row.Field<bool>("Bluetooth");
				v.Brand = row.Field<string>("Marke");
				v.CDPlayer = row.Field<bool>("CD-Spieler");
				v.ConstructionYear = row.Field<int>("Baujahr");
				v.CruiseControl = row.Field<bool>("Tempomat");
				v.ESP = row.Field<bool>("ESP");
				v.FuelConsumption = row.Field<double>("Kraftstoffverbrauch");
				v.FuelType = row.Field<string>("Kraftstoffart");
				v.Gear = row.Field<string>("Getriebeart");
				v.LastMaintenance = row.Field<DateTime>("Letzte Wartung");
				v.MaxTankFilling = row.Field<double>("Max_Tankvolumen");
				v.Mileage = row.Field<double>("Kilometerstand");
				v.Model = row.Field<string>("Modell");
				v.Navi = row.Field<bool>("Navigationsgeraet");
				v.NumberPlate = row.Field<string>("Kennzeichen");
				v.Position = new PointD(0, 0);
				v.Power = row.Field<int>("Leistung");
				v.PricePerKilometre = row.Field<double>("Preis/km");
				v.PricePerMinute = row.Field<double>("Preis/min");
				v.Radio = row.Field<bool>("Radio");
				v.Registration = row.Field<DateTime>("Erstzulassung");
				v.SeatHeating = row.Field<bool>("Sitzheizung");
				v.Seats = row.Field<int>("Anzahl der Sitze");
				v.Smoker = row.Field<bool>("Raucher");
				v.TankFilling = row.Field<double>("Tankfuellung");
				v.USB = row.Field<bool>("USB");
				v.WinterTire = row.Field<bool>("Winterreifen");
			}
			catch (Exception)
			{
				v = new Vehicle();
			}

			return v;
		}

		private static PointD GetPointDFromPointMySQL(string a)
		{
			PointD point = new PointD(0, 0);
			return point;
		}

		/// <summary>
		/// Method to add a vehicle type to the DB.
		/// </summary>
		/// <param name="vehicle">Vehicle whose type is to be added</param>
		/// <returns>Returns true if the connection to the database worked and the vehicle type was added. False if not.</returns>
		private static bool AddVehicleType(Vehicle vehicle)
		{
			//Get the brand ID from the parameter vehicle
			if (!GetVehicleBrandID(vehicle.Brand, out int? brand))
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
                        command.Parameters.Add(new MySqlParameter("Baujahr", vehicle.ConstructionYear));
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
		#endregion

		#region Customer
		/// <summary>
		/// Method to add a customer to the database.
		/// </summary>
		/// <param name="c">The customer who should be added to the database.</param>
		/// <returns>Returns 0 if the operation was successful, 1 if a connection to the database could not be established or 2 if the email isn't unique.</returns>
		internal static int AddCustomerToDB(Customer c)
		{
			int status = 0;
			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					// open connection to database
					con.Open();
					using (MySqlCommand command = new MySqlCommand("INSERT INTO `kunde`(`E-Mail Adresse`, `Vorname`, `Nachname`, `Telefonnummer`, `Passwort`, `admin`, `Geburtstag`, `Strasse`, `Hausnummer`, `PLZ`, `Stadt`, `Land`) VALUES(@email, @Vorname, @Nachname, @tel, @pw, @admin, @Geburtstag, @Straße, @Hausnummer, @PLZ, @Stadt, @Land)", con))
					{
						command.Parameters.AddWithValue("email", c.EmailAddress);
						command.Parameters.AddWithValue("Vorname", c.Name);
						command.Parameters.AddWithValue("Nachname", c.LastName);
						command.Parameters.AddWithValue("tel", c.PhoneNumber);
						command.Parameters.AddWithValue("pw", c.PasswordHash);
						command.Parameters.AddWithValue("admin", c.IsAdmin);
						command.Parameters.AddWithValue("Geburtstag", c.Birthday);
						command.Parameters.AddWithValue("Strasse", c.Street);
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
        /// Method to update a customer in the database.
        /// </summary>
        /// <param name="c">The object that contains the new information of the customer.</param>
        /// <param name="email">Email address from the customer, which should be updated.</param>
        /// <returns></returns>
        internal static int UpdateCustomerInDB(Customer c, string email)
        {
            int status = 0;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("UPDATE `kunde` SET `E-Mail Adresse`=@email,`Vorname`=@Vorname,`Nachname`=@Nachname,`Telefonnummer`=@tel,`Passwort`=@pw,`admin`=@admin,`Geburtstag`=@Geburtstag,`Strasse`=@Strasse,`Hausnummer`=@Hausnummer,`PLZ`=@PLZ,`Stadt`=@Stadt,`Land`=@Land WHERE `E-Mail Adresse`=@reqemail", con))
                    {
                        command.Parameters.AddWithValue("Vorname", c.Name);
                        command.Parameters.AddWithValue("Nachname", c.LastName);
                        command.Parameters.AddWithValue("email", c.EmailAddress);
                        command.Parameters.AddWithValue("tel", c.PhoneNumber);
                        command.Parameters.AddWithValue("pw", c.PasswordHash);
                        command.Parameters.AddWithValue("admin", c.IsAdmin);
                        command.Parameters.AddWithValue("Geburtstag", c.Birthday);
                        command.Parameters.AddWithValue("Strasse", c.Street);
                        command.Parameters.AddWithValue("Hausnummer", c.HouseNumber);
                        command.Parameters.AddWithValue("PLZ", c.PLZ);
                        command.Parameters.AddWithValue("Stadt", c.City);
                        command.Parameters.AddWithValue("Land", c.Country);
                        command.Parameters.AddWithValue("reqemail", email);

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
        internal static bool DeleteUserFromDB(Customer c)
        {
            // The delete is successful at default
            bool result = true;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // The sql update command replaces the users email address with "deleted" in the "Buchung" table
                    using (MySqlCommand command = new MySqlCommand("UPDATE Buchung SET `E-Mail Adresse` = 'admin@system.de' WHERE `E-Mail Adresse` = @email", con))
                    {
                        command.Parameters.AddWithValue("email", c.EmailAddress);
                        command.ExecuteNonQuery();
                    }
                    // The sql delete command looks for the email address of the user in the "Kunde" table
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM Kunde WHERE `E-Mail Adresse` = @email", con))
                    {
                        command.Parameters.AddWithValue("email", c.EmailAddress);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
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
		/// Method to check if a customer has open bookings.
		/// </summary>
		/// <param name="c">The customer, whose bookings require a check.</param>
		/// <param name="result">Is true, if the customer has open bookings in the DB. Is false, if he doesn't.</param>
		/// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
		internal static bool CheckOpenBookingsCustomer(Customer c, out bool result)
        {
            // The result of the check is false at default
            result = true;
			bool status = true;
            DataTable table = new DataTable();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Get a list of all B_IDs matching the customer's email-address and checks,
                    // if the ending mileage equals NULL, indicating the booking is still open.
                    using (MySqlCommand command = new MySqlCommand("Select B_ID FROM buchung WHERE `E-Mail Adresse` = @email AND Endkilometerstand IS NULL", con))
                    {
                        command.Parameters.AddWithValue("email", c.EmailAddress);
                        // Transfer the found B_IDs into a table via the MySqlDataAdapter...
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
                catch (Exception)
                {
					status = false;
                }
                finally
                {
                    con.Close();
                }
            }
            // The rows length is > 0, when B_IDs have been found, hence give a positive result
            if (table.Rows.Count == 0)
            {
                result = false;
            }
            return status;
        }

		/// <summary>
		/// Get a customer from the database by his email address.
		/// </summary>
		/// <param name="email">The email from the customer who is requested.</param>
		/// <param name="customer">The customer, who is requested. If the object is null,if there isn't a customer with this email.</param>
		/// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
		internal static bool GetCustomerByEmailFromDB(string email, out Customer customer)
        {
			customer = null;
			bool status = true;
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
				catch (Exception)
				{
					status = false;
				}
                finally
                {
                    con.Close();
                }
            }

			if (t.Rows.Count == 1)
			{
				customer = GetCustomerFromDataRow(t.Rows[0]);
			}
			return status;
        }

		/// <summary>
		/// Get all customer from the database.
		/// </summary>
		/// <param name="customers">List of all customers.</param>
		/// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
		internal static bool GetAllCustomerFromDB(out List<Customer> customers)
		{
			customers = new List<Customer>();
			bool status = true;
			DataTable t = new DataTable();
			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();
					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM kunde", con))
					{
						a.Fill(t);
					}
				}
				catch (Exception)
				{
					status = false;
				}
				finally
				{
					con.Close();
				}
			}

			foreach (DataRow item in t.Rows)
			{
				customers.Add(GetCustomerFromDataRow(item));
			}

			return status;
		}

		private static Customer GetCustomerFromDataRow(DataRow row)
		{
			Customer c;
			try
			{
				c = new Customer(row.Field<string>("Vorname"), row.Field<string>("Nachname"), row.Field<string>("E-Mail Adresse"), row.Field<string>("Telefonnummer"), row.Field<string>("Passwort"), row.Field<DateTime>("Geburtstag"), row.Field<string>("Strasse"), row.Field<string>("Hausnummer"), row.Field<string>("PLZ"), row.Field<string>("Stadt"), row.Field<string>("Land"), row.Field<bool>("admin"));
			}
			catch (Exception)
			{
				c = null;
			}
			return c;
		}

		public static bool GetCustomers(out List<Customer> customers)
		{
			DataTable table = new DataTable();
			customers = new List<Customer>();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM kunde", con))
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
				Customer c = new Customer();
				c.EmailAddress = item[0].ToString();
				c.Name = item[1].ToString();
				c.LastName = item[2].ToString();
				c.PhoneNumber = item[3].ToString();
				c.PasswordHash = item[4].ToString();
				c.IsAdmin = Convert.ToBoolean(item[5].ToString());
				c.Birthday = DateTime.Parse(item[6].ToString());
				c.Street = item[7].ToString();
				c.HouseNumber = item[8].ToString();
				c.PLZ = item[9].ToString();
				c.City = item[10].ToString();
				c.Country = item[11].ToString();

				customers.Add(c);
			}
			return true;
		}
		#endregion

		#region Booking
		/// <summary>
		/// Method to add a booking into the database.
		/// </summary>
		/// <param name="b">The booking, which should be added.</param>
		/// <returns>Returns true, if the insertion was successful, otherwise false.</returns>
		internal static bool AddBookingToDB(Booking b)
		{
			//return value, true means, successful
			bool status = true;
			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();
					using (MySqlCommand command = new MySqlCommand("INSERT INTO `buchung` (`B_ID`, `Kennzeichen`, `E-Mail Adresse`, `Startzeitpunkt`, `Endzeitpunkt`, `Startkilometerstand`, `Endkilometerstand`) VALUES (NULL, @Kennzeichen, @email, @startzeit, @endzeit, @startkm, @endkm);", con))
					{
						//(NULL, @Kennzeichen, @email, @startzeit, @endzeit, @startkm, @endkm)
						command.Parameters.AddWithValue("Kennzeichen", b.Vehicle.NumberPlate);
						command.Parameters.AddWithValue("email", b.Customer.EmailAddress);
						command.Parameters.AddWithValue("startzeit", b.StartTime);
						if (b.Open)
							command.Parameters.AddWithValue("endzeit", null);
						else
							command.Parameters.AddWithValue("endzeit", b.EndTime);
						command.Parameters.AddWithValue("startkm", b.StartMileage);
						if (b.Open)
							command.Parameters.AddWithValue("endkm", null);
						else
							command.Parameters.AddWithValue("end", b.EndMileage);
						command.ExecuteNonQuery();
					}
				}
				catch (Exception)
				{
					status = false;
				}
				finally
				{
					con.Close();
				}
			}
			return status;
		}
		#endregion
	}
}
