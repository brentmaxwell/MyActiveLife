using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("Entry")]
    public class Entry
    {
        public Guid EntryId { get; set; }
        public Guid UserId { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        [ForeignKey("UserId")]
        public virtual UserProfile Profile { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }
}
