using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dropbox06.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Dropbox06.Controllers
{
    public class DepartmentController : Controller
    {
        SchoolDBContext db;
        public DepartmentController(SchoolDBContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> AllDepartment()

        {
            var department = await db.Departments.ToListAsync();
            return View(department);
        }
        public IActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddDepartment(Department department)
        {
            db.Add(department);
            await db.SaveChangesAsync();
            return RedirectToAction("AllDepartment");
        }
    }
}
