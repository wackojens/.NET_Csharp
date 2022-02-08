using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the numeric postion of the place where a prize should be given
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of this place
        /// </summary>
        public string PlaceName { get; set; } = "";

        /// <summary>
        /// Represents the prize amount rewarded for this place
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the price percentage to be given to this place
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
