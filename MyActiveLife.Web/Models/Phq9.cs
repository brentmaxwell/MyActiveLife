using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyActiveLife.Web.Models
{
    public class Phq9
    {
        [DisplayName("Little interest or pleasure in doing things")]
        public int Answer1 { get; set; }

        [DisplayName("Feeling down, depressed, or hopeless")];
        public int Answer2 { get; set; }

        [DisplayName("Trouble falling or staying asleep, or sleeping too much")];
        public int Answer3 { get; set; }

        [DisplayName("Feeling tired or having little energy")];
        public int Answer4 { get; set; }

        [DisplayName("Poor appetite or overeating")];
        public int Answer5 { get; set; }

        [DisplayName("Feeling bad about yourself - or that you’re a failure or have let yourself or your family down")];
        public int Answer6 { get; set; }

        [DisplayName("Trouble concentrating on things, such as reading the newspaper or watching television")];
        public int Answer7 { get; set; }

        [DisplayName("Moving or speaking so slowly that other people could have noticed. Or, the opposite - being so fidgety or so restless that you have been moving around a lot more than usual")];
        public int Answer8 { get; set; }

        [DisplayName("Thoughts that you would be better off dead or of hurting yourself in some way")];
        public int Answer9 { get; set; }

        public List<KeyValuePair<int, string>> Responses = new List<KeyValuePair<int, string>>()
        {
            new KeyValuePair<int, string>(0, "Not at all"),
            new KeyValuePair<int, string>(1, "Several days"),
            new KeyValuePair<int, string>(2, "More than half the days"),
            new KeyValuePair<int, string>(3, "Nearly every day")
        };
    }
}
