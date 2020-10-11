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
        public int StudentCapacity { get; set; }
        public Club Club { get; set; }

        public static implicit operator string(Department v)
        {
            throw new NotImplementedException();
        }
    }
}
