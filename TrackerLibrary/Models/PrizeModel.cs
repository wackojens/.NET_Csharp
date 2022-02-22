using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the price
        /// </summary>
        public int Id { get; set; }

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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
