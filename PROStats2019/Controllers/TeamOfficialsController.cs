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
    public class TeamOfficialsController : Controller
    {
        private readonly PROStats2019Context _context;

        public TeamOfficialsController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: TeamOfficials
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeamOfficial.ToListAsync());
        }

        // GET: TeamOfficials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamOfficial = await _context.TeamOfficial
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamOfficial == null)
            {
                return NotFound();
            }

            return View(teamOfficial);
        }

        // GET: TeamOfficials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeamOfficials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeamOfficialName")] TeamOfficial teamOfficial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamOfficial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamOfficial);
        }

        // GET: TeamOfficials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamOfficial = await _context.TeamOfficial.FindAsync(id);
            if (teamOfficial == null)
            {
                return NotFound();
            }
            return View(teamOfficial);
        }

        // POST: TeamOfficials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamOfficialName")] TeamOfficial teamOfficial)
        {
            if (id != teamOfficial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamOfficial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamOfficialExists(teamOfficial.Id))
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
            return View(teamOfficial);
        }

        // GET: TeamOfficials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamOfficial = await _context.TeamOfficial
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamOfficial == null)
            {
                return NotFound();
            }

            return View(teamOfficial);
        }

        // POST: TeamOfficials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamOfficial = await _context.TeamOfficial.FindAsync(id);
            _context.TeamOfficial.Remove(teamOfficial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamOfficialExists(int id)
        {
            return _context.TeamOfficial.Any(e => e.Id == id);
        }
    }
}
