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
    public class MatchReportingsController : Controller
    {
        private readonly PROStats2019Context _context;

        public MatchReportingsController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: MatchReportings
        public async Task<IActionResult> Index()
        {
            return View(await _context.MatchReporting.ToListAsync());
        }

        // GET: MatchReportings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchReporting = await _context.MatchReporting
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchReporting == null)
            {
                return NotFound();
            }

            return View(matchReporting);
        }

        // GET: MatchReportings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MatchReportings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MatchReportingName")] MatchReporting matchReporting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matchReporting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matchReporting);
        }

        // GET: MatchReportings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchReporting = await _context.MatchReporting.FindAsync(id);
            if (matchReporting == null)
            {
                return NotFound();
            }
            return View(matchReporting);
        }

        // POST: MatchReportings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatchReportingName")] MatchReporting matchReporting)
        {
            if (id != matchReporting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matchReporting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchReportingExists(matchReporting.Id))
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
            return View(matchReporting);
        }

        // GET: MatchReportings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchReporting = await _context.MatchReporting
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchReporting == null)
            {
                return NotFound();
            }

            return View(matchReporting);
        }

        // POST: MatchReportings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matchReporting = await _context.MatchReporting.FindAsync(id);
            _context.MatchReporting.Remove(matchReporting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchReportingExists(int id)
        {
            return _context.MatchReporting.Any(e => e.Id == id);
        }
    }
}
