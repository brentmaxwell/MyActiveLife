using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Database.Entities
{
    public class Profile
    {
        public Guid ProfileId { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }

    }
}
