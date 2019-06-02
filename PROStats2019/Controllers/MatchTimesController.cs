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
    public class MatchTimesController : Controller
    {
        private readonly PROStats2019Context _context;

        public MatchTimesController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: MatchTimes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MatchTime.ToListAsync());
        }

        // GET: MatchTimes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchTime = await _context.MatchTime
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchTime == null)
            {
                return NotFound();
            }

            return View(matchTime);
        }

        // GET: MatchTimes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MatchTimes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MatchTimeName")] MatchTime matchTime)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matchTime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matchTime);
        }

        // GET: MatchTimes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchTime = await _context.MatchTime.FindAsync(id);
            if (matchTime == null)
            {
                return NotFound();
            }
            return View(matchTime);
        }

        // POST: MatchTimes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatchTimeName")] MatchTime matchTime)
        {
            if (id != matchTime.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matchTime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchTimeExists(matchTime.Id))
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
            return View(matchTime);
        }

        // GET: MatchTimes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchTime = await _context.MatchTime
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchTime == null)
            {
                return NotFound();
            }

            return View(matchTime);
        }

        // POST: MatchTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matchTime = await _context.MatchTime.FindAsync(id);
            _context.MatchTime.Remove(matchTime);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchTimeExists(int id)
        {
            return _context.MatchTime.Any(e => e.Id == id);
        }
    }
}
