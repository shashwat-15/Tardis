/* 
	Name: Shashwat Kumar
	Student No.: 000790494
	I certify that this is my original work
*/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5b.Models;

namespace Lab5b.DataLayer
{
    /// <summary>
    /// This class connects the doctors database from sql server
    /// </summary>
    class Database
    {
        public List<Doctor> Doctors { get; private set; }//creates a list of doctor class

        public List<Companion> Companions { get; private set; }//creates a list of companion class
        public List<Episode> Episodes { get; private set; }//creates a list of episode class
        


        /// <summary>
        /// loads the data into the doctors, companions and episodes list
        /// </summary>
        public void LoadData()
        {
            this.Doctors = GetDoctors();
            this.Companions = GetCompanions();
            this.Episodes = GetEpisodes();
            //TODO: Load other Lists
        }

        /// <summary>
        /// retrieves doctor details from the database and accordingly changes the form
        /// adds the doctor into the doctors list
        /// </summary>
        /// <returns></returns>
        private List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (SqlDataReader reader = ExecuteReader("SELECT * FROM [DOCTOR]"))
            {
                while (reader.Read())
                {
                    Doctor doctor = new Doctor();
                    doctor.DoctorId = (int)reader["DOCTORID"];
                    doctor.Actor = reader["ACTOR"] as string;
                    doctor.Series = (int)reader["SERIES"];
                    doctor.Age = (int)reader["AGE"];
                    doctor.DebutEpisodeId = reader["DEBUT"] as string;
                    doctor.Picture = reader["PICTURE"] as byte[];
                    //TODO:
                    //Map additional Doctor properties to table columns

                    doctors.Add(doctor);
                }
            }

            return doctors;
        }

        /// <summary>
        /// retrieves companion details from the database and accordingly changes the form
        /// adds the companion into the companions list
        /// </summary>
        /// <returns></returns>
        private List<Companion> GetCompanions()
        {
            List<Companion> companions = new List<Companion>();

            using (SqlDataReader reader = ExecuteReader("SELECT * FROM [COMPANION]"))
            {
                while (reader.Read())
                {
                    Companion companion = new Companion();
                    companion.Name = reader["NAME"] as string;
                    companion.Actor = reader["ACTOR"] as string;
                    companion.DoctorId = (int)reader["DOCTORID"];
                    companion.StoryId = reader["STORYID"]as string;
                   

                    companions.Add(companion);
                }
            }

            return companions;
        }

        /// <summary>
        /// retrieves episode details from the database and accordingly changes the form
        /// adds the episode into the episodes list
        /// </summary>
        /// <returns></returns>
        private List<Episode> GetEpisodes()
        {
            List<Episode> episodes = new List<Episode>();

            using (SqlDataReader reader = ExecuteReader("SELECT * FROM [EPISODE]"))
            {
                while (reader.Read())
                {
                    Episode episode = new Episode();
                    episode.StoryId = reader["STORYID"] as string;
                    episode.Season = (int)reader["SEASON"];
                    episode.SeasonYear = (int)reader["SEASONYEAR"];
                    episode.Title = reader["TITLE"]as string;
                    //TODO:
                    //Map additional Doctor properties to table columns

                    episodes.Add(episode);
                }
            }

            return episodes;
        }

        /// <summary>
        /// creates an sql connection with the database 
        /// </summary>
        /// <param name="sql">sql query</param>
        /// <returns>sqldatareader</returns>
        private SqlDataReader ExecuteReader(string sql)
        {
            string connectionString = "Data Source=LAPTOP-NT1BHILS\\SQLEXPRESS;Initial Catalog=COMP10204_LAB5;Integrated Security=True;";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            return reader;
            
        }

    }
}
