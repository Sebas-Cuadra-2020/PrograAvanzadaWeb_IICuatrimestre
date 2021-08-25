using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FrontEnd.W.Models;

namespace FrontEnd.W.Controllers
{
    public class FamiliaProductoesController : Controller
    {
        private readonly Proyecto_PrograWebAvanzadaContext _context;

        public FamiliaProductoesController(Proyecto_PrograWebAvanzadaContext context)
        {
            _context = context;
        }

        // GET: FamiliaProductoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.FamiliaProducto.ToListAsync());
        }

        // GET: FamiliaProductoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiaProducto = await _context.FamiliaProducto
                .FirstOrDefaultAsync(m => m.IdFamiliaProducto == id);
            if (familiaProducto == null)
            {
                return NotFound();
            }

            return View(familiaProducto);
        }

        // GET: FamiliaProductoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FamiliaProductoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFamiliaProducto,NombreFamiliaProducto,CodigoCabys")] FamiliaProducto familiaProducto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(familiaProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(familiaProducto);
        }

        // GET: FamiliaProductoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiaProducto = await _context.FamiliaProducto.FindAsync(id);
            if (familiaProducto == null)
            {
                return NotFound();
            }
            return View(familiaProducto);
        }

        // POST: FamiliaProductoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFamiliaProducto,NombreFamiliaProducto,CodigoCabys")] FamiliaProducto familiaProducto)
        {
            if (id != familiaProducto.IdFamiliaProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(familiaProducto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FamiliaProductoExists(familiaProducto.IdFamiliaProducto))
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
            return View(familiaProducto);
        }

        // GET: FamiliaProductoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiaProducto = await _context.FamiliaProducto
                .FirstOrDefaultAsync(m => m.IdFamiliaProducto == id);
            if (familiaProducto == null)
            {
                return NotFound();
            }

            return View(familiaProducto);
        }

        // POST: FamiliaProductoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var familiaProducto = await _context.FamiliaProducto.FindAsync(id);
            _context.FamiliaProducto.Remove(familiaProducto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FamiliaProductoExists(int id)
        {
            return _context.FamiliaProducto.Any(e => e.IdFamiliaProducto == id);
        }
    }
}
