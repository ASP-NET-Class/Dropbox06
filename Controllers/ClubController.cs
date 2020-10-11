using System.Linq;
using System.Threading.Tasks;
using Dropbox06.Models;
using Dropbox06.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Dropbox06.Controllers
{
    public class ClubController : Controller
    {
        SchoolDBContext db;
        private Department department;

        public ClubController(SchoolDBContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> AllClub()

        {
            var club = await db.Clubs.Include(c => c.Department).ToListAsync();
            return View(club);
        }
        public async Task<IActionResult> AddClub()
        {
            var DepartmentDisplay = await db.Departments.Select(x => new { Id =
                x.DepartmentId, Value = x.DepartmentName }).ToListAsync();
            ClubAddClubViewModel vm = new ClubAddClubViewModel();
            vm.DepartmentList = new SelectList(DepartmentDisplay, "Id", "Value");
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddClub(ClubAddClubViewModel vm)
        {
            var department = await NewMethod(vm);
            vm.Club.Department = department;
            db.Add(vm.Club);
            await db.SaveChangesAsync();
            return RedirectToAction("AllClub");
        }

        private async Task<Department> NewMethod(ClubAddClubViewModel vm)
        {
            return await db.Departments.SingleOrDefaultAsync(i =>
                        i.DepartmentId == vm.Department.DepartmentId);
        }
    }
}

