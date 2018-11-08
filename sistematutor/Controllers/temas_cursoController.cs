using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sistematutor.Models;

namespace sistematutor.Controllers
{
    public class temas_cursoController : Controller
    {
        private readonly sistematutorContext _context;

        public temas_cursoController(sistematutorContext context)
        {
            _context = context;
        }

        // GET: temas_curso
        public async Task<IActionResult> Index()
        {
            return View(await _context.temas_curso.ToListAsync());
        }

        // GET: temas_curso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var temas_curso = await _context.temas_curso
                .SingleOrDefaultAsync(m => m.id_tema == id);
            if (temas_curso == null)
            {
                return NotFound();
            }

            return View(temas_curso);
        }

        // GET: temas_curso/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: temas_curso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_tema,nombre_tema,id_curso")] temas_curso temas_curso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(temas_curso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(temas_curso);
        }

        // GET: temas_curso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var temas_curso = await _context.temas_curso.SingleOrDefaultAsync(m => m.id_tema == id);
            if (temas_curso == null)
            {
                return NotFound();
            }
            return View(temas_curso);
        }

        // POST: temas_curso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_tema,nombre_tema,id_curso")] temas_curso temas_curso)
        {
            if (id != temas_curso.id_tema)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(temas_curso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!temas_cursoExists(temas_curso.id_tema))
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
            return View(temas_curso);
        }

        // GET: temas_curso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var temas_curso = await _context.temas_curso
                .SingleOrDefaultAsync(m => m.id_tema == id);
            if (temas_curso == null)
            {
                return NotFound();
            }

            return View(temas_curso);
        }

        // POST: temas_curso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var temas_curso = await _context.temas_curso.SingleOrDefaultAsync(m => m.id_tema == id);
            _context.temas_curso.Remove(temas_curso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool temas_cursoExists(int id)
        {
            return _context.temas_curso.Any(e => e.id_tema == id);
        }
    }
}
