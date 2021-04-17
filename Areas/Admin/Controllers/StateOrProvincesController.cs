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
    public class StateOrProvincesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StateOrProvincesController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Admin/StateOrProvinces
        public async Task<IActionResult> Index()
        {
            return View(await _db.StateOrProvinces.ToListAsync());
        }

        // GET: Admin/StateOrProvinces/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/StateOrProvinces/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] StateOrProvince stateOrProvince)
        {
            if (ModelState.IsValid)
            {
                _db.Add(stateOrProvince);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stateOrProvince);
        }

        // GET: Admin/StateOrProvinces/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stateOrProvince = await _db.StateOrProvinces.FindAsync(id);
            if (stateOrProvince == null)
            {
                return NotFound();
            }
            return View(stateOrProvince);
        }

        // POST: Admin/StateOrProvinces/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] StateOrProvince stateOrProvince)
        {
            if (id != stateOrProvince.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(stateOrProvince);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StateOrProvinceExists(stateOrProvince.ID))
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
            return View(stateOrProvince);
        }

        private bool StateOrProvinceExists(int id)
        {
            return _db.StateOrProvinces.Any(e => e.ID == id);
        }
    }
}
