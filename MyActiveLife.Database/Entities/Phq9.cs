using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    public class Phq9
    {
        [Key]
        public Guid Phq9Id { get; set; }
        public Guid UserId { get; set; }
        public string ExternalId { get; set; }
        public Guid DayId { get; set; }
        public DateTime DateTime { get; set; }
        public int Answer1 { get; set; }
        public int Answer2 { get; set; }
        public int Answer3 { get; set; }
        public int Answer4 { get; set; }
        public int Answer5 { get; set; }
        public int Answer6 { get; set; }
        public int Answer7 { get; set; }
        public int Answer8 { get; set; }
        public int Answer9 { get; set; }
        public int Score
        {
            get
            {
                return Answer1 +
                    Answer2 +
                    Answer3 +
                    Answer4 +
                    Answer5 +
                    Answer6 +
                    Answer7 +
                    Answer8 +
                    Answer9;
            }
            private set { }
        }

        [ForeignKey("UserId")]
        public virtual UserProfile UserProfile { get; set; }

        [ForeignKey("DayId")]
        public virtual Day Day { get; set; }
    }
}
