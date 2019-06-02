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
    public class MatchLengthsController : Controller
    {
        private readonly PROStats2019Context _context;

        public MatchLengthsController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: MatchLengths
        public async Task<IActionResult> Index()
        {
            return View(await _context.MatchLength.ToListAsync());
        }

        // GET: MatchLengths/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchLength = await _context.MatchLength
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchLength == null)
            {
                return NotFound();
            }

            return View(matchLength);
        }

        // GET: MatchLengths/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MatchLengths/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MatchLengthName")] MatchLength matchLength)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matchLength);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matchLength);
        }

        // GET: MatchLengths/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchLength = await _context.MatchLength.FindAsync(id);
            if (matchLength == null)
            {
                return NotFound();
            }
            return View(matchLength);
        }

        // POST: MatchLengths/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatchLengthName")] MatchLength matchLength)
        {
            if (id != matchLength.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matchLength);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchLengthExists(matchLength.Id))
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
            return View(matchLength);
        }

        // GET: MatchLengths/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchLength = await _context.MatchLength
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchLength == null)
            {
                return NotFound();
            }

            return View(matchLength);
        }

        // POST: MatchLengths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matchLength = await _context.MatchLength.FindAsync(id);
            _context.MatchLength.Remove(matchLength);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchLengthExists(int id)
        {
            return _context.MatchLength.Any(e => e.Id == id);
        }
    }
}
