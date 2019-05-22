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
    public class ProGamesController : Controller
    {
        private readonly PROStats2019Context _context;

        public ProGamesController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: ProGames
        public async Task<IActionResult> Index()
        {
            var pROStats2019Context = _context.ProGame.Include(p => p.Arena).Include(p => p.AwayTeam).Include(p => p.GameStatus).Include(p => p.HomeTeam).Include(p => p.Referee1).Include(p => p.Referee2).Include(p => p.Referee3).Include(p => p.Referee4).Include(p => p.Referee5).Include(p => p.Series);
            return View(await pROStats2019Context.ToListAsync());
        }

        // GET: ProGames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proGame = await _context.ProGame
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
            if (proGame == null)
            {
                return NotFound();
            }

            return View(proGame);
        }

        // GET: ProGames/Create
        public IActionResult Create()
        {
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName");
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName");
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName");
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName");
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "SeriesName");
            return View();
        }

        // POST: ProGames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MatchNumber,MatchDateTime,ArenaId,TeamId,TeamId1,HomeTeamScore,AwayTeamScore,PersonId,PersonId1,PersonId2,PersonId3,PersonId4,SeriesId,TSMNumber,Payment,Payed,GameStatusId")] ProGame proGame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proGame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", proGame.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName", proGame.TeamId1);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", proGame.GameStatusId);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", proGame.TeamId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId3);
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId4);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "SeriesName", proGame.SeriesId);
            return View(proGame);
        }

        // GET: ProGames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proGame = await _context.ProGame.FindAsync(id);
            if (proGame == null)
            {
                return NotFound();
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", proGame.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName", proGame.TeamId1);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", proGame.GameStatusId);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", proGame.TeamId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId3);
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId4);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "SeriesName", proGame.SeriesId);
            return View(proGame);
        }

        // POST: ProGames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatchNumber,MatchDateTime,ArenaId,TeamId,TeamId1,HomeTeamScore,AwayTeamScore,PersonId,PersonId1,PersonId2,PersonId3,PersonId4,SeriesId,TSMNumber,Payment,Payed,GameStatusId")] ProGame proGame)
        {
            if (id != proGame.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProGameExists(proGame.Id))
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
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", proGame.ArenaId);
            ViewData["TeamId1"] = new SelectList(_context.Team, "Id", "TeamName", proGame.TeamId1);
            ViewData["GameStatusId"] = new SelectList(_context.GameStatus, "Id", "GameStatusName", proGame.GameStatusId);
            ViewData["TeamId"] = new SelectList(_context.Team, "Id", "TeamName", proGame.TeamId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId3);
            ViewData["PersonId4"] = new SelectList(_context.Person, "Id", "FullName", proGame.PersonId4);
            ViewData["SeriesId"] = new SelectList(_context.Series, "Id", "SeriesName", proGame.SeriesId);
            return View(proGame);
        }

        // GET: ProGames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proGame = await _context.ProGame
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
            if (proGame == null)
            {
                return NotFound();
            }

            return View(proGame);
        }

        // POST: ProGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proGame = await _context.ProGame.FindAsync(id);
            _context.ProGame.Remove(proGame);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProGameExists(int id)
        {
            return _context.ProGame.Any(e => e.Id == id);
        }
    }
}
