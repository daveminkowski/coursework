using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;

namespace Final_Project.Dal
{
    public class TeacherAdapter
    {
        private string _connectionString = @"Data Source=C:\Sqlite\School.db; datetimeformat=CurrentCulture;";

        public bool InsertTeacher(Teacher teacher)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Teacher (FirstName, LastName) VALUES ('" +
                teacher.FirstName + "', '" + teacher.LastName + "'); ";
                connection.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateTeacher(Teacher teacher)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE Teacher SET FirstName = '" + teacher.FirstName +
                "', LastName = '" + teacher.LastName + "' WHERE TeacherId = " + teacher.TeacherId;
                connection.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeleteTeacher(int teacherId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Teacher WHERE TeacherId = " + teacherId;
                connection.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List <Teacher> GetAll()
        {
            // Declare the return type
            List <Teacher> returnValue = new List <Teacher>();
            // Create a connection to SQL lite. Wrap in a using statement for safety
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                // Create the command
                SQLiteCommand command = connection.CreateCommand();
                // Pass the CommandText to the command
                command.CommandText = "SELECT TeacherId, FirstName, LastName FROM Teacher";
                // Open the database connection
                connection.Open();
                // Execute a command and return back a reader
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Call a method to retrieve the results
                    Teacher teacher = GetFromReader(reader);
                    // add the instance to the return list
                    returnValue.Add(teacher);
                }
                // return back the results
                return returnValue;
            }
        }

        public Teacher GetById (int TeacherId)
        {
            Teacher returnValue = null;
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                // Create the command
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT TeacherId, FirstName, LastName FROM Teacher WHERE TeacherId = " + TeacherId.ToString();
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    returnValue = GetFromReader(reader);
                }
                return returnValue;
            }
        }

        private Teacher GetFromReader(DbDataReader reader)
        {
            // Create a new instance of the student class
            Teacher teacher = new Teacher();
            // Copy the data that you retrieve from the database into the class
            teacher.TeacherId = reader.GetInt32(reader.GetOrdinal("TeacherId"));
            teacher.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
            teacher.LastName = reader.GetString(reader.GetOrdinal("LastName"));
            return teacher;
        }
    }
}
