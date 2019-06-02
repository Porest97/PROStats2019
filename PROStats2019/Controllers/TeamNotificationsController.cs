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
    public class TeamNotificationsController : Controller
    {
        private readonly PROStats2019Context _context;

        public TeamNotificationsController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: TeamNotifications
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeamNotification.ToListAsync());
        }

        // GET: TeamNotifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamNotification = await _context.TeamNotification
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamNotification == null)
            {
                return NotFound();
            }

            return View(teamNotification);
        }

        // GET: TeamNotifications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeamNotifications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TeamNotificationName")] TeamNotification teamNotification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamNotification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamNotification);
        }

        // GET: TeamNotifications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamNotification = await _context.TeamNotification.FindAsync(id);
            if (teamNotification == null)
            {
                return NotFound();
            }
            return View(teamNotification);
        }

        // POST: TeamNotifications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TeamNotificationName")] TeamNotification teamNotification)
        {
            if (id != teamNotification.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teamNotification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamNotificationExists(teamNotification.Id))
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
            return View(teamNotification);
        }

        // GET: TeamNotifications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamNotification = await _context.TeamNotification
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamNotification == null)
            {
                return NotFound();
            }

            return View(teamNotification);
        }

        // POST: TeamNotifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamNotification = await _context.TeamNotification.FindAsync(id);
            _context.TeamNotification.Remove(teamNotification);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamNotificationExists(int id)
        {
            return _context.TeamNotification.Any(e => e.Id == id);
        }
    }
}
