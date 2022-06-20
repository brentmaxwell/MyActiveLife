using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("Mood")]
    public class Mood
    {
        [Key]
        public Guid MoodId { get; set; }
        public Guid UserId { get; set; }
        public Guid DayId { get; set; }
        public DateTime DateTime { get; set; }
        public short MoodLevel { get; set; }
        public string Notes { get; set; }

        [ForeignKey("DayId")]
        public virtual Day Day { get; set; }
    }
}
