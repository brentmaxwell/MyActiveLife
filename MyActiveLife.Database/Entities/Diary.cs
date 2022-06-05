using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("Diary")]
    public class Diary
    {
        [Key]
        public Guid DiaryId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateTime { get; set; }
        public string Entry { get; set; }

        [ForeignKey("UserId")]
        public virtual UserProfile UserProfile { get; set; }
    }
}
