using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyActiveLife.Web.Models
{
    public class Phq9
    {
        public static string Intro = Library.Phq9.Intro;

        [DisplayName(Library.Phq9.Q1)]
        public int Answer1 { get; set; }

        [DisplayName(Library.Phq9.Q2)]
        public int Answer2 { get; set; }

        [DisplayName(Library.Phq9.Q3)]
        public int Answer3 { get; set; }

        [DisplayName(Library.Phq9.Q4)]
        public int Answer4 { get; set; }

        [DisplayName(Library.Phq9.Q5)]
        public int Answer5 { get; set; }

        [DisplayName(Library.Phq9.Q6)]
        public int Answer6 { get; set; }

        [DisplayName(Library.Phq9.Q7)]
        public int Answer7 { get; set; }

        [DisplayName(Library.Phq9.Q8)]
        public int Answer8 { get; set; }

        [DisplayName(Library.Phq9.Q9)]
        public int Answer9 { get; set; }

        public int Score
        {
            get
            {
                return Answer1 +
                    Answer2 +
                    Answer3 +
                    Answer4 +
                    Answer5 +
                    Answer6 +
                    Answer7 +
                    Answer8 +
                    Answer9;
            }
            private set { }
        }

        public List<KeyValuePair<int, string>> Responses = new List<KeyValuePair<int, string>>()
        {
            new KeyValuePair<int, string>(0, Library.Phq9.Response0),
            new KeyValuePair<int, string>(1, Library.Phq9.Response1),
            new KeyValuePair<int, string>(2, Library.Phq9.Response2),
            new KeyValuePair<int, string>(3, Library.Phq9.Response3)
        };
    }
}
