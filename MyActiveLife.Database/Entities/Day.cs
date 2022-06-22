using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("Day")]
    public class Day
    {
        [Key]
        public Guid DayId { get; set; }
        public Guid UserId { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        public Guid? WeatherId { get; set; }

        [ForeignKey("UserId")]
        public virtual UserProfile Profile { get; set; }

        [ForeignKey("WeatherId")]
        public virtual Weather? Weather { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Mood> Moods { get; set; }
        public virtual ICollection<Phq9> Phq9s { get; set; }
    }
}
