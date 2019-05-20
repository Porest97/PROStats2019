﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HockeyStats2019.Models;
using PROStats2019.Models;

namespace PROStats2019.Controllers
{
    public class TeamsController : Controller
    {
        private readonly PROStats2019Context _context;

        public TeamsController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: Teams
        public async Task<IActionResult> Index()
        {
            var pROStats2019Context = _context.Team.Include(t => t.AssCoach).Include(t => t.AssCoach1).Include(t => t.HeadCoach);
            return View(await pROStats2019Context.ToListAsync());
        }

        // GET: Teams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Team
                .Include(t => t.AssCoach)
                .Include(t => t.AssCoach1)
                .Include(t => t.HeadCoach)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // GET: Teams/Create
        public IActionResult Create()
        {
            ViewData["PersonId1"] = new SelectList(_context.Set<Person>(), "Id", "Id");
            ViewData["PersonId2"] = new SelectList(_context.Set<Person>(), "Id", "Id");
            ViewData["PersonId"] = new SelectList(_context.Set<Person>(), "Id", "Id");
            return View();
        }

        // POST: Teams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeamName,PersonId,PersonId1,PersonId2")] Team team)
        {
            if (ModelState.IsValid)
            {
                _context.Add(team);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId1"] = new SelectList(_context.Set<Person>(), "Id", "Id", team.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Set<Person>(), "Id", "Id", team.PersonId2);
            ViewData["PersonId"] = new SelectList(_context.Set<Person>(), "Id", "Id", team.PersonId);
            return View(team);
        }

        // GET: Teams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Team.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }
            ViewData["PersonId1"] = new SelectList(_context.Set<Person>(), "Id", "Id", team.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Set<Person>(), "Id", "Id", team.PersonId2);
            ViewData["PersonId"] = new SelectList(_context.Set<Person>(), "Id", "Id", team.PersonId);
            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamName,PersonId,PersonId1,PersonId2")] Team team)
        {
            if (id != team.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(team);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamExists(team.Id))
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
            ViewData["PersonId1"] = new SelectList(_context.Set<Person>(), "Id", "Id", team.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Set<Person>(), "Id", "Id", team.PersonId2);
            ViewData["PersonId"] = new SelectList(_context.Set<Person>(), "Id", "Id", team.PersonId);
            return View(team);
        }

        // GET: Teams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Team
                .Include(t => t.AssCoach)
                .Include(t => t.AssCoach1)
                .Include(t => t.HeadCoach)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var team = await _context.Team.FindAsync(id);
            _context.Team.Remove(team);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamExists(int id)
        {
            return _context.Team.Any(e => e.Id == id);
        }
    }
}
