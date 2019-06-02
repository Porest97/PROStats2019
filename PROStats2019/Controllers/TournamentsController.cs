﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROStats2019.Models;

namespace PROStats2019.Controllers
{
    public class TournamentsController : Controller
    {
        private readonly PROStats2019Context _context;

        public TournamentsController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: Tournaments
        public async Task<IActionResult> Index()
        {
            var pROStats2019Context = _context.Tournament.Include(t => t.District).Include(t => t.MatchLength).Include(t => t.MatchReporting).Include(t => t.MatchTime).Include(t => t.RefereeLevel).Include(t => t.TableSystem).Include(t => t.TeamNotification).Include(t => t.TeamOfficial).Include(t => t.TeamRegistration).Include(t => t.TournamentPhase);
            return View(await pROStats2019Context.ToListAsync());
        }

        // GET: Tournaments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournament = await _context.Tournament
                .Include(t => t.District)
                .Include(t => t.MatchLength)
                .Include(t => t.MatchReporting)
                .Include(t => t.MatchTime)
                .Include(t => t.RefereeLevel)
                .Include(t => t.TableSystem)
                .Include(t => t.TeamNotification)
                .Include(t => t.TeamOfficial)
                .Include(t => t.TeamRegistration)
                .Include(t => t.TournamentPhase)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tournament == null)
            {
                return NotFound();
            }

