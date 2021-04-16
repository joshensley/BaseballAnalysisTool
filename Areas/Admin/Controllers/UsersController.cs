using BaseballAnalysisTool.Data;
using BaseballAnalysisTool.Models;
using BaseballAnalysisTool.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.AdminEndUser)]
    public class UsersController : Controller
    {
        public readonly ApplicationDbContext _db;

        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            IQueryable<ApplicationUser> applicationUserIQ = _db.ApplicationUsers
                .OrderBy(x => x.LastName);

            int pageSize = 5;
            return View(await PaginatedList<ApplicationUser>.CreateAsync(
                applicationUserIQ.AsNoTracking(),
                pageNumber ?? 1,
                pageSize));
        }
    }
}
