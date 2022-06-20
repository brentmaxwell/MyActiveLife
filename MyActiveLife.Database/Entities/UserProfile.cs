using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        public Guid UserId { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public virtual ICollection<Day> Days { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Diary> Diaries { get; set; }
        public virtual ICollection<Mood> Moods { get; set; }
        public virtual ICollection<Phq9> Phq9s { get; set; }
    }
}
