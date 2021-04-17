using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaseballAnalysisTool.Areas.Admin.Models;
using BaseballAnalysisTool.Data;
using Microsoft.AspNetCore.Authorization;
using BaseballAnalysisTool.Utility;

namespace BaseballAnalysisTool.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.AdminEndUser)]
    public class BaseballDivisionsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BaseballDivisionsController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Admin/BaseballDivisions
        public async Task<IActionResult> Index()
        {
            var baseballDivisions = _db.BaseballDivisions.Include(b => b.BaseballLeague);
            return View(await baseballDivisions.ToListAsync());
        }


        // GET: Admin/BaseballDivisions/Create
        public IActionResult Create()
        {
            ViewData["BaseballLeagueID"] = new SelectList(_db.BaseballLeagues, "ID", "Name");
            return View();
        }

        // POST: Admin/BaseballDivisions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,BaseballLeagueID")] BaseballDivision baseballDivision)
        {
            if (ModelState.IsValid)
            {
                _db.Add(baseballDivision);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BaseballLeagueID"] = new SelectList(_db.BaseballLeagues, "ID", "Name", baseballDivision.BaseballLeagueID);
            return View(baseballDivision);
        }

        // GET: Admin/BaseballDivisions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baseballDivision = await _db.BaseballDivisions.FindAsync(id);
            if (baseballDivision == null)
            {
                return NotFound();
            }
            ViewData["BaseballLeagueID"] = new SelectList(_db.BaseballLeagues, "ID", "Name", baseballDivision.BaseballLeagueID);
            return View(baseballDivision);
        }

        // POST: Admin/BaseballDivisions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,BaseballLeagueID")] BaseballDivision baseballDivision)
        {
            if (id != baseballDivision.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(baseballDivision);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BaseballDivisionExists(baseballDivision.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BaseballLeagueID"] = new SelectList(_db.BaseballLeagues, "ID", "Name", baseballDivision.BaseballLeagueID);
            return View(baseballDivision);
        }
        
        private bool BaseballDivisionExists(int id)
        {
            return _db.BaseballDivisions.Any(e => e.ID == id);
        }
    }
}
