namespace MyActiveLife.Web.Models
{
    public class DayModel
    {
        public DateTime Date { get; set; }

        public List<Phq9Model> Phq9s { get; set; }
        public List<ActivityModel> Activities { get; set; }
    }
}
