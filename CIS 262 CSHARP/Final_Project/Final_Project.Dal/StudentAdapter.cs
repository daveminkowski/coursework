using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;

namespace Final_Project.Dal
{
    public class StudentAdapter
    {
        private string _connectionString = @"Data Source=C:\Sqlite\School.db; datetimeformat=CurrentCulture;";

        public bool InsertStudent(Student student)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Student (FirstName, LastName) VALUES ('" +
                student.FirstName + "', '" + student.LastName + "'); ";
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

        public bool UpdateStudent(Student student)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE Student SET FirstName = '" + student.FirstName +
                "', LastName = '" + student.LastName + "' WHERE StudentId = " + student.StudentId;
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

        public bool DeleteStudent(int studentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Student WHERE StudentId = " + studentId;
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

        public List <Student> GetAll()
        {
            // Declare the return type
            List <Student> returnValue = new List <Student>();
            // Create a connection to SQL lite. Wrap in a using statement for safety
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                // Create the command
                SQLiteCommand command = connection.CreateCommand();
                // Pass the CommandText to the command
                command.CommandText = "SELECT StudentId, FirstName, LastName FROM Student";
                // Open the database connection
                connection.Open();
                // Execute a command and return back a reader
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Call a method to retrieve the results
                    Student student = GetFromReader(reader);
                    // add the instance to the return list
                    returnValue.Add(student);
                }
                // return back the results
                return returnValue;
            }
        }

        public Student GetById(int StudentId)
        {
            Student returnValue = null;
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                // Create the command
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT StudentId, FirstName, LastName FROM Student WHERE StudentId = " + StudentId.ToString();
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    returnValue = GetFromReader(reader);
                }

                return returnValue;
            }
        }

        private Student GetFromReader(DbDataReader reader)
        {
            // Create a new instance of the student class
            Student student = new Student();
            // Copy the data that you retrieve from the database into the class
            student.StudentId = reader.GetInt32(reader.GetOrdinal("StudentId"));
            student.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
            student.LastName = reader.GetString(reader.GetOrdinal("LastName"));
            return student;
        }
    }
}
