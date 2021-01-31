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
    /// Creates an episode class and adds all its attributes
    /// </summary>
    class Episode
    {
        public string StoryId { get; set; }
        public string Title { get; set; }
        public int Season { get; set; }
        public int SeasonYear { get; set; }
    }
}
