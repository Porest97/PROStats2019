﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROStats2019.Models;
using PROStats2019.Models.PROModels;

namespace PROStats2019.Controllers
{
    public class PROGames2013Controller : Controller
    {
        private readonly PROStats2019Context _context;

        public PROGames2013Controller(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: PROGames2013
        public async Task<IActionResult> Index()
        {
            var pROStats2019Context = _context.PROGames2013.Include(p => p.Arena).Include(p => p.AwayTeam).Include(p => p.GameStatus).Include(p => p.HomeTeam).Include(p => p.Referee1).Include(p => p.Referee2).Include(p => p.Referee3).Include(p => p.Referee4).Include(p => p.Referee5).Include(p => p.Series);
            return View(await pROStats2019Context.ToListAsync());
        }

        // GET: PROGames2013/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROGames2013 = await _context.PROGames2013
                .Include(p => p.Arena)
                .Include(p => p.AwayTeam)
                .Include(p => p.GameStatus)
                .Include(p => p.HomeTeam)
                .Include(p => p.Referee1)
                .Include(p => p.Referee2)
                .Include(p => p.Referee3)
                .Include(p => p.Referee4)
                .Include(p => p.Referee5)
                .Include(p => p.Series)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pROGames2013 == null)
            {
                return NotFound();
            }

            return View(pROGames2013);
        }

        // GET: PROGames2013/Create
        public IActionResult Create()
        {
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id");
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "Id");
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "Id");
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "Id");
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "Id");
            return View();
        }

        // POST: PROGames2013/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MatchNumber,MatchDateTime,ArenaId,TeamId,TeamId1,HomeTeamScore,AwayTeamScore,PersonId,PersonId1,PersonId2,PersonId3,PersonId4,SeriesId,TSMNumber,Payment,Payed,GameStatusId")] PROGames2013 pROGames2013)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pROGames2013);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id", pROGames2013.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "Id", pROGames2013.TeamId1);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "Id", pROGames2013.GameStatusId);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "Id", pROGames2013.TeamId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId3);
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId4);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "Id", pROGames2013.SeriesId);
            return View(pROGames2013);
        }

        // GET: PROGames2013/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROGames2013 = await _context.PROGames2013.FindAsync(id);
            if (pROGames2013 == null)
            {
                return NotFound();
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id", pROGames2013.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "Id", pROGames2013.TeamId1);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "Id", pROGames2013.GameStatusId);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "Id", pROGames2013.TeamId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId3);
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId4);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "Id", pROGames2013.SeriesId);
            return View(pROGames2013);
        }

        // POST: PROGames2013/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatchNumber,MatchDateTime,ArenaId,TeamId,TeamId1,HomeTeamScore,AwayTeamScore,PersonId,PersonId1,PersonId2,PersonId3,PersonId4,SeriesId,TSMNumber,Payment,Payed,GameStatusId")] PROGames2013 pROGames2013)
        {
            if (id != pROGames2013.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pROGames2013);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PROGames2013Exists(pROGames2013.Id))
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
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "Id", pROGames2013.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "Id", pROGames2013.TeamId1);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "Id", pROGames2013.GameStatusId);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "Id", pROGames2013.TeamId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId3);
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "Id", pROGames2013.PersonId4);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "Id", pROGames2013.SeriesId);
            return View(pROGames2013);
        }

        // GET: PROGames2013/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pROGames2013 = await _context.PROGames2013
                .Include(p => p.Arena)
                .Include(p => p.AwayTeam)
                .Include(p => p.GameStatus)
                .Include(p => p.HomeTeam)
                .Include(p => p.Referee1)
                .Include(p => p.Referee2)
                .Include(p => p.Referee3)
                .Include(p => p.Referee4)
                .Include(p => p.Referee5)
                .Include(p => p.Series)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pROGames2013 == null)
            {
                return NotFound();
            }

            return View(pROGames2013);
        }

        // POST: PROGames2013/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pROGames2013 = await _context.PROGames2013.FindAsync(id);
            _context.PROGames2013.Remove(pROGames2013);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PROGames2013Exists(int id)
        {
            return _context.PROGames2013.Any(e => e.Id == id);
        }
    }
}
