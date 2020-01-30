using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SQLite;

namespace Lesson8.Dal
{
    public class ReportAdapter
    {
        private string _connectionString = @"Data Source = C:\Sqlite\Chinook_Sqlite_AutoIncrementPKs.sqlite; datetimeformat=CurrentCulture;";

        public List<Report> GetReportRows()
        {
            // Declare the return type
            List<Report> returnValue = new List<Report>();
            // Create a connection to SQL lite. Wrap in a using statement for safety
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                // Create the commamd
                SQLiteCommand command = connection.CreateCommand();
                // Create the SQL Statement
                string sql = "SELECT Customer.Country, SUM(Invoice.Total) as 'Total' " +
                "FROM Invoice " +
                "INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId " +
                "GROUP BY Customer.Country " +
                "ORDER BY SUM(Invoice.Total) DESC";
                // Pass the CommandText to the command
                command.CommandText = sql;
                // Open the database connection
                connection.Open();
                // Execute a command and return back a reader
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Call a method to retrieve the results
                    Report report = GetFromReader(reader);
                    // add the instance to the return list
                    returnValue.Add(report);
                }
                // return back the results
                return returnValue;

            }
        }

        private Report GetFromReader(DbDataReader reader)
        {
            // Create a new instance of the customer class
            Report report = new Report();
            // Copy the data that retrieved from the database into the class
            report.Country = reader.GetString(reader.GetOrdinal("Country"));
            report.Total = reader.GetDecimal(reader.GetOrdinal("Total"));
            return report;
        }
    }
}
