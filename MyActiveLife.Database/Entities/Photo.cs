﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("Photo")]
    public class Photo
    {
        [Key]
        public Guid PhotoId { get; set; }
        public Guid ProfileId { get; set; }
        public Guid SourceId { get; set; }
        public string ExternalId { get; set; }

        [ForeignKey("ProfileId")]
        public virtual Profile Profile { get; set; }

        [ForeignKey("SourceId")]
        public virtual Source Source { get; set; }
    }
}
