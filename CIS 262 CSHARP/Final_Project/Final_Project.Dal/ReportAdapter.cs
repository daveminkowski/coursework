using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;

namespace Final_Project.Dal
{
    public class ReportAdapter
    {
        private string _connectionString = @"Data Source=C:\Sqlite\School.db; datetimeformat=CurrentCulture;";

        public List <Report> GetReportRows()
        {
            // Declare the return type
            List<Report> returnValue = new List<Report>();
            // Create a connection to SQL lite. Wrap in a using statement for safety
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                // Create the commamd
                SQLiteCommand command = connection.CreateCommand();

                // Create the SQL Statement
                string sql = "SELECT Student.FirstName, Student.LastName, Exam.StudentId, Exam.Score as 'Score' FROM Exam "
                    + " INNER JOIN Student ON Exam.StudentId = Student.StudentId "
                    + "ORDER BY Exam.Score DESC";
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
            // Create a new instance of the student class
            Report report = new Report();
            // Copy the data that you retrieve from the database into the class
            report.StudentId = reader.GetInt32(reader.GetOrdinal("StudentId"));
            report.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
            report.LastName = reader.GetString(reader.GetOrdinal("LastName"));
            report.Score = reader.GetInt32(reader.GetOrdinal("Score"));

            string grade;
            if (report.Score >= 90)
                grade = "A";
            else if (report.Score >= 80 && report.Score < 90)
                grade = "B";
            else if (report.Score >= 70 && report.Score < 80)
                grade = "C";
            else if (report.Score >= 60 && report.Score < 70)
                grade = "D";
            else
                grade = "F";

            report.LetterGrade = grade;
            return report;
        }
    }
}