            return View(tournament);
        }

        // GET: Tournaments/Create
        public IActionResult Create()
        {
            ViewData["RefereeDistrictId"] = new SelectList(_context.RefereeDistrict, "Id", "Id");
            ViewData["MatchLengthId"] = new SelectList(_context.Set<MatchLength>(), "Id", "Id");
            ViewData["MatchReportingId"] = new SelectList(_context.Set<MatchReporting>(), "Id", "Id");
            ViewData["MatchTimeId"] = new SelectList(_context.Set<MatchTime>(), "Id", "Id");
            ViewData["RefereeLevelId"] = new SelectList(_context.Set<RefereeLevel>(), "Id", "Id");
            ViewData["TableSystemId"] = new SelectList(_context.Set<TableSystem>(), "Id", "Id");
            ViewData["TeamNotificationId"] = new SelectList(_context.Set<TeamNotification>(), "Id", "Id");
            ViewData["TeamOfficialId"] = new SelectList(_context.Set<TeamOfficial>(), "Id", "Id");
            ViewData["TeamRegistrationId"] = new SelectList(_context.Set<RefereeLevel>(), "Id", "Id");
            ViewData["TournamentPhaseId"] = new SelectList(_context.Set<TournamentPhase>(), "Id", "Id");
            return View();
        }

        // POST: Tournaments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RefereeDistrictId,TournamentName,TournamentPhaseId,SeriesNumber,SeriesId,MatchLengthId,MatchReportingId,TableSystemId,RefereeLevelId,TeamNotificationId,TeamRegistrationId,TeamOfficialId,MatchTimeId")] Tournament tournament)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tournament);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RefereeDistrictId"] = new SelectList(_context.RefereeDistrict, "Id", "Id", tournament.RefereeDistrictId);
            ViewData["MatchLengthId"] = new SelectList(_context.Set<MatchLength>(), "Id", "Id", tournament.MatchLengthId);
            ViewData["MatchReportingId"] = new SelectList(_context.Set<MatchReporting>(), "Id", "Id", tournament.MatchReportingId);
            ViewData["MatchTimeId"] = new SelectList(_context.Set<MatchTime>(), "Id", "Id", tournament.MatchTimeId);
            ViewData["RefereeLevelId"] = new SelectList(_context.Set<RefereeLevel>(), "Id", "Id", tournament.RefereeLevelId);
            ViewData["TableSystemId"] = new SelectList(_context.Set<TableSystem>(), "Id", "Id", tournament.TableSystemId);
            ViewData["TeamNotificationId"] = new SelectList(_context.Set<TeamNotification>(), "Id", "Id", tournament.TeamNotificationId);
            ViewData["TeamOfficialId"] = new SelectList(_context.Set<TeamOfficial>(), "Id", "Id", tournament.TeamOfficialId);
            ViewData["TeamRegistrationId"] = new SelectList(_context.Set<RefereeLevel>(), "Id", "Id", tournament.TeamRegistrationId);
            ViewData["TournamentPhaseId"] = new SelectList(_context.Set<TournamentPhase>(), "Id", "Id", tournament.TournamentPhaseId);
            return View(tournament);
        }

        // GET: Tournaments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournament = await _context.Tournament.FindAsync(id);
            if (tournament == null)
            {
                return NotFound();
            }
            ViewData["RefereeDistrictId"] = new SelectList(_context.RefereeDistrict, "Id", "Id", tournament.RefereeDistrictId);
            ViewData["MatchLengthId"] = new SelectList(_context.Set<MatchLength>(), "Id", "Id", tournament.MatchLengthId);
            ViewData["MatchReportingId"] = new SelectList(_context.Set<MatchReporting>(), "Id", "Id", tournament.MatchReportingId);
            ViewData["MatchTimeId"] = new SelectList(_context.Set<MatchTime>(), "Id", "Id", tournament.MatchTimeId);
            ViewData["RefereeLevelId"] = new SelectList(_context.Set<RefereeLevel>(), "Id", "Id", tournament.RefereeLevelId);
            ViewData["TableSystemId"] = new SelectList(_context.Set<TableSystem>(), "Id", "Id", tournament.TableSystemId);
            ViewData["TeamNotificationId"] = new SelectList(_context.Set<TeamNotification>(), "Id", "Id", tournament.TeamNotificationId);
            ViewData["TeamOfficialId"] = new SelectList(_context.Set<TeamOfficial>(), "Id", "Id", tournament.TeamOfficialId);
            ViewData["TeamRegistrationId"] = new SelectList(_context.Set<RefereeLevel>(), "Id", "Id", tournament.TeamRegistrationId);
            ViewData["TournamentPhaseId"] = new SelectList(_context.Set<TournamentPhase>(), "Id", "Id", tournament.TournamentPhaseId);
            return View(tournament);
        }

        // POST: Tournaments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RefereeDistrictId,TournamentName,TournamentPhaseId,SeriesNumber,SeriesId,MatchLengthId,MatchReportingId,TableSystemId,RefereeLevelId,TeamNotificationId,TeamRegistrationId,TeamOfficialId,MatchTimeId")] Tournament tournament)
        {
            if (id != tournament.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tournament);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TournamentExists(tournament.Id))
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
            ViewData["RefereeDistrictId"] = new SelectList(_context.RefereeDistrict, "Id", "Id", tournament.RefereeDistrictId);
            ViewData["MatchLengthId"] = new SelectList(_context.Set<MatchLength>(), "Id", "Id", tournament.MatchLengthId);
            ViewData["MatchReportingId"] = new SelectList(_context.Set<MatchReporting>(), "Id", "Id", tournament.MatchReportingId);
            ViewData["MatchTimeId"] = new SelectList(_context.Set<MatchTime>(), "Id", "Id", tournament.MatchTimeId);
            ViewData["RefereeLevelId"] = new SelectList(_context.Set<RefereeLevel>(), "Id", "Id", tournament.RefereeLevelId);
            ViewData["TableSystemId"] = new SelectList(_context.Set<TableSystem>(), "Id", "Id", tournament.TableSystemId);
            ViewData["TeamNotificationId"] = new SelectList(_context.Set<TeamNotification>(), "Id", "Id", tournament.TeamNotificationId);
            ViewData["TeamOfficialId"] = new SelectList(_context.Set<TeamOfficial>(), "Id", "Id", tournament.TeamOfficialId);
            ViewData["TeamRegistrationId"] = new SelectList(_context.Set<RefereeLevel>(), "Id", "Id", tournament.TeamRegistrationId);
            ViewData["TournamentPhaseId"] = new SelectList(_context.Set<TournamentPhase>(), "Id", "Id", tournament.TournamentPhaseId);
            return View(tournament);
        }

        // GET: Tournaments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournament = await _context.Tournament
                .Include(t => t.District)
                .Include(t => t.MatchLength)
                .Include(t => t.MatchReporting)
                .Include(t => t.MatchTime)
                .Include(t => t.RefereeLevel)
                .Include(t => t.TableSystem)
                .Include(t => t.TeamNotification)
                .Include(t => t.TeamOfficial)
                .Include(t => t.TeamRegistration)
                .Include(t => t.TournamentPhase)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tournament == null)
            {
                return NotFound();
            }

            return View(tournament);
        }

        // POST: Tournaments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tournament = await _context.Tournament.FindAsync(id);
            _context.Tournament.Remove(tournament);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TournamentExists(int id)
        {
            return _context.Tournament.Any(e => e.Id == id);
        }
    }
}
