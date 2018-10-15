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

		public static void ConnectToDb()
		{
			DataTable t = new DataTable();

			// create SqlConnection object
			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					// open connection to database
					con.Open();
					// INTERACTION WITH DATABASE COMES HERE

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM kunde", con))
					{
						a.Fill(t);
					}

				}
				catch (Exception e)
				{
					throw e;
				}
				finally
				{
					// close connection to database
					con.Close();
				}
			}
		}

		public static DataTable GetVehicleType()
		{
			DataTable table = new DataTable();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM Fahrzeugtyp", con))
					{
						a.Fill(table);
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

			return table;
		}

		public static int? GetVehicleTypeID(Vehicle vehicle)
		{
			DataTable table = GetVehicleType();


			for (int i = 0; i < table.Rows.Count; i++)
			{
				DataRow row = table.Rows[i];
				Vehicle rowVehicle = new Vehicle(String.Empty, 0.0, new DateTime(0), 0.0, String.Empty, false, row["Marke"].ToString(), row["Modell"].ToString(), Convert.ToInt32(row["Leistung"].ToString()), new DateTime(Convert.ToInt32(row["Baujahr"].ToString()), 1, 1), row["Schaltung"].ToString(), Convert.ToDouble(row["Max_Tankvolumen"].ToString()), Convert.ToDouble(row["Grundpreis"].ToString()), Convert.ToDouble(row["Preis/km"].ToString()), Convert.ToDouble(row["Preis/min"].ToString()));

				if (vehicle.GetVehicleTypeString() == rowVehicle.GetVehicleTypeString())
				{
					return Convert.ToInt32(row["Ft_ID"].ToString());
				}

			}
			return null;
		}

		public static void AddVehicle(Vehicle vehicle)
		{
			int? vehicleTypeID = GetVehicleTypeID(vehicle);
			if (vehicleTypeID == null)
			{
				AddVehicleType(vehicle);
				vehicleTypeID = GetVehicleTypeID(vehicle);
			}
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					using (MySqlCommand command = new MySqlCommand("INSERT INTO Fahrzeug VALUES(@F_ID, @Ft_ID, @Kennzeichen, @Kilometerstand, @LetzteWartung, @Tankfüllung, @Standort, @Verfügbarkeit)", connection))
					{
						command.Parameters.Add(new MySqlParameter("F_ID", null));
						command.Parameters.Add(new MySqlParameter("Ft_ID", vehicleTypeID));
						command.Parameters.Add(new MySqlParameter("Kennzeichen", vehicle.NumberPlate));
						command.Parameters.Add(new MySqlParameter("Kilometerstand", vehicle.Mileage));
						command.Parameters.Add(new MySqlParameter("LetzteWartung", vehicle.LastMaintenance.Date));
						command.Parameters.Add(new MySqlParameter("Tankfüllung", vehicle.TankFilling));
						command.Parameters.Add(new MySqlParameter("Standort", vehicle.Position));
						command.Parameters.Add(new MySqlParameter("Verfügbarkeit", vehicle.Available));
						command.ExecuteNonQuery();
					}

				}
				catch (Exception e)
				{
					throw e;
				}
				finally
				{
					connection.Close();
				}
			}
		}

		public static void AddVehicleType(Vehicle vehicle)
		{
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					using (MySqlCommand command = new MySqlCommand(@"INSERT INTO Fahrzeugtyp VALUES(@Ft_ID, @Marke, @Modell, @Leistung, @Baujahr, @Schaltung, @Max_Tankvolumen, @Grundpreis, @PreisKm, @PreisMin)", connection))
					{
						command.Parameters.Add(new MySqlParameter("Ft_ID", null));
						command.Parameters.Add(new MySqlParameter("Marke", vehicle.Brand));
						command.Parameters.Add(new MySqlParameter("Modell", vehicle.Model));
						command.Parameters.Add(new MySqlParameter("Leistung", vehicle.Power));
						command.Parameters.Add(new MySqlParameter("Baujahr", vehicle.ConstructionYear.Year));
						command.Parameters.Add(new MySqlParameter("Schaltung", vehicle.GearShift));
						command.Parameters.Add(new MySqlParameter("Max_Tankvolumen", vehicle.MaxTankFilling));
						command.Parameters.Add(new MySqlParameter("Grundpreis", vehicle.BasicPrice));
						command.Parameters.Add(new MySqlParameter("PreisKm", vehicle.PricePerKilometre));
						command.Parameters.Add(new MySqlParameter("PreisMin", vehicle.PricePerMinute));

						command.ExecuteNonQuery();
					}

				}
				catch (Exception e)
				{
					throw e;
				}
				finally
				{
					connection.Close();
				}
			}
		}

		
	}
}
