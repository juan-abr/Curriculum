using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Curriculum.Models;
using Curriculum.Data;
using Microsoft.AspNetCore.Authorization;

namespace Curriculum.Controllers
{
    public class SyllabiController : Controller
    {
        private readonly CurriculumContext _context;

        public SyllabiController(CurriculumContext context)
        {
            _context = context;
        }

        // GET: Syllabi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Syllabus.ToListAsync());
        }

        public async Task<IActionResult> Archive(string searchString)
        {
            var syllabi = from s in _context.Syllabus select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                syllabi = syllabi.Where(s => s.Rank.Contains(searchString));
            }
            
            return View(await _context.Syllabus.OrderBy(x => x.Rank).ToListAsync());
        }

        // GET: Syllabi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var syllabus = await _context.Syllabus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (syllabus == null)
            {
                return NotFound();
            }

            return View(syllabus);
        }

        // GET: Syllabi/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Syllabi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rank,Media")] Syllabus syllabus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(syllabus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(syllabus);
        }

        // GET: Syllabi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var syllabus = await _context.Syllabus.FindAsync(id);
            if (syllabus == null)
            {
                return NotFound();
            }
            return View(syllabus);
        }

        // POST: Syllabi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Rank,Media")] Syllabus syllabus)
        {
            if (id != syllabus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(syllabus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SyllabusExists(syllabus.Id))
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
            return View(syllabus);
        }

        // GET: Syllabi/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var syllabus = await _context.Syllabus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (syllabus == null)
            {
                return NotFound();
            }

            return View(syllabus);
        }

        // POST: Syllabi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var syllabus = await _context.Syllabus.FindAsync(id);
            _context.Syllabus.Remove(syllabus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SyllabusExists(int id)
        {
            return _context.Syllabus.Any(e => e.Id == id);
        }
    }
}
