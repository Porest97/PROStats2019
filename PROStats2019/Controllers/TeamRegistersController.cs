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
    public class TeamRegistersController : Controller
    {
        private readonly PROStats2019Context _context;

        public TeamRegistersController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: TeamRegisters
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeamRegister.ToListAsync());
        }

        // GET: TeamRegisters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamRegister = await _context.TeamRegister
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamRegister == null)
            {
                return NotFound();
            }

            return View(teamRegister);
        }

        // GET: TeamRegisters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeamRegisters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeamRegisterName")] TeamRegister teamRegister)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamRegister);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamRegister);
        }

        // GET: TeamRegisters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamRegister = await _context.TeamRegister.FindAsync(id);
            if (teamRegister == null)
            {
                return NotFound();
            }
            return View(teamRegister);
        }

        // POST: TeamRegisters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamRegisterName")] TeamRegister teamRegister)
        {
            if (id != teamRegister.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamRegister);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamRegisterExists(teamRegister.Id))
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
            return View(teamRegister);
        }

        // GET: TeamRegisters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamRegister = await _context.TeamRegister
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamRegister == null)
            {
                return NotFound();
            }

            return View(teamRegister);
        }

        // POST: TeamRegisters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamRegister = await _context.TeamRegister.FindAsync(id);
            _context.TeamRegister.Remove(teamRegister);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamRegisterExists(int id)
        {
            return _context.TeamRegister.Any(e => e.Id == id);
        }
    }
}
