﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FrontEnd.W.Models;

namespace FrontEnd.W.Controllers
{
    public class ProductoesController : Controller
    {
        private readonly Proyecto_PrograWebAvanzadaContext _context;

        public ProductoesController(Proyecto_PrograWebAvanzadaContext context)
        {
            _context = context;
        }

        // GET: Productoes
        public async Task<IActionResult> Index()
        {
            var proyecto_PrograWebAvanzadaContext = _context.Producto.Include(p => p.IdFamiliaProductoNavigation).Include(p => p.IdProveedorNavigation);
            return View(await proyecto_PrograWebAvanzadaContext.ToListAsync());
        }

        // GET: Productoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.IdFamiliaProductoNavigation)
                .Include(p => p.IdProveedorNavigation)
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productoes/Create
        public IActionResult Create()
        {
            ViewData["IdFamiliaProducto"] = new SelectList(_context.FamiliaProducto, "IdFamiliaProducto", "NombreFamiliaProducto");
            ViewData["IdProveedor"] = new SelectList(_context.Proveedor, "IdProveedor", "Canton");
            return View();
        }

        // POST: Productoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProducto,CodigoBarras,FechaIngreso,NombreProducto,CantidadProducto,PrecioUnitario,PrecioVenta,IdFamiliaProducto,IdProveedor")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdFamiliaProducto"] = new SelectList(_context.FamiliaProducto, "IdFamiliaProducto", "NombreFamiliaProducto", producto.IdFamiliaProducto);
            ViewData["IdProveedor"] = new SelectList(_context.Proveedor, "IdProveedor", "Canton", producto.IdProveedor);
            return View(producto);
        }

        // GET: Productoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["IdFamiliaProducto"] = new SelectList(_context.FamiliaProducto, "IdFamiliaProducto", "NombreFamiliaProducto", producto.IdFamiliaProducto);
            ViewData["IdProveedor"] = new SelectList(_context.Proveedor, "IdProveedor", "Canton", producto.IdProveedor);
            return View(producto);
        }

        // POST: Productoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProducto,CodigoBarras,FechaIngreso,NombreProducto,CantidadProducto,PrecioUnitario,PrecioVenta,IdFamiliaProducto,IdProveedor")] Producto producto)
        {
            if (id != producto.IdProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.IdProducto))
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
            ViewData["IdFamiliaProducto"] = new SelectList(_context.FamiliaProducto, "IdFamiliaProducto", "NombreFamiliaProducto", producto.IdFamiliaProducto);
            ViewData["IdProveedor"] = new SelectList(_context.Proveedor, "IdProveedor", "Canton", producto.IdProveedor);
            return View(producto);
        }

        // GET: Productoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.IdFamiliaProductoNavigation)
                .Include(p => p.IdProveedorNavigation)
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.IdProducto == id);
        }
    }
}
