﻿using System;
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
		/// Gibt, falls der Fahrzeugtyp vorhanden ist, die Fahrzeugtyp ID zurück.
		/// Sollte der Fahrzeugtyp nicht vorhanden sein, gibt er ein null-Wert zurück.
		/// </summary>
		public static int? GetVehicleTypeID(Vehicle vehicle)
		{
			DataTable table = new DataTable();

			using (MySqlConnection con = new MySqlConnection(connectionString))
			{
				try
				{
					con.Open();

					using (MySqlDataAdapter a = new MySqlDataAdapter("SELECT * FROM Fahrzeugtyp", con))
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
				Vehicle rowVehicle = new Vehicle(String.Empty, 0.0, new DateTime(0), 0.0, new Point(0,0), false, row["Marke"].ToString(), row["Modell"].ToString(), Convert.ToInt32(row["Leistung"].ToString()), Convert.ToInt32(row["Baujahr"].ToString()), row["Schaltung"].ToString(), Convert.ToDouble(row["Max_Tankvolumen"].ToString()), Convert.ToDouble(row["Grundpreis"].ToString()), Convert.ToDouble(row["Preis/km"].ToString()), Convert.ToDouble(row["Preis/min"].ToString()));
				
				//Vergleicht die Werte des Fahrzeuges aus der Tabelle und des Fahrzeuges von dem Parameter
				if (vehicle.GetVehicleTypeString() == rowVehicle.GetVehicleTypeString())
					//Falls er eins gefunden hat, gibt er dessen ID zurück
					return Convert.ToInt32(row["Ft_ID"].ToString());
			}
			return null;
		}

		/// <summary>
		/// Fügt ein Fahrzeug der Fahrzeugtabelle hinzu. 
		/// Sollte der Fahrzeugtyp nicht in der Fahrzeugtabelle vorhanden sein, wird dieser automatisch mit hinzugefügt.
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
