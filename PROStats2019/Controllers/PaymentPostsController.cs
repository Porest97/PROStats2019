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
    public class PaymentPostsController : Controller
    {
        private readonly PROStats2019Context _context;

        public PaymentPostsController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: PaymentPosts
        public async Task<IActionResult> Index()
        {
            var pROStats2019Context = _context.PaymentPost.Include(p => p.Game).Include(p => p.Referee1).Include(p => p.Referee2).Include(p => p.Referee3).Include(p => p.Referee4);
            return View(await pROStats2019Context.ToListAsync());
        }

        // GET: PaymentPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentPost = await _context.PaymentPost
                .Include(p => p.Game)
                .Include(p => p.Referee1)
                .Include(p => p.Referee2)
                .Include(p => p.Referee3)
                .Include(p => p.Referee4)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentPost == null)
            {
                return NotFound();
            }

            return View(paymentPost);
        }

        // GET: PaymentPosts/Create
        public IActionResult Create()
        {
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "GameName");
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName");
            return View();
        }

        // POST: PaymentPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GameId,PersonId,PersonId1,PersonId2,PersonId3,FeeHD1,AlowenceHD1,TravelDistanceHD1,TravelCostHD1,LateMatchStartHD1,TotalPaymentHD1,FeeHD2,AlowenceHD2,TravelDistanceHD2,TravelCostHD2,LateMatchStartHD2,TotalPaymentHD2,FeeLD1,AlowenceLD1,TravelDistanceLD1,TravelCostLD1,LateMatchStartLD1,TotalPaymentLD1,FeeLD2,AlowenceLD2,TravelDistanceLD2,TravelCostLD2,LateMatchStartLD2,TotalPaymentLD2")] PaymentPost paymentPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "GameName", paymentPost.GameId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId3);
            return View(paymentPost);
        }

        // GET: PaymentPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentPost = await _context.PaymentPost.FindAsync(id);
            if (paymentPost == null)
            {
                return NotFound();
            }
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "GameName", paymentPost.GameId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId3);
            return View(paymentPost);
        }

        // POST: PaymentPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GameId,PersonId,PersonId1,PersonId2,PersonId3,FeeHD1,AlowenceHD1,TravelDistanceHD1,TravelCostHD1,LateMatchStartHD1,TotalPaymentHD1,FeeHD2,AlowenceHD2,TravelDistanceHD2,TravelCostHD2,LateMatchStartHD2,TotalPaymentHD2,FeeLD1,AlowenceLD1,TravelDistanceLD1,TravelCostLD1,LateMatchStartLD1,TotalPaymentLD1,FeeLD2,AlowenceLD2,TravelDistanceLD2,TravelCostLD2,LateMatchStartLD2,TotalPaymentLD2")] PaymentPost paymentPost)
        {
            if (id != paymentPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentPostExists(paymentPost.Id))
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
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "GameName", paymentPost.GameId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "FullName", paymentPost.PersonId3);
            return View(paymentPost);
        }

        // GET: PaymentPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentPost = await _context.PaymentPost
                .Include(p => p.Game)
                .Include(p => p.Referee1)
                .Include(p => p.Referee2)
                .Include(p => p.Referee3)
                .Include(p => p.Referee4)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentPost == null)
            {
                return NotFound();
            }

            return View(paymentPost);
        }

        // POST: PaymentPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paymentPost = await _context.PaymentPost.FindAsync(id);
            _context.PaymentPost.Remove(paymentPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentPostExists(int id)
        {
            return _context.PaymentPost.Any(e => e.Id == id);
        }
    }
}
