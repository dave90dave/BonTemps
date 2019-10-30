using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BonTemps.Data;
using BonTemps.Models;

namespace BonTemps.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class AllergensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AllergensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employee/Allergens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Allergen.ToListAsync());
        }

        // GET: Employee/Allergens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allergen = await _context.Allergen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (allergen == null)
            {
                return NotFound();
            }

            return View(allergen);
        }

        // GET: Employee/Allergens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Allergens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ImagePath")] Allergen allergen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(allergen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(allergen);
        }

        // GET: Employee/Allergens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allergen = await _context.Allergen.FindAsync(id);
            if (allergen == null)
            {
                return NotFound();
            }
            return View(allergen);
        }

        // POST: Employee/Allergens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ImagePath")] Allergen allergen)
        {
            if (id != allergen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(allergen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AllergenExists(allergen.Id))
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
            return View(allergen);
        }

        // GET: Employee/Allergens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allergen = await _context.Allergen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (allergen == null)
            {
                return NotFound();
            }

            return View(allergen);
        }

        // POST: Employee/Allergens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var allergen = await _context.Allergen.FindAsync(id);
            _context.Allergen.Remove(allergen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AllergenExists(int id)
        {
            return _context.Allergen.Any(e => e.Id == id);
        }
    }
}
