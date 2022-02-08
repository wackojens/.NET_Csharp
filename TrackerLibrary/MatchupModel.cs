using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents a list of both teams in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner of this matchup.
        /// </summary>
        public TeamModel winner { get; set; }

        /// <summary>
        /// Represents the round that this match takes place in.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
