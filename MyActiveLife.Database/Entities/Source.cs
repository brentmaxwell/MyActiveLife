using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    [Table("Source")]
    public class Source
    {
        [Key]
        public Guid SourceId { get; set; }
        public string SourceName { get; set; }

    }
}
