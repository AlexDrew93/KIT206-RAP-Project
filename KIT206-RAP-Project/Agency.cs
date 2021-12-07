using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace KIT206_RAP_Project
{
    abstract class Agency
    {
        public static List<Employee> Generate()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { Name = "alex", Id = 1, Gender = Gender.M });
            employees.Add(new Employee { Name = "jane", Id = 2, Gender = Gender.F });
            employees.Add(new Employee { Name = "Celeste", Id = 3, Gender = Gender.X });
            employees.Add(new Employee { Name = "john", Id = 4, Gender = Gender.M });
            employees.Add(new Employee { Name = "Elizabeth", Id = 5, Gender = Gender.F });
            employees.Add(new Employee { Name = "Havoc", Id = 6, Gender = Gender.M });

            return employees;
        }

        static public List<Employee> LoadAll()
        {
            conn = GetConnection();
            List<Employee> TestList = new List<Employee>();
            MySqlDataReader rdr = null;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select id, given_name, family_name from researcher", conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    TestList.Add(new Employee { Name = rdr.GetString(1) + rdr.GetString(2), Id = rdr.GetInt32(0) });
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return TestList;
        }

        static public List<TrainingSession> LoadTrainingSessions(int Id)
        {
            conn = GetConnection();
            List<TrainingSession> TestPubList = new List<TrainingSession>();
            MySqlDataReader rdr = null;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select title, year, type, available " +
                 "from publication as pub, researcher_publication as respub " +
                 "where pub.doi = respub.doi and researcher_id=?id", conn);
                cmd.Parameters.AddWithValue("id", Id);                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    TestPubList.Add(new TrainingSession
                        { Title = rdr.GetString(0), Year = rdr.GetInt32(1), Certified = rdr.GetDateTime(3)});
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return TestPubList;
        }

        static public MySqlConnection conn { get; set; }

        static string db = "kit206";
        static string user = "kit206";
        static string pass = "kit206";
        static string server = "alacritas.cis.utas.edu.au";

        private static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                string connectionString = String.Format("Database={0};Data Source={1};User Id={2}; Password={3}", db, server, user, pass);
                conn = new MySqlConnection(connectionString);
            }
            return conn;
        }
        
    }
}
