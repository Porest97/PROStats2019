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
    public class TeamRegistrationsController : Controller
    {
        private readonly PROStats2019Context _context;

        public TeamRegistrationsController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: TeamRegistrations
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeamRegistration.ToListAsync());
        }

        // GET: TeamRegistrations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamRegistration = await _context.TeamRegistration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamRegistration == null)
            {
                return NotFound();
            }

            return View(teamRegistration);
        }

        // GET: TeamRegistrations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeamRegistrations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeamRegistrationName")] TeamRegistration teamRegistration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamRegistration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamRegistration);
        }

        // GET: TeamRegistrations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamRegistration = await _context.TeamRegistration.FindAsync(id);
            if (teamRegistration == null)
            {
                return NotFound();
            }
            return View(teamRegistration);
        }

        // POST: TeamRegistrations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamRegistrationName")] TeamRegistration teamRegistration)
        {
            if (id != teamRegistration.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamRegistration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamRegistrationExists(teamRegistration.Id))
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
            return View(teamRegistration);
        }

        // GET: TeamRegistrations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamRegistration = await _context.TeamRegistration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamRegistration == null)
            {
                return NotFound();
            }

            return View(teamRegistration);
        }

        // POST: TeamRegistrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamRegistration = await _context.TeamRegistration.FindAsync(id);
            _context.TeamRegistration.Remove(teamRegistration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamRegistrationExists(int id)
        {
            return _context.TeamRegistration.Any(e => e.Id == id);
        }
    }
}
