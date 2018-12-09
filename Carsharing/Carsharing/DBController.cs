using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace Carsharing
{
	internal static class DBController
    {
        private static readonly string connectionString = @"host=localhost;user=root;database=carsharingdb";

        #region Database information
        /// <summary>
        /// Test, if the connection to the database is available.
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
        /// Try to fetches a vehicle from the database with a corresponding number plate.
        /// </summary>
        /// <param name="numberPlate">The number plate of the vehicle you are looking for.</param>
        /// <param name="vehicle">The found vehicle. Is null if no vehicle is found.</param>
        /// <returns>Returns true, if the access to the database was successfull.</returns>
        internal static bool TryGetVehicleByNumberPlate(string numberPlate, out Vehicle vehicle)
        {
            bool status = true;
            DataTable table = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM `fahrzeug` JOIN `fahrzeugtyp` USING(`Ft_ID`) JOIN `fahrzeugmarke` USING(`Fm_ID`) JOIN `fahrzeuggetriebe` USING(`Fg_ID`) JOIN `kraftstoffart` USING(`Ks_ID`) WHERE Kennzeichen = @kennzeichen", con))
                    {
                        a.SelectCommand.Parameters.AddWithValue("kennzeichen", numberPlate);
                        a.Fill(table);
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

            if (table.Rows.Count > 0)
            {
                vehicle = GetVehicleFromDataRow(table.Rows[0]);
            }
            // If no vehicle has been found with the given number plate, set the returning vehicle null
            else
            {
                vehicle = null;
            }
            return status;
        }

        /// <summary>
        /// Try to get the vehicle type ID from a vehicle.
        /// </summary>
        /// <param name="vehicle">Vehicle from which the vehicle type ID is to be searched for</param>
        /// <param name="vehicleTypeID">Vehicle type ID from the vehicle. 'null', if the vehicle type isn't in the DB.</param>
        /// <returns>Returns true if the connection to the database worked. False if not.</returns>
        internal static bool TryGetVehicleTypeID(Vehicle vehicle, out int? vehicleTypeID)
        {
            DataTable table = new DataTable();
            vehicleTypeID = null;

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
                if (vehicle.ToString(VehicleFormat.VehicleType) == rowVehicle.ToString(VehicleFormat.VehicleType))
                {
					//Returns
                    vehicleTypeID = Convert.ToInt32(row["Ft_ID"].ToString());
                    return true;
                }
            }
            return true;
        }

        /// <summary>
        /// Try to get the brand ID from a brand-string.
        /// </summary>
        /// <param name="brand">Brand from which the brand ID is to be searched for</param>
        /// <param name="vehicleBrandID">brand ID from the brand. 'null', if the brand isn't in the DB.</param>
        /// <returns>Returns true if the connection to the database worked. False if not.</returns>
        internal static bool TryGetVehicleBrandID(string brand, out int? vehicleBrandID)
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
        /// Try to get the gear ID from a gear-string.
        /// </summary>
        /// <param name="gear">Gear from which the gear ID is to be searched for</param>
        /// <param name="gearID">Gear ID from the gear, 'null', if the gear isn't in the DB.</param>
        /// <returns>Returns true if the connection to the database worked. False if not.</returns>
        internal static bool TryGetVehicleGearID(string gear, out int? gearID)
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
        /// Try to get the fuel type ID from a gear-string.
        /// </summary>
        /// <param name="fuel">Fuel type from which the fuel type ID is to be searched for</param>
        /// <param name="fuelID">Fuel type ID from the fuel typ, 'null', if the fuel typ isn't in the DB.</param>
        /// <returns>Returns true if the connection to the database worked. False if not.</returns>
        internal static bool TryGetFuelTypeID(string fuel, out int? fuelID)
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
        /// Try to get a list with all number plates.
        /// </summary>
        /// <param name="numberPlates">List with all number plates</param>
        /// <returns>Returns true if the connection to the database worked. False if not.</returns>
        internal static bool TryGetVehicleNumberPlates(out List<string> numberPlates)
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
        /// Try to get a list with all brands.
        /// </summary>
        /// <param name="brand">List with all brands</param>
        /// <returns>Returns true if the connection to the database worked. False if not.</returns>
        internal static bool TryGetVehicleBrands(out List<string> brand)
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
        /// Try to get a list with all gears.
        /// </summary>
        /// <param name="gear">List with all gears</param>
        /// <returns>Returns true if the connection to the database worked. False if not.</returns>
        internal static bool TryGetVehicleGears(out List<string> gear)
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
        /// Try to get a list with all fuel types.
        /// </summary>
        /// <param name="fuel">List with all fuel types</param>
        /// <returns>Returns true if the connection to the database worked. False if not.</returns>
        internal static bool TryGetFuelTypes(out List<string> fuel)
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
        /// Try to add a vehicle to the database.
        /// </summary>
        /// <param name="vehicle">Vehicle to be added</param>
        /// <returns>Returns true if the connection to the database worked and the vehicle was added. False if not.</returns>
        internal static bool TryAddVehicle(Vehicle vehicle)
        {
            //Get the vehicle type ID
            if (!TryGetVehicleTypeID(vehicle, out int? vehicleTypeID))
                return false;

			//Checks if the vehicle type is in the database.
			if (vehicleTypeID == null)
            {
				//Adds the vehicle type to the database
				if (!TryAddVehicleType(vehicle))
                    return false;
                //Get the vehicle type ID
                if (!TryGetVehicleTypeID(vehicle, out vehicleTypeID))
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
        /// Try to check if a vehicle is used in open bookings.
        /// </summary>
        /// <param name="v">The vehicle, whose bookings require a check.</param>
        /// <param name="result">Is true, if the customer has open bookings in the DB. Is false, if he doesn't.</param>
        /// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
        internal static bool TryCheckOpenBookingVehicle(Vehicle v, out bool result)
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
                    // Get a list of all booking IDs matching the customer's email-address and checks,
                    // if the ending mileage equals NULL, indicating the booking is still open.
                    using (MySqlCommand command = new MySqlCommand("Select B_ID FROM buchung WHERE `Kennzeichen` = @kennzeichen AND Endkilometerstand IS NULL", con))
                    {
                        command.Parameters.AddWithValue("kennzeichen", v.NumberPlate);
						// Transfer the found booking IDs into a table via the MySqlDataAdapter...
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
        /// Try to delete a vehicle from the database.
        /// </summary>
        /// <param name="v">Vehicle to be deleted</param>
        /// <returns>Returns true if the connection to the database worked and the vehicle was deleted. False if not.</returns>
        internal static bool TryDeleteVehicle(Vehicle v)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM Fahrzeug WHERE `Kennzeichen` = @kennzeichen", con))
                    {
                        command.Parameters.AddWithValue("kennzeichen", v.NumberPlate);

						//Delete vehicle
                        command.ExecuteNonQuery();
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
                return true;
            }
        }

		/// <summary>
		/// Try to check if a vehicle type is needed
		/// </summary>
		/// <param name="vehicle">Vehicle to check</param>
		/// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
		internal static bool TryCheckVehicleTypeIsNeeded(Vehicle vehicle)
        {
			//Count how many vehicle types from vehicle parameter are used in the database
            if (!DBController.TryCountVehicleType(vehicle, out int count))
            {
                return false;
            }

			//If the vehicle type isn't used, delete it
            if (count == 0)
            {
                if (!DBController.TryDeleteVehicleType(vehicle))
                {
                    return false;
                }
            }
            return true;
        }

		/// <summary>
		/// Try to count how often the vehicletype is used in the database
		/// </summary>
		/// <param name="vehicle">Vehicle to check</param>
		/// <param name="count">How often it's used</param>
		/// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
		internal static bool TryCountVehicleType(Vehicle vehicle, out int count)
        {
            count = 0;
            DataTable table = new DataTable();

			//Get the vehicle tpye ID
            if (!TryGetVehicleTypeID(vehicle, out int? id))
            {
                return false;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT COUNT(*) AS Anzahl FROM Fahrzeug WHERE `Ft_ID` = @ft_ID", connection))
                    {
                        command.Parameters.AddWithValue("ft_ID", id);

                        using (MySqlDataAdapter a = new MySqlDataAdapter(command))
                        {
                            a.Fill(table);
                        }
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
            count = Convert.ToInt32(table.Rows[0][0].ToString());

            return true;
        }

		/// <summary>
		/// Try to delete the vehicle type
		/// </summary>
		/// <param name="vehicle">vehicle type to delete</param>
		/// <returns>Returns true if the connection to the database worked and the vehicle type was deleted. False if not.</returns>
		internal static bool TryDeleteVehicleType(Vehicle vehicle)
        {
			//Get the vehicle type ID
            if (!TryGetVehicleTypeID(vehicle, out int? id))
            {
                return false;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM Fahrzeugtyp WHERE `Ft_ID` = @Ft_ID", con))
                    {
                        command.Parameters.AddWithValue("Ft_ID", id);

						//Delete the vehicle type
                        command.ExecuteNonQuery();
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
                return true;
            }
        }

		/// <summary>
		/// Try tot get all vehicles
		/// </summary>
		/// <param name="vehicles">All vehicles</param>
		/// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
		internal static bool TryGetAllVehicles(out List<Vehicle> vehicles)
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

		/// <summary>
		/// Try to get all available vehicles
		/// </summary>
		/// <param name="vehicles">All available vehicles</param>
		/// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
		internal static bool TryGetAvailableVehicles(out List<Vehicle> vehicles)
        {
            DataTable table = new DataTable();
            vehicles = new List<Vehicle>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM `fahrzeug` JOIN `fahrzeugtyp` USING(`Ft_ID`) JOIN `fahrzeugmarke` USING(`Fm_ID`) JOIN `fahrzeuggetriebe` USING(`Fg_ID`) JOIN `kraftstoffart` USING(`Ks_ID`) WHERE Kennzeichen NOT IN (SELECT Kennzeichen FROM buchung WHERE Endkilometerstand IS NULL)", con))
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

		/// <summary>
		/// Convert a dataRow to vehicle
		/// </summary>
		/// <param name="row">Row to convert</param>
		/// <returns>Returns the vehicle from a dataRow, null if the convert fails</returns>
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
                v = null;
            }

            return v;
        }

        /// <summary>
        /// Try to add a vehicle type to the database.
        /// </summary>
        /// <param name="vehicle">Vehicle whose type is to be added</param>
        /// <returns>Returns true if the connection to the database worked and the vehicle type was added. False if not.</returns>
        private static bool TryAddVehicleType(Vehicle vehicle)
        {
            //Get the brand ID from the parameter vehicle
            if (!TryGetVehicleBrandID(vehicle.Brand, out int? brand))
                return false;

            //Get the gear ID from the parameter vehicle
            if (!TryGetVehicleGearID(vehicle.Gear, out int? gear))
                return false;

            //Get the fuel type ID from the parameter vehicle
            if (!TryGetFuelTypeID(vehicle.FuelType, out int? fuel))
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

		/// <summary>
		/// Try to update a vehicle
		/// </summary>
		/// <param name="vehicle">New vehicle</param>
		/// <param name="vehicleOld">Old vehicle</param>
		/// <returns>Returns true if the connection to the database worked and the vehicle was updated. False if not.</returns>
		internal static bool TryUpdateVehicleInDB(Vehicle vehicle, Vehicle vehicleOld)
        {
            //Get the vehicle type ID
            if (!TryGetVehicleTypeID(vehicle, out int? vehicleTypeID))
                return false;

            //Checks if the vehicle type is in the DB.
            if (vehicleTypeID == null)
            {
                //Adds the vehicle type to the DB
                if (!TryAddVehicleType(vehicle))
                    return false;
                //Get the vehicle type ID
                if (!TryGetVehicleTypeID(vehicle, out vehicleTypeID))
                    return false;
            }
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand("UPDATE `fahrzeug` SET `Kennzeichen`=@Kennzeichen,`Ft_ID`=@Ft_ID,`Kilometerstand`=@Kilometerstand,`Letzte Wartung`=@LetzteWartung,`Tankfuellung`=@Tankfüllung,`Standort`=@Standort,`Verfuegbarkeit`=@Verfügbarkeit,`Erstzulassung`=@Erstzulassung,`Kraftstoffverbrauch`=@Kraftstoffverbrauch,`Klimaanlage`=@Klimaanlage,`Tempomat`=@Tempomat,`Radio`=@Radio,`Bluetooth`=@Bluetooth,`USB`=@USB,`CD-Spieler`=@CDSpieler,`Navigationsgeraet`=@Navi,`ABS`=@ABS,`ESP`=@ESP,`Sitzheizung`=@Sitzheizung,`Winterreifen`=@Winter,`Raucher`=@Raucher WHERE `Kennzeichen`=@KennzeichenPre", con))
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
                        command.Parameters.Add(new MySqlParameter("KennzeichenPre", vehicleOld.NumberPlate));

                        command.ExecuteNonQuery();
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
                return true;
            }
        }
        #endregion

        #region Customer
        /// <summary>
        /// Try to add a customer to the database.
        /// </summary>
        /// <param name="c">The customer who should be added to the database.</param>
        /// <returns>Returns 0 if the operation was successful, 1 if a connection to the database could not be established or 2 if the email isn't unique.</returns>
        internal static int TryAddCustomer(Customer c)
        {
            int status = 0;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
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
					
					//Ask if the email is already in the database
                    if (((MySqlException)e).Number == 1062)
                    {
                        status = 2;
                    }
                }
                finally
                {
                    con.Close();
                }
                return status;
            }
        }

        /// <summary>
        /// Try to update a customer in the database.
        /// </summary>
        /// <param name="c">The object that contains the new information of the customer.</param>
        /// <param name="email">Email address from the customer, which should be updated.</param>
        /// <returns></returns>
        internal static int TryUpdateCustomer(Customer c, string email)
        {
            int status = 0;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
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

					//Ask if the email is already in the database
					if (((MySqlException)e).Number == 1062)
                    {
                        status = 2;
                    }
                }
                finally
                {
                    con.Close();
                }
                return status;
            }
        }

        /// <summary>
        /// Try to delete a customer from the DB.
        /// </summary>
        /// <param name="c">The customer, who is being deleted from the DB.</param>
        /// <returns>Returns a bool to determine the delete's success. True = successful delete, false = unsuccessful delete.</returns>
        internal static bool TryDeleteUser(Customer c)
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
        /// Try to check if a customer has open bookings.
        /// </summary>
        /// <param name="c">The customer, whose bookings require a check.</param>
        /// <param name="result">Is true, if the customer has open bookings in the DB. Is false, if he doesn't.</param>
        /// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
        internal static bool TryCheckOpenBookingsCustomer(Customer c, out bool result)
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
        /// Try to get a customer from the database by his email address.
        /// </summary>
        /// <param name="email">The email from the customer who is requested.</param>
        /// <param name="customer">The customer, who is requested. If the object is null,if there isn't a customer with this email.</param>
        /// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
        internal static bool TryGetCustomerByEmail(string email, out Customer customer)
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
        /// Try to get all customer from the database.
        /// </summary>
        /// <param name="customers">List of all customers.</param>
        /// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
        internal static bool TryGetAllCustomers(out List<Customer> customers)
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
				customers.Add(GetCustomerFromDataRow(item));
            }
            return true;
        }

		/// <summary>
		/// Convert the datarow to a customer
		/// </summary>
		/// <param name="row">Datarow to convert</param>
		/// <returns>Returns the customer from a datarow, null if the convert fails</returns>
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
        #endregion

        #region Booking
        /// <summary>
        /// Try to add a booking into the database.
        /// </summary>
        /// <param name="b">The booking, which should be added.</param>
        /// <returns>Returns true, if the insertion was successful, otherwise false.</returns>
        internal static bool TryAddBooking(Booking b)
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

		/// <summary>
		/// Try to close a given booking in the database.
		/// </summary>
		/// <param name="b">The booking, which is being closed.</param>
		/// <returns>Returns true, if the closing of a booking was successful, otherwise false.</returns>
		internal static bool TryCloseBooking(Booking b)
        {
            // The delete is successful at default
            bool result = true;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // The sql update command adds the booking's ending time in the "Buchung" table, aswell as the final mileage
                    using (MySqlCommand command = new MySqlCommand("UPDATE buchung SET Endzeitpunkt = @endzeitpunkt, Endkilometerstand = @endkilometerstand WHERE `E-Mail Adresse` = @email AND Kennzeichen = @kennzeichen  AND Endkilometerstand IS NULL", con))
                    {
                        command.Parameters.AddWithValue("endzeitpunkt", b.EndTime);
                        command.Parameters.AddWithValue("endkilometerstand", b.EndMileage);
                        command.Parameters.AddWithValue("email", b.Customer.EmailAddress);
                        command.Parameters.AddWithValue("kennzeichen", b.Vehicle.NumberPlate);
                        command.ExecuteNonQuery();
                    }

                    // The following sql command updates the vehicle in the database to match its state after the booking, to maintain the integrity of the DB.
                    using (MySqlCommand command = new MySqlCommand("UPDATE fahrzeug SET Kilometerstand = @kilometerstand, Tankfuellung = @tankfuellung WHERE Kennzeichen = @kennzeichen", con))
                    {
                        command.Parameters.AddWithValue("kilometerstand", b.Vehicle.Mileage);
                        command.Parameters.AddWithValue("tankfuellung", b.Vehicle.TankFilling);
                        command.Parameters.AddWithValue("kennzeichen", b.Vehicle.NumberPlate);
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
		/// Try to get all bookings of a customer
		/// </summary>
		/// <param name="c">The customer from which all the bookings are to be fetch.</param>
		/// <param name="bookings">List of all booking from a customer.</param>
		/// <returns>Returns false if there was a problem with the database connection, otherwise true.</returns>
		internal static bool TryGetAllBookingsOfCustomer(Customer c, out List<Booking> bookings)
        {
            bool status = true;
            bookings = new List<Booking>();
            DataTable table = new DataTable();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Get all Booking information matching the customer's email-address
                    using (MySqlCommand command = new MySqlCommand("Select * FROM buchung WHERE `E-Mail Adresse` = @email ORDER BY `Endzeitpunkt` ASC", con))
                    {
                        command.Parameters.AddWithValue("email", c.EmailAddress);
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
            foreach (DataRow row in table.Rows)
            {
                bookings.Add(GetBookingFromDataRow(row));
            }
            
            return status;
        }

		/// <summary>
		/// Convert the datarow to a booking
		/// </summary>
		/// <param name="row">Datarow to convert</param>
		/// <returns>Returns the customer from a datarow.</returns>
		private static Booking GetBookingFromDataRow(DataRow row)
        {
            // Getting the customer and vehicle first
            TryGetCustomerByEmail(row.Field<string>("E-Mail Adresse"), out Customer c);
            TryGetVehicleByNumberPlate(row.Field<string>("Kennzeichen"), out Vehicle v);
            bool open;

            // Checks, if the booking is still open. That is determined whether or not "Endkilometerstand" is null
            if (row.Field<double?>("Endkilometerstand") == null)
            {
                open = true;
            }
            else
            {
                open = false;
            }
		 
            DateTime startzeitpunkt = row.Field<DateTime>("Startzeitpunkt");
            DateTime endzeitpunkt;
            if (open)
                DateTime.TryParse(row.Field<string>("Endzeitpunkt"), out endzeitpunkt);
            else
                endzeitpunkt = row.Field<DateTime>("Endzeitpunkt");
            double startkilometerstand = row.Field<double>("Startkilometerstand");
            double? endkilometerstand = row.Field<double?>("Endkilometerstand");

            return new Booking(c, v, startzeitpunkt, endzeitpunkt, startkilometerstand, endkilometerstand, open);
        }
        #endregion
    }
}