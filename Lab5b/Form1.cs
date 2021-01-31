/* 
	Name: Shashwat Kumar
	Student No.: 000790494
	I certify that this is my original work
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5b.DataLayer;
using Lab5b.Models;

namespace Lab5b
{
    public partial class Form1 : Form
    {
        Database db = new Database();//creates an instance of the database class
        Doctor d = new Doctor();//creates an instance of the doctor class
        public Form1()
        {
            InitializeComponent();
            
        }


        /// <summary>
        /// adds the doctor id into the doctor combobox
        /// </summary>
        private void DoctorIDDropdown()
        {
            foreach (Doctor doctor in db.Doctors)
            {
                doctorComboBox.Items.Add(doctor);
            }  
        }

        /// <summary>
        /// As the doctor id changes accordingly changes all the textbox values in the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDocDetails();
            FillEpisodeDetails();
            //FillCompanionDetails(d);
        }

        /// <summary>
        /// with the help of linq, retrieves the details of the doctor whose id is selected in the combobox
        /// </summary>
        private void FillDocDetails()
        {
           
            var doctors = from doctor in db.Doctors
                          where doctor.DoctorId == doctorComboBox.SelectedIndex+1
                        select doctor;


            foreach (Doctor doctor in doctors)
            {
                playedbyTextBox.Text = doctor.Actor;
                seriesTextBox.Text = doctor.Series.ToString();
                ageTextBox.Text = doctor.Age.ToString();
                MemoryStream stream = new MemoryStream(doctor.Picture);
                Image image = Image.FromStream(stream);
                doctorPictureBox.Image = image;
                FillCompanionDetails(doctor);
            }
        }

        /// <summary>
        /// with the help of linq, retrieves the details of the all the edpisodes related to that doctor whose id is selected in the combobox
        /// </summary>
        private void FillEpisodeDetails()
        {

            var doctorsEpisodes = from doctor in db.Doctors
                                  join episode in db.Episodes on doctor.DebutEpisodeId equals episode.StoryId
                                  where doctor.DoctorId == doctorComboBox.SelectedIndex + 1
                                  select episode;
                                  

            foreach(Episode epi in doctorsEpisodes)
            {
                yearTextBox.Text = epi.SeasonYear.ToString();
                episodeTextBox.Text = epi.Title;
            }
        }

        /// <summary>
        /// with the help of linq, retrieves the details of the all the companions related to that doctor whose id is selected in the combobox
        /// </summary>
        /// <param name="doctor"></param>
        private void FillCompanionDetails(Doctor doctor)
        {
            companionListBox.Items.Clear();
            var doctorsCompanions = from companion in db.Companions
                                    join episode in db.Episodes on companion.StoryId equals episode.StoryId
                                    where companion.DoctorId == doctor.DoctorId
                                    select new
                                    {
                                        Companion = companion,
                                        Episode = episode
                                    };

            foreach(var comp in doctorsCompanions)
            {
                string actorName = $"{comp.Companion.Name} ({comp.Companion.Actor}) ";
                string episode = $"\"{comp.Episode.Title}\" ({comp.Episode.SeasonYear})";
                companionListBox.Items.Add(actorName);
                companionListBox.Items.Add(episode);
                companionListBox.Items.Add("");
            }

        }

        /// <summary>
        /// calls the loadData function of the database class
        /// by defaults loads all the details of the doctor whose id is 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            db.LoadData();
            DoctorIDDropdown();
            FillDocDetails();
            FillEpisodeDetails();
            //FillCompanionDetails(d);
            doctorComboBox.SelectedIndex = 0;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
