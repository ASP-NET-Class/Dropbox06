using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dropbox06.Models
{
    public class Club
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public int StudentCapacity { get; set; }
        public Department Department { get; set; }
        public ICollection<EnrollClub> EnrollClubs { get; set; }

    }
}
