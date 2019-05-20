using System;
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
    public class PeopleController : Controller
    {
        private readonly PROStats2019Context _context;

        public PeopleController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            var pROStats2019Context = _context.Person.Include(p => p.Club).Include(p => p.Coach).Include(p => p.Player).Include(p => p.Referee).Include(p => p.RefereeCategory).Include(p => p.RefereeCategoryType).Include(p => p.RefereeDistrict).Include(p => p.RefereeType).Include(p => p.Staff);
            return View(await pROStats2019Context.ToListAsync());
        }

        // GET: People/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .Include(p => p.Club)
                .Include(p => p.Coach)
                .Include(p => p.Player)
                .Include(p => p.Referee)
                .Include(p => p.RefereeCategory)
                .Include(p => p.RefereeCategoryType)
                .Include(p => p.RefereeDistrict)
                .Include(p => p.RefereeType)
                .Include(p => p.Staff)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: People/Create
        public IActionResult Create()
        {
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName");
            ViewData["CoachId"] = new SelectList(_context.Coach, "Id", "Status");
            ViewData["PlayerId"] = new SelectList(_context.Player, "Id", "Status");
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Status");
            ViewData["RefereeCategoryId"] = new SelectList(_context.RefereeCategory, "Id", "RefereeCategoryName");
            ViewData["RefereeCategoryTypeId"] = new SelectList(_context.RefereeCategoryType, "Id", "RefereeCategoryTypeName");
            ViewData["RefereeDistrictId"] = new SelectList(_context.RefereeDistrict, "Id", "RefereeDistrictName");
            ViewData["RefereeTypeId"] = new SelectList(_context.RefereeType, "Id", "RefereeTypeName");
            ViewData["StaffId"] = new SelectList(_context.Staff, "Id", "Status");
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,StreetAddress,ZipCode,County,Country,Ssn,PhoneNumber,Email,ClubId,RefereeNumber,RefereeTypeId,RefereeCategoryId,RefereeCategoryTypeId,RefereeDistrictId,RefereeId,CoachId,PlayerId,StaffId")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", person.ClubId);
            ViewData["CoachId"] = new SelectList(_context.Coach, "Id", "Status", person.CoachId);
            ViewData["PlayerId"] = new SelectList(_context.Player, "Id", "Status", person.PlayerId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Status", person.RefereeId);
            ViewData["RefereeCategoryId"] = new SelectList(_context.RefereeCategory, "Id", "RefereeCategoryName", person.RefereeCategoryId);
            ViewData["RefereeCategoryTypeId"] = new SelectList(_context.RefereeCategoryType, "Id", "RefereeCategoryTypeName", person.RefereeCategoryTypeId);
            ViewData["RefereeDistrictId"] = new SelectList(_context.RefereeDistrict, "Id", "RefereeDistrictName", person.RefereeDistrictId);
            ViewData["RefereeTypeId"] = new SelectList(_context.RefereeType, "Id", "RefereeTypeName", person.RefereeTypeId);
            ViewData["StaffId"] = new SelectList(_context.Staff, "Id", "Status", person.StaffId);
            return View(person);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", person.ClubId);
            ViewData["CoachId"] = new SelectList(_context.Coach, "Id", "Status", person.CoachId);
            ViewData["PlayerId"] = new SelectList(_context.Player, "Id", "Status", person.PlayerId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Status", person.RefereeId);
            ViewData["RefereeCategoryId"] = new SelectList(_context.RefereeCategory, "Id", "RefereeCategoryName", person.RefereeCategoryId);
            ViewData["RefereeCategoryTypeId"] = new SelectList(_context.RefereeCategoryType, "Id", "RefereeCategoryTypeName", person.RefereeCategoryTypeId);
            ViewData["RefereeDistrictId"] = new SelectList(_context.RefereeDistrict, "Id", "RefereeDistrictName", person.RefereeDistrictId);
            ViewData["RefereeTypeId"] = new SelectList(_context.RefereeType, "Id", "RefereeTypeName", person.RefereeTypeId);
            ViewData["StaffId"] = new SelectList(_context.Staff, "Id", "Status", person.StaffId);
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,StreetAddress,ZipCode,County,Country,Ssn,PhoneNumber,Email,ClubId,RefereeNumber,RefereeTypeId,RefereeCategoryId,RefereeCategoryTypeId,RefereeDistrictId,RefereeId,CoachId,PlayerId,StaffId")] Person person)
        {
            if (id != person.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.Id))
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
            ViewData["ClubId"] = new SelectList(_context.Club, "Id", "ClubName", person.ClubId);
            ViewData["CoachId"] = new SelectList(_context.Coach, "Id", "Status", person.CoachId);
            ViewData["PlayerId"] = new SelectList(_context.Player, "Id", "Status", person.PlayerId);
            ViewData["RefereeId"] = new SelectList(_context.Referee, "Id", "Status", person.RefereeId);
            ViewData["RefereeCategoryId"] = new SelectList(_context.RefereeCategory, "Id", "RefereeCategoryName", person.RefereeCategoryId);
            ViewData["RefereeCategoryTypeId"] = new SelectList(_context.RefereeCategoryType, "Id", "RefereeCategoryTypeName", person.RefereeCategoryTypeId);
            ViewData["RefereeDistrictId"] = new SelectList(_context.RefereeDistrict, "Id", "RefereeDistrictName", person.RefereeDistrictId);
            ViewData["RefereeTypeId"] = new SelectList(_context.RefereeType, "Id", "RefereeTypeName", person.RefereeTypeId);
            ViewData["StaffId"] = new SelectList(_context.Staff, "Id", "Status", person.StaffId);
            return View(person);
        }

        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .Include(p => p.Club)
                .Include(p => p.Coach)
                .Include(p => p.Player)
                .Include(p => p.Referee)
                .Include(p => p.RefereeCategory)
                .Include(p => p.RefereeCategoryType)
                .Include(p => p.RefereeDistrict)
                .Include(p => p.RefereeType)
                .Include(p => p.Staff)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.Person.FindAsync(id);
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.Id == id);
        }
    }
}
