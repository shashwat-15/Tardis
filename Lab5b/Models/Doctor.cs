/* 
	Name: Shashwat Kumar
	Student No.: 000790494
	I certify that this is my original work
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b.Models
{
    /// <summary>
    /// Creates a doctor class and adds all its attributes
    /// </summary>
    class Doctor
    {
        public int DoctorId { get; set; }
        public string Actor { get; set; }
        public int Series { get; set; }
        public int Age { get; set; }
        public string DebutEpisodeId { get; set; }
        public byte[] Picture { get; set; }

        /// <summary>
        /// string representation of doctor class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.DoctorId.ToString();
        }
    }
}
