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
				catch(Exception e)
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
	}
}
