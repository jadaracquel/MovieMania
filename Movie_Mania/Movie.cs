using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMania.Movie_Mania
{
    class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Writer { get; set; }
        public string Rating { get; set; }

        //Connect the name of the connection string in App.config file
        //static string connStr = DBUtils.GetConnStr("DBConnStr");
        public bool RowsAffected(SqlCommand cmd)
        {
            bool isAffected = false;
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                isAffected = true;
            }
            else
            {
                isAffected = false;
            }
            return isAffected;
        }
        //Select data from DB
        public DataTable Select()
        {
            DataTable DT = new DataTable();
            //Step 1: Create SQL connection
            using (SqlConnection conn = DBUtils.GetSqlConnection("DBConnStr")) //OR using(SqlConnection conn = new SqlConnection(connStr));see line 24
            {
                //Step 2: Write SQL query command
                string sql = "SELECT * FROM Movies";
                //Step 3: Create SQL Command object and pass the sql query command and sqlconnection as parameters
                SqlCommand cmdA = new SqlCommand(sql, conn);
                //Step 4: Create SQL DataAdapter passing the sqlcommand object as a parameter
                SqlDataAdapter adapter = new SqlDataAdapter(cmdA);
                //Step 5: Open the sqlconnection
                conn.Open();
                //Step 6: Fill datatable using sqlDataAdapter
                adapter.Fill(DT);
            }
            //return the datatable
            return DT;
        }

        public bool Add(Movie M)
        {
            bool isAdded = false;
            //Step 1: Create SQL Connection
            using (SqlConnection conn = DBUtils.GetSqlConnection("DBConnStr"))
            {
                //Step 2: Write SQL query command w/ parameters (ALWAYS add parameters when writing an "INSERT INTO" command)
                //Parameters= basically variables that begin with @
                string sql = "INSERT INTO Movies (Title, ReleaseYear, Genre, Director, Producer, Writer, Rating) " +
                    "VALUES (@Title, @ReleaseYear, @Genre, @Director, @Producer, @Writer, @Rating)";
                //Step 3: Create SQL Command object and pass the sql query command and sqlconnection as parameters
                SqlCommand cmdB = new SqlCommand(sql, conn);
                //Step 4:Define parameters to add data using sqlcommand object (makes database safe from sql injections)
                cmdB.Parameters.AddWithValue("@Title", M.Title);
                cmdB.Parameters.AddWithValue("@ReleaseYear", M.ReleaseYear);
                cmdB.Parameters.AddWithValue("@Genre", M.Genre);    //OR cmdB.Parameters.Add(new SqlParameter("@Genre", M.Genre));
                cmdB.Parameters.AddWithValue("@Director", M.Director);
                cmdB.Parameters.AddWithValue("@Producer", M.Producer);
                cmdB.Parameters.AddWithValue("@Writer", M.Writer);  //OR cmdB.Parameters.Add(new SqlParameter("@Writer", M.Writer));
                cmdB.Parameters.AddWithValue("@Rating", M.Rating);
                //Step 5: Open connection
                conn.Open();
                //Step 6: Return the # of rows affected
                isAdded = RowsAffected(cmdB);
            }
            return isAdded;
        }

        public bool Update(Movie M)
        {
            bool isUpdated = false;
            //Step 1: Establish SQL Connection
            using (SqlConnection conn = DBUtils.GetSqlConnection("DBConnStr"))
            {
                //Step 2: Write SQL query command w/ parameters (ALWAYS add parameters when writing an "UPDATE" command)
                //Parameters= basically variables that begin with @
                string sql = "UPDATE Movies SET Title = @Title, ReleaseYear = @ReleaseYear, Genre = @Genre, " +
                    "Director = @Director, Producer = @Producer, Writer = @Writer, Rating = @Rating";
                //Step 3: Create SqlCommand object and pass the sql query command and SqlConnection object as parameters
                SqlCommand cmdC = new SqlCommand(sql, conn);
                //Step 4: Use SqlCommand object to define parameters in the sql query string
                cmdC.Parameters.AddWithValue("@Title", M.Title);
                cmdC.Parameters.AddWithValue("@ReleaseYear", M.ReleaseYear);
                cmdC.Parameters.AddWithValue("@Genre", M.Genre);
                cmdC.Parameters.AddWithValue("@Director", M.Director);
                cmdC.Parameters.AddWithValue("@Producer", M.Producer);
                cmdC.Parameters.AddWithValue("@Writer", M.Writer);
                cmdC.Parameters.AddWithValue("@Rating", M.Rating);
                //Step 5: Open the connection
                conn.Open();
                isUpdated = RowsAffected(cmdC);
            }
            return isUpdated;
        }

        public bool Delete(Movie M)
        {
            bool isDeleted = false;
            //Step 1: Establish SQL Connection
            using (SqlConnection conn = DBUtils.GetSqlConnection("DBConnStr"))
            {
                //Step 2: Write SQL query command
                string sql = "DELETE FROM Movies WHERE MovieID = @MovieID";
                //Step 3: Create SqlCommand object
                SqlCommand cmdD = new SqlCommand(sql, conn);
                //Step 4: Use SqlCommand object to define parameters
                cmdD.Parameters.AddWithValue("@MovieID", M.MovieID);
                //Step 5: Open connection
                conn.Open();
                isDeleted = RowsAffected(cmdD);
            }
            return isDeleted;
        }

        public DataTable Search(string keyword)
        {
            DataTable DT = new DataTable();
            //Step 1: Establish SQL Connection
            using (SqlConnection conn = DBUtils.GetSqlConnection("DBConnStr"))
            {
                //Step 2: Write sql query command
                string sql = "SELECT * FROM Movies WHERE Title LIKE '%" + keyword + "%' OR ReleaseYear LIKE '%" + keyword +
                    "%' OR Genre LIKE '%" + keyword + "%' OR Director LIKE '%" + keyword + "%' OR Producer LIKE '%" + keyword +
                    "%' OR Writer LIKE '%" + keyword + "%' OR Rating LIKE '%" + keyword + "%'";
                //conn.Open();
                using (SqlDataAdapter SDA = new SqlDataAdapter(sql, conn))
                {
                    SDA.SelectCommand = new SqlCommand(sql, conn);
                    conn.Open();
                    SDA.Fill(DT);
                }
            }
            return DT;
        }
    }
}
