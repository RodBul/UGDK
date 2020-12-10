using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugadaika
{


    public class Team
    {
        public string teamName { get; set; }
        public string teamAdress { get; set; }
        public int teamPoints { get; set; }
        public Team(string name, string adress, int points)
        {
            teamName = name;
            teamAdress = adress;
            teamPoints = points;
        }
    }
    public class TeamList
    {
        public static List<Team> teamList = new List<Team>(); //база команд
    }

    static class ApplicationData
    {
        public static readonly int maximumTeams = 12;
        public static int currentNumberTeams { get; set; }
        public static string currentComPort { get; set; }

        public static int currentRound = -1;
        public static string remoteAnswer = null;
    }

    static class Music
    {
        public static string[,] musPath = new string[8, 12];
        public static string[] categoryName = new string[12];
        public static string[] pointMusic = new string[12];
    }
}

