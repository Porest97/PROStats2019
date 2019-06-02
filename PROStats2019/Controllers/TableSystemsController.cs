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
    public class TableSystemsController : Controller
    {
        private readonly PROStats2019Context _context;

        public TableSystemsController(PROStats2019Context context)
        {
            _context = context;
        }

        // GET: TableSystems
        public async Task<IActionResult> Index()
        {
            return View(await _context.TableSystem.ToListAsync());
        }

        // GET: TableSystems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableSystem = await _context.TableSystem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableSystem == null)
            {
                return NotFound();
            }

            return View(tableSystem);
        }

        // GET: TableSystems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TableSystems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TableSystemName")] TableSystem tableSystem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableSystem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tableSystem);
        }

        // GET: TableSystems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableSystem = await _context.TableSystem.FindAsync(id);
            if (tableSystem == null)
            {
                return NotFound();
            }
            return View(tableSystem);
        }

        // POST: TableSystems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TableSystemName")] TableSystem tableSystem)
        {
            if (id != tableSystem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableSystem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableSystemExists(tableSystem.Id))
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
            return View(tableSystem);
        }

        // GET: TableSystems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableSystem = await _context.TableSystem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableSystem == null)
            {
                return NotFound();
            }

            return View(tableSystem);
        }

        // POST: TableSystems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableSystem = await _context.TableSystem.FindAsync(id);
            _context.TableSystem.Remove(tableSystem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TableSystemExists(int id)
        {
            return _context.TableSystem.Any(e => e.Id == id);
        }
    }
}
