using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;

namespace Final_Project.Dal
{
    public class ExamAdapter
    {
        private string _connectionString = @"Data Source=C:\Sqlite\School.db; datetimeformat=CurrentCulture;";

        public List <Exam> GetAll()
        {
            // Declare the return type
            List <Exam> returnValue = new List <Exam>();
            // Create a connection to SQL lite. Wrap in a using statement for safety
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                // Create the commamd
                SQLiteCommand command = connection.CreateCommand();
                // Pass the CommandText to the command
                command.CommandText = "SELECT ExamId, StudentId, Score FROM Exam";
                // Open the database connection
                connection.Open();
                // Execute a command and return back a reader
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Call a method to retrieve the results
                    Exam exam = GetFromReader(reader);
                    // add the instance to the return list
                    returnValue.Add(exam);
                }
                // return back the results
                return returnValue;
            }
        }

        public List <Exam> GetByStudentId(int studentId)
        {
            List <Exam> returnValue = new List <Exam>();
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                // Create the command
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT ExamId, StudentId, Score FROM Exam WHERE StudentId = " + studentId.ToString();
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Exam exam = GetFromReader(reader);
                    returnValue.Add(exam);
                }

                return returnValue;
            }
        }

        public Exam GetById(int examId)
        {
            Exam returnValue = null;
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                // Create the command
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT ExamId, StudentId, Score FROM Exam WHERE ExamId = " + examId.ToString();
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    returnValue = GetFromReader(reader);
                }

                return returnValue;
            }
        }

        public bool InsertExam(Exam exam)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = connection.CreateCommand();

                command.CommandText = "INSERT INTO Exam (StudentId, Score) VALUES ('" + exam.StudentId + "', '" + exam.Score + "'); ";
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

        public bool UpdateExam(Exam exam)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = connection.CreateCommand();


                command.CommandText = "UPDATE Exam SET Score = '" + exam.Score + "' WHERE ExamId = " + exam.ExamId;
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

        public bool DeleteExam(int examId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Exam WHERE ExamId = " + examId;
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

        private Exam GetFromReader(DbDataReader reader)
        {
            // Create a new instance of the customer class
            Exam exam = new Exam();
            // Copy the data that you retrieve from the database into the class
            exam.StudentId = reader.GetInt32(reader.GetOrdinal("StudentId"));
            exam.ExamId = reader.GetInt32(reader.GetOrdinal("ExamId"));
            exam.Score = reader.GetInt32(reader.GetOrdinal("Score"));
            return exam;
        }

    }
}
