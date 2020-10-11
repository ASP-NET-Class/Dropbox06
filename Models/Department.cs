using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dropbox06.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Office { get; set; }
        public ICollection<Club> Clubs { get; set; }
    }
}
