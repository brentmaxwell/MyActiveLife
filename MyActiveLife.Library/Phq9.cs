﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Library
{
    public class Phq9
    {
        public const string Intro = "Over the last 2 weeks, how often have you been bothered by the following problems?";
        public const string Q1 = "Little interest or pleasure in doing things";
        public const string Q2 = "Feeling down, depressed, or hopeless";
        public const string Q3 = "Trouble falling or staying asleep, or sleeping too much";
        public const string Q4 = "Feeling tired or having little energy";
        public const string Q5 = "Poor appetite or overeating";
        public const string Q6 = "Feeling bad about yourself - or that you’re a failure or have let yourself or your family down";
        public const string Q7 = "Trouble concentrating on things, such as reading the newspaper or watching television";
        public const string Q8 = "Moving or speaking so slowly that other people could have noticed. Or, the opposite - being so fidgety or so restless that you have been moving around a lot more than usual";
        public const string Q9 = "Thoughts that you would be better off dead or of hurting yourself in some way";

        public const string Response0 = "Not at all";
        public const string Response1 = "Several days";
        public const string Response2 = "More than half the days";
        public const string Response3 = "Nearly every day";
        public enum Response
        {
            [Description(Response0)]
            NotAtAll = 0,
            
            [Description(Response1)]
            SeveralDays = 1,
            
            [Description(Response2)]
            MoreThanHalfTheDays = 2,

            [Description(Response3)]
            NearlyEveryDay = 3
        }   
        
        public Response Answer1 { get; set; }
        public Response Answer2 { get; set; }
        public Response Answer3 { get; set; }
        public Response Answer4 { get; set; }
        public Response Answer5 { get; set; }
        public Response Answer6 { get; set; }
        public Response Answer7 { get; set; }
        public Response Answer8 { get; set; }
        public Response Answer9 { get; set; }

        public Phq9(Response answer1,
            Response answer2,
            Response answer3,
            Response answer4,
            Response answer5,
            Response answer6,
            Response answer7,
            Response answer8,
            Response answer9)
        {
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
            Answer5 = answer5;
            Answer6 = answer6;
            Answer7 = answer7;
            Answer8 = answer8;
            Answer9 = answer9;
        }

        // 0-4 - None
        // 5-9 - Mild
        // 10-14 - Moderate
        // 15-19 - Moderately severe
        // 20-27 - Severe
        public int Score
        {
            get
            {
                return ((int)Answer1) +
                    ((int)Answer2) +
                    ((int)Answer3) +
                    ((int)Answer4) +
                    ((int)Answer5) +
                    ((int)Answer6) +
                    ((int)Answer7) +
                    ((int)Answer8) +
                    ((int)Answer9);
            }
        }
    }
}
