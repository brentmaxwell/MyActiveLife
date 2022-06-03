﻿using System;
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
        public Guid ProfileId { get; set; }
        public Guid SourceId { get; set; }
        public string ExternalId  { get; set; }
        public int ActivityTypeId { get; set; }
        public string ActivityName { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }

        [ForeignKey("ProfileId")]
        public virtual Profile Profile { get; set; }

        [ForeignKey("SourceId")]
        public virtual Source Source { get; set; }

        [ForeignKey("ActivityTypeId")]
        public virtual ActivityType ActivityType { get; set; }
    }
}
