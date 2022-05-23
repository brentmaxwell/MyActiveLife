using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    public class Photo
    {
        public Guid PhotoId { get; set; }
        public Guid ProfileId { get; set; }
        public string Source { get; set; }
        public string SourceId { get; set; }
    }
}
