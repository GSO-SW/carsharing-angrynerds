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
		/// Gibt, falls der Fahrzeugtyp vorhanden ist, die Fahrzeugtyp ID an.
		/// Sollte der Fahrzeugtyp nicht vorhanden sein, gibt er ein null-Wert an.
		/// </summary>
		public static int? GetVehicleTypeID(Vehicle vehicle)
		{
			DataTable table = new DataTable();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT ft.*, fm.Marke, fg.Getriebeart FROM Fahrzeugtyp ft JOIN Fahrzeugmarke fm USING (Fm_ID) JOIN Fahrzeuggetriebe fg USING (Fg_ID)", con))
					{
						//Holt sich die Fahrzeutyp Tabelle
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
			//Für jede Zeile
			foreach (DataRow row in table.Rows)
			{
				//Erstellt ein Fahrzeug mit den Fahrzeugtyp Werten
				Vehicle rowVehicle = new Vehicle(String.Empty, 0.0, new DateTime(0), 0.0, new PointD(0,0), false, row["Marke"].ToString(), row["Modell"].ToString(), Convert.ToInt32(row["Leistung"].ToString()), Convert.ToInt32(row["Baujahr"].ToString()), row["Getriebeart"].ToString(), Convert.ToDouble(row["Max_Tankvolumen"].ToString()), Convert.ToDouble(row["Grundpreis"].ToString()), Convert.ToDouble(row["Preis/km"].ToString()), Convert.ToDouble(row["Preis/min"].ToString()));
				
				//Vergleicht die Werte des Fahrzeuges aus der Tabelle und des Fahrzeuges von dem Parameter
				if (vehicle.GetVehicleTypeString() == rowVehicle.GetVehicleTypeString())
					//Falls er eins gefunden hat, gibt er dessen ID zurück
					return Convert.ToInt32(row["Ft_ID"].ToString());
			}
			return null;
		}

		/// <summary>
		/// Gibt, falls die Fahrzeugmarke vorhanden ist, die Fahrzeugmarke ID an.
		/// Sollte die Fahrzeugmarke nicht vorhanden sein, gibt er ein null-Wert an.
		/// </summary>
		public static int? GetVehicleBrandID(string brand)
		{
			DataTable table = new DataTable();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM Fahrzeugmarke", con))
					{
						//Holt sich die Fahrzeugmarke Tabelle
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
			//Für jede Zeile
			foreach (DataRow row in table.Rows)
			{
				//Schaut, ob der Parameter gleich der Zeile ist
				if (row["Marke"].ToString() == brand)
					//Gibt die Fahrzeugmarke zurück
					return Convert.ToInt32(row["Fm_ID"].ToString());
			}
			return null;
		}

		/// <summary>
		/// Gibt, falls der Getriebetyp vorhanden ist, die Getriebetyp ID an.
		/// Sollte der Getriebetyp nicht vorhanden sein, gibt er ein null-Wert an.
		/// </summary>
		public static int? GetVehicleGearID(string gear)
		{
			DataTable table = new DataTable();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM Fahrzeuggetriebe", con))
					{
						//Holt sich die Fahrzeuggetriebe Tabelle
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
			//Für jede Zeile
			foreach (DataRow row in table.Rows)
			{
				//Schaut, ob der Parameter gleich der Zeile ist
				if (row["Getriebeart"].ToString() == gear)
					//Gibt die Fahrzeuggetriebe ID zurück
					return Convert.ToInt32(row["Fg_ID"].ToString());
			}
			return null;
		}

		/// <summary>
		/// Gibt alle Fahrzeugmarken an.
		/// </summary>
		public static List<string> GetVehicleBrands()
		{
			DataTable table = new DataTable();
			List<string> brand = new List<string>();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT Marke FROM Fahrzeugmarke", con))
					{
						//Holt sich die Fahrzeugmarken Tabelle
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

			foreach (DataRow item in table.Rows)
			{
				brand.Add(item[0].ToString());
			}

			return brand;
		}

		/// <summary>
		/// Gibt alle Getriebearten an.
		/// </summary>
		public static List<string> GetVehicleGears()
		{
			DataTable table = new DataTable();
			List<string> gear = new List<string>();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT Getriebeart FROM Fahrzeuggetriebe", con))
					{
						//Holt sich die Fahrzeugmarken Tabelle
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

			foreach (DataRow item in table.Rows)
			{
				gear.Add(item[0].ToString());
			}

			return gear;
		}

		/// <summary>
		/// Fügt ein Fahrzeug der Fahrzeugtabelle hinzu. 
		/// Sollte der Fahrzeugtyp nicht in der Fahrzeugtyptabelle vorhanden sein, wird dieser automatisch mit hinzugefügt.
		/// </summary>
		public static void AddVehicle(Vehicle vehicle)
		{
			//Holt sich die Fahrzeugtyp ID
			int? vehicleTypeID = GetVehicleTypeID(vehicle);
			//Fragt, ob der Fahrzeugtyp bereits existiert
			if (vehicleTypeID == null)
			{
				//Falls nicht, fügt er den Fahrzeugtyp hinzu
				AddVehicleType(vehicle);
				//Holt sich erneut die Fahrzeugtyp ID
				vehicleTypeID = GetVehicleTypeID(vehicle);
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

		/// <summary>
		/// Fügt ein Fahrzeugtyp hinzu.
		/// </summary>
		private static void AddVehicleType(Vehicle vehicle)
		{
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					using (MySqlCommand command = new MySqlCommand(@"INSERT INTO Fahrzeugtyp VALUES(@Ft_ID, @Fm_ID, @Modell, @Leistung, @Baujahr, @Fg_ID, @Max_Tankvolumen, @Grundpreis, @PreisKm, @PreisMin)", connection))
					{
						command.Parameters.Add(new MySqlParameter("Ft_ID", null));
						command.Parameters.Add(new MySqlParameter("Fm_ID", GetVehicleBrandID(vehicle.Brand)));
						command.Parameters.Add(new MySqlParameter("Modell", vehicle.Model));
						command.Parameters.Add(new MySqlParameter("Leistung", vehicle.Power));
						command.Parameters.Add(new MySqlParameter("Baujahr", vehicle.ConstructionYear.Year));
						command.Parameters.Add(new MySqlParameter("Fg_ID", GetVehicleGearID(vehicle.Gear)));
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
