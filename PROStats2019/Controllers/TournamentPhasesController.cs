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
    public class TournamentPhasesController : Controller
    {
        private readonly PROStats2019Context _context;

        public TournamentPhasesController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: TournamentPhases
        public async Task<IActionResult> Index()
        {
            return View(await _context.TournamentPhase.ToListAsync());
        }

        // GET: TournamentPhases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournamentPhase = await _context.TournamentPhase
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tournamentPhase == null)
            {
                return NotFound();
            }

            return View(tournamentPhase);
        }

        // GET: TournamentPhases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TournamentPhases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TournamentPhaseName")] TournamentPhase tournamentPhase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tournamentPhase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tournamentPhase);
        }

        // GET: TournamentPhases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournamentPhase = await _context.TournamentPhase.FindAsync(id);
            if (tournamentPhase == null)
            {
                return NotFound();
            }
            return View(tournamentPhase);
        }

        // POST: TournamentPhases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TournamentPhaseName")] TournamentPhase tournamentPhase)
        {
            if (id != tournamentPhase.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tournamentPhase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TournamentPhaseExists(tournamentPhase.Id))
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
            return View(tournamentPhase);
        }

        // GET: TournamentPhases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournamentPhase = await _context.TournamentPhase
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tournamentPhase == null)
            {
                return NotFound();
            }

            return View(tournamentPhase);
        }

        // POST: TournamentPhases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tournamentPhase = await _context.TournamentPhase.FindAsync(id);
            _context.TournamentPhase.Remove(tournamentPhase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TournamentPhaseExists(int id)
        {
            return _context.TournamentPhase.Any(e => e.Id == id);
        }
    }
}
