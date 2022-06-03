using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyActiveLife.Web.Models
{
    public class ActivityModel
    {
        [DisplayName("Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DisplayName("Start Time")]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
    }
}
