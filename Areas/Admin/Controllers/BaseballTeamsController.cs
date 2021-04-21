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
    public class BaseballTeamsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BaseballTeamsController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Admin/BaseballTeams
        public async Task<IActionResult> Index()
        {
            var baseballTeams = await _db.BaseballTeam
                .Include(b => b.BaseballDivision)
                .Include(b => b.BaseballLeague)
                .Include(b => b.Country)
                .Include(b => b.StateOrProvince)
                .OrderBy(b => b.BaseballDivision)
                    .ThenBy(b => b.City)
                .ToListAsync();

            return View(baseballTeams);
        }

        // GET: Admin/BaseballTeams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baseballTeam = await _db.BaseballTeam
                .Include(b => b.BaseballDivision)
                .Include(b => b.BaseballLeague)
                .Include(b => b.Country)
                .Include(b => b.StateOrProvince)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (baseballTeam == null)
            {
                return NotFound();
            }

            return View(baseballTeam);
        }

        // GET: Admin/BaseballTeams/Create
        public IActionResult Create()
        {
            ViewData["BaseballDivisionID"] = new SelectList(_db.BaseballDivisions, "ID", "Name");
            ViewData["BaseballLeagueID"] = new SelectList(_db.BaseballLeagues, "ID", "Name");
            ViewData["CountryID"] = new SelectList(_db.Country, "ID", "Name");
            ViewData["StateOrProvinceID"] = new SelectList(_db.StateOrProvinces, "ID", "Name");
            return View();
        }

        // POST: Admin/BaseballTeams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Location,NickName,StadiumName,City,StateOrProvinceID,CountryID,BaseballDivisionID,BaseballLeagueID")] BaseballTeam baseballTeam)
        {
            if (ModelState.IsValid)
            {
                _db.Add(baseballTeam);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BaseballDivisionID"] = new SelectList(_db.BaseballDivisions, "ID", "Name", baseballTeam.BaseballDivisionID);
            ViewData["BaseballLeagueID"] = new SelectList(_db.BaseballLeagues, "ID", "Name", baseballTeam.BaseballLeagueID);
            ViewData["CountryID"] = new SelectList(_db.Country, "ID", "Name", baseballTeam.CountryID);
            ViewData["StateOrProvinceID"] = new SelectList(_db.StateOrProvinces, "ID", "Name", baseballTeam.StateOrProvinceID);
            return View(baseballTeam);
        }

        // GET: Admin/BaseballTeams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baseballTeam = await _db.BaseballTeam.FindAsync(id);
            if (baseballTeam == null)
            {
                return NotFound();
            }
            ViewData["BaseballDivisionID"] = new SelectList(_db.BaseballDivisions, "ID", "Name", baseballTeam.BaseballDivisionID);
            ViewData["BaseballLeagueID"] = new SelectList(_db.BaseballLeagues, "ID", "Name", baseballTeam.BaseballLeagueID);
            ViewData["CountryID"] = new SelectList(_db.Country, "ID", "Name", baseballTeam.CountryID);
            ViewData["StateOrProvinceID"] = new SelectList(_db.StateOrProvinces, "ID", "Name", baseballTeam.StateOrProvinceID);
            return View(baseballTeam);
        }

        // POST: Admin/BaseballTeams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Location,NickName,StadiumName,City,StateOrProvinceID,CountryID,BaseballDivisionID,BaseballLeagueID")] BaseballTeam baseballTeam)
        {
            if (id != baseballTeam.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(baseballTeam);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BaseballTeamExists(baseballTeam.ID))
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
            ViewData["BaseballDivisionID"] = new SelectList(_db.BaseballDivisions, "ID", "Name", baseballTeam.BaseballDivisionID);
            ViewData["BaseballLeagueID"] = new SelectList(_db.BaseballLeagues, "ID", "Name", baseballTeam.BaseballLeagueID);
            ViewData["CountryID"] = new SelectList(_db.Country, "ID", "Name", baseballTeam.CountryID);
            ViewData["StateOrProvinceID"] = new SelectList(_db.StateOrProvinces, "ID", "Name", baseballTeam.StateOrProvinceID);
            return View(baseballTeam);
        }

        private bool BaseballTeamExists(int id)
        {
            return _db.BaseballTeam.Any(e => e.ID == id);
        }
    }
}
