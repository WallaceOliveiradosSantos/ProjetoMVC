using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class MotoristumController : Controller
    {
        private readonly DbSistema2Context _context;

        public MotoristumController(DbSistema2Context context)
        {
            _context = context;
        }

        // GET: Motoristum
        public async Task<IActionResult> Index()
        {
            return View(await _context.Motorista.ToListAsync());
        }

        // GET: Motoristum/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motoristum = await _context.Motorista
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (motoristum == null)
            {
                return NotFound();
            }

            return View(motoristum);
        }

        // GET: Motoristum/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Motoristum/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nome,Cpf,Cnh,Telefone")] Motoristum motoristum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motoristum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motoristum);
        }

        // GET: Motoristum/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motoristum = await _context.Motorista.FindAsync(id);
            if (motoristum == null)
            {
                return NotFound();
            }
            return View(motoristum);
        }

        // POST: Motoristum/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Codigo,Nome,Cpf,Cnh,Telefone")] Motoristum motoristum)
        {
            if (id != motoristum.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motoristum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotoristumExists(motoristum.Codigo))
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
            return View(motoristum);
        }

        // GET: Motoristum/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motoristum = await _context.Motorista
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (motoristum == null)
            {
                return NotFound();
            }

            return View(motoristum);
        }

        // POST: Motoristum/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motoristum = await _context.Motorista.FindAsync(id);
            if (motoristum != null)
            {
                _context.Motorista.Remove(motoristum);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotoristumExists(int id)
        {
            return _context.Motorista.Any(e => e.Codigo == id);
        }
    }
}
