using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("ActivityType")]
    public class ActivityType
    {
        [Key]
        public int ActivityTypeId { get; set; }
        public string ActivityTypeName { get; set; }
        public virtual List<Activity> Activities { get; set; }
    }
}
