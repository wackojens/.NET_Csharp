using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAcces;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if (db == DatabaseType.TextFile)
            {
                // TODO - create text connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}


// les van 08/03/2022 in school vergeten naar git te pushen. toen tot 16:59 geraakt.
// nu snel terug op dat punt geraken. Indien errors wss ergens iets gemist tussen 16:12 en 16:45(na 16:45 terug rustig gekeken)

// 16:12:13

// laatste aanpassing in video gebeurt 16:05:16(SaveMatchupToFile)

// MatchupEntrymodel (ParentMatchup en TeamCompeting nullable gemaakt. Niet in video!)
// MatchupModel winner nullable gemaakt. Niet in video!