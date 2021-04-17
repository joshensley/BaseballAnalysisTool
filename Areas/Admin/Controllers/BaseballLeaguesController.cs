using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaseballAnalysisTool.Areas.Admin.Models;
using BaseballAnalysisTool.Data;

namespace BaseballAnalysisTool.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseballLeaguesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BaseballLeaguesController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Admin/BaseballLeagues
        public async Task<IActionResult> Index()
        {
            return View(await _db.BaseballLeagues.ToListAsync());
        }

        // GET: Admin/BaseballLeagues/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BaseballLeagues/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] BaseballLeague baseballLeague)
        {
            if (ModelState.IsValid)
            {
                _db.Add(baseballLeague);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(baseballLeague);
        }

        // GET: Admin/BaseballLeagues/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baseballLeague = await _db.BaseballLeagues.FindAsync(id);
            if (baseballLeague == null)
            {
                return NotFound();
            }
            return View(baseballLeague);
        }

        // POST: Admin/BaseballLeagues/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] BaseballLeague baseballLeague)
        {
            if (id != baseballLeague.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(baseballLeague);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BaseballLeagueExists(baseballLeague.ID))
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
            return View(baseballLeague);
        }

        private bool BaseballLeagueExists(int id)
        {
            return _db.BaseballLeagues.Any(e => e.ID == id);
        }
    }
}
