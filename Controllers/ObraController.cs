using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ActivityManagement.Models;
using ActivityManagement.Services;

namespace ActivityManagement.Controllers
{
    public class ObraController : Controller
    {
        private readonly AmDbContext _context;

        public ObraController(AmDbContext context)
        {
            _context = context;
        }

        // GET: Obra
        public async Task<IActionResult> Index()
        {

            var resultSet = _context.VwProjetos.FromSqlRaw("SELECT * FROM VW_PAINEL_PROJETOS").ToList();
            ViewBag.oPainelProjetos = resultSet;

            return _context.Obra != null ?
                        View(await _context.Obra.ToListAsync()) :
                        Problem("Entity set 'AmDbContext.Obra'  is null.");
        }

        // GET: Obra/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Obra == null)
            {
                return NotFound();
            }

            var obra = await _context.Obra
                .FirstOrDefaultAsync(m => m.Id == id);
            if (obra == null)
            {
                return NotFound();
            }

            return View(obra);
        }

        // GET: Obra/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Obra/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Inicio,Previsao,Termino,IdentificacaoDoProjeto,ChefeDaObra,Status,UF,Municipio")] Obra obra)
        {
            _context.Add(obra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Obra/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Obra == null)
            {
                return NotFound();
            }

            var obra = await _context.Obra.FindAsync(id);
            if (obra == null)
            {
                return NotFound();
            }
            return View(obra);
        }

        // POST: Obra/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Inicio,Previsao,Termino,ResponsavelGeral,ChefeDaObra,Status,UF,Municipio")] Obra obra)
        {
            if (id != obra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(obra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObraExists(obra.Id))
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
            return View(obra);
        }

        // GET: Obra/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Obra == null)
            {
                return NotFound();
            }

            var obra = await _context.Obra
                .FirstOrDefaultAsync(m => m.Id == id);
            if (obra == null)
            {
                return NotFound();
            }

            return View(obra);
        }

        // POST: Obra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Obra == null)
            {
                return Problem("Entity set 'AmDbContext.Obra'  is null.");
            }
            var obra = await _context.Obra.FindAsync(id);
            if (obra != null)
            {
                _context.Obra.Remove(obra);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ObraExists(int id)
        {
            return (_context.Obra?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
