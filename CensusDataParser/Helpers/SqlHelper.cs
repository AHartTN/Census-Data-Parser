namespace CensusDataParser.Helpers
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.IO;

	public class SqlHelper
	{
		public static int BulkCSVInsert(string tableName, string filePath)
		{
			//string fileString = File.ReadAllText(filePath);
			int rowsAffected = 0;
			string sql = $"BULK INSERT {tableName} FROM '{filePath}' WITH (FIELDTERMINATOR = ',', ROWTERMINATOR = '\n')";

			using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
			{
				
				using (SqlCommand cmd = conn.CreateCommand())
				{
					Console.Write("Bulk inserting CSV records. . . Please wait!");
					cmd.CommandText = sql;
					cmd.CommandType = CommandType.Text;
					cmd.CommandTimeout = 600;

					if (cmd.Connection.State != ConnectionState.Open)
						cmd.Connection.Open();

					rowsAffected = cmd.ExecuteNonQuery();

					cmd.Connection.Close();

				}
			}
			Console.WriteLine($"\r{rowsAffected} CSV records inserted into the {tableName} table from {filePath}");

			return rowsAffected;
		}
	}
}
