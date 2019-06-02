using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROStats2019.Models;

namespace PROStats2019.Controllers
{
    public class RefereeLevelsController : Controller
    {
        private readonly PROStats2019Context _context;

        public RefereeLevelsController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: RefereeLevels
        public async Task<IActionResult> Index()
        {
            return View(await _context.RefereeLevel.ToListAsync());
        }

        // GET: RefereeLevels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refereeLevel = await _context.RefereeLevel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refereeLevel == null)
            {
                return NotFound();
            }

            return View(refereeLevel);
        }

        // GET: RefereeLevels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RefereeLevels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RefereeLevelName")] RefereeLevel refereeLevel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(refereeLevel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(refereeLevel);
        }

        // GET: RefereeLevels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refereeLevel = await _context.RefereeLevel.FindAsync(id);
            if (refereeLevel == null)
            {
                return NotFound();
            }
            return View(refereeLevel);
        }

        // POST: RefereeLevels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RefereeLevelName")] RefereeLevel refereeLevel)
        {
            if (id != refereeLevel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refereeLevel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefereeLevelExists(refereeLevel.Id))
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
            return View(refereeLevel);
        }

        // GET: RefereeLevels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refereeLevel = await _context.RefereeLevel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (refereeLevel == null)
            {
                return NotFound();
            }

            return View(refereeLevel);
        }

        // POST: RefereeLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var refereeLevel = await _context.RefereeLevel.FindAsync(id);
            _context.RefereeLevel.Remove(refereeLevel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RefereeLevelExists(int id)
        {
            return _context.RefereeLevel.Any(e => e.Id == id);
        }
    }
}
