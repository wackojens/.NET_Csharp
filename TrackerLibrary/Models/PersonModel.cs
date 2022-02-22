using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the first name of this player
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Represents the last name of this player
        /// </summary>
        public string LastName { get; set; } = "";

        /// <summary>
        /// Represents the email adress of this player
        /// </summary>
        public string EmailAdress { get; set; } = "";

        /// <summary>
        /// Represents the phone number of this player
        /// </summary>
        public string CellphoneNumber { get; set; } = "";
    }
}
