﻿using System;
using System.Collections.Generic;
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
            var departmentDisplay = await db.Departments.Select(x => new { Id =
                x.DepartmentId, Value = x.DepartmentName }).ToListAsync();
            ClubAddClubViewModel vm = new ClubAddClubViewModel();
            vm.DepartmentList = new SelectList(departmentDisplay, "Id", "Value");
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddClub(ClubAddClubViewModel vm)
        {
            var department = await db.Departments.SingleOrDefaultAsync(i =>
            i.DepartmentId == vm.Department.DepartmentId);
            vm.Club.Department = department;
            db.Add(vm.Club);
            await db.SaveChangesAsync();
            return RedirectToAction("AllClub");
        }
    }
}
