﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("Profile")]
    public class Profile
    {
        [Key]
        public Guid ProfileId { get; set; }
        public Guid UserId { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public virtual List<Activity> Activities { get; set; }
        public virtual List<Photo> Photos { get; set; }
    }
}
