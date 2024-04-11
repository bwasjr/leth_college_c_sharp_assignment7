using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Assignment6
{
    internal class HockeyPlayer : IComparable<HockeyPlayer>
    {
        private String playerName;
        //private int jerseyNumber;
        private int goalsScored;
        private static String sortCriteria = "Alphabetically";
        private static bool inverse = false;


        public String Name { get { return playerName; } set { playerName = value; } }
        public int JerseyNumber { get; set; }

        public int GoalsScored { get { return goalsScored; } set { goalsScored = value; } }

        public String  SortCriteria {get { return sortCriteria; } set { sortCriteria = value; } }

        public bool Inverse { get { return inverse; } set { inverse = value; } }

        public HockeyPlayer(String name, int jerNumb, int score = 0) 
        {
            playerName = name;
            JerseyNumber = jerNumb;
            goalsScored = score;
        }

        override
        public String ToString()
        {
            String outPutFormat = "{0, -20}|{1, 13}|{2, 12}";
            return String.Format(outPutFormat, Name, JerseyNumber, GoalsScored);
        }

        public int CompareTo(HockeyPlayer? other) 
        {
            if(other == null) return 1;

            int multiplier = 1;
            
            if(Inverse)
                multiplier = -1;

            switch (SortCriteria)
            {
                case "Alphabetically":
                    return Name.CompareTo(other.Name) * multiplier;
                case "Jersey Number":
                    return JerseyNumber.CompareTo(other.JerseyNumber) * multiplier;
                case "Goals Scored":
                    return GoalsScored.CompareTo(other.GoalsScored) * multiplier;
                default:
                    return Name.CompareTo(other.Name) * multiplier;
            }            
        }

    }
}
