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
    public class HistorialFacturasController : Controller
    {
        private readonly Proyecto_PrograWebAvanzadaContext _context;

        public HistorialFacturasController(Proyecto_PrograWebAvanzadaContext context)
        {
            _context = context;
        }

        // GET: HistorialFacturas
        public async Task<IActionResult> Index()
        {
            var proyecto_PrograWebAvanzadaContext = _context.HistorialFactura.Include(h => h.IdClienteNavigation).Include(h => h.IdEmpleadoNavigation);
            return View(await proyecto_PrograWebAvanzadaContext.ToListAsync());
        }

        // GET: HistorialFacturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialFactura = await _context.HistorialFactura
                .Include(h => h.IdClienteNavigation)
                .Include(h => h.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.IdFactura == id);
            if (historialFactura == null)
            {
                return NotFound();
            }

            return View(historialFactura);
        }

        // GET: HistorialFacturas/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Canton");
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "ApellidoEmpleado");
            return View();
        }

        // POST: HistorialFacturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFactura,CodigoFactura,IdCliente,IdEmpleado,FechaFactura,TotalFactura")] HistorialFactura historialFactura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(historialFactura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Canton", historialFactura.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "ApellidoEmpleado", historialFactura.IdEmpleado);
            return View(historialFactura);
        }

        // GET: HistorialFacturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialFactura = await _context.HistorialFactura.FindAsync(id);
            if (historialFactura == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Canton", historialFactura.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "ApellidoEmpleado", historialFactura.IdEmpleado);
            return View(historialFactura);
        }

        // POST: HistorialFacturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFactura,CodigoFactura,IdCliente,IdEmpleado,FechaFactura,TotalFactura")] HistorialFactura historialFactura)
        {
            if (id != historialFactura.IdFactura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historialFactura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistorialFacturaExists(historialFactura.IdFactura))
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
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Canton", historialFactura.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "ApellidoEmpleado", historialFactura.IdEmpleado);
            return View(historialFactura);
        }

        // GET: HistorialFacturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialFactura = await _context.HistorialFactura
                .Include(h => h.IdClienteNavigation)
                .Include(h => h.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.IdFactura == id);
            if (historialFactura == null)
            {
                return NotFound();
            }

            return View(historialFactura);
        }

        // POST: HistorialFacturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historialFactura = await _context.HistorialFactura.FindAsync(id);
            _context.HistorialFactura.Remove(historialFactura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistorialFacturaExists(int id)
        {
            return _context.HistorialFactura.Any(e => e.IdFactura == id);
        }
    }
}
