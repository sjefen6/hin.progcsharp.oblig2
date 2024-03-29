﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CityDefender
{
    class Score : IComparable<Score>
    {
        private String Name { get; set; }
        public int Points { get; set; }

        public Score(String n, int s)
        {
            this.Name = n;
            this.Points = s;
        }

        /*
         * Skriver ut denne scoren
         */
        public override String ToString()
        {
            return  Name + ": " + Points;
        }

        public int CompareTo(Score other)
        {
            if (this.Points > other.Points)
                return -1;
            else if (this.Points < other.Points)
                return 1;
            else
                return 0;
        }
    }
}
