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
        public string StudentCapacity { get; set; }
        public string Department { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Department> Departments { get; set; }
        
    }
}
