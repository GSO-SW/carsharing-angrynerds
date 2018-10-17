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
	}
}
