using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("Activity")]
    public class Activity
    {
        [Key]
        public Guid ActivityId { get; set; }
        public Guid UserId { get; set; }
        public Guid DayId { get; set; }
        public Guid SourceId { get; set; }
        public string? ExternalId  { get; set; }
        public int ActivityTypeId { get; set; }
        public string ActivityName { get; set; }

        public string? Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public Guid WeatherId { get; set; }

        [ForeignKey("UserId")]
        public virtual UserProfile UserProfile { get; set; }

        [ForeignKey("DayId")]
        public virtual Day Day { get; set; }

        [ForeignKey("SourceId")]
        public virtual Source Source { get; set; }

        [ForeignKey("ActivityTypeId")]
        public virtual ActivityType ActivityType { get; set; }
        
        [ForeignKey("WeatherId")]
        public virtual Weather Weather { get; set; }

    }
}
