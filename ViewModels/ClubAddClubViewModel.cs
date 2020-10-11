using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dropbox06.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dropbox06.ViewModels
{
    public class ClubAddClubViewModel
    {
        public Club Club { get; set; }
        public Department Department { get; set; }
        public SelectList DepartmentList { get; set; }
    }
}
