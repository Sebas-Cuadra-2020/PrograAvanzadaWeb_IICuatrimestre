using FronEnd.API.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronEnd.API.Controllers
{
    public class FamiliaProductoController : Controller
    {
        FamiliaProductoServices servicios = new FamiliaProductoServices();
    
        public async Task<IActionResult> Index()
        {
            return View(servicios.GetAllAsync());
        }

        // GET: FamiliaProductoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familiaProducto = servicios.GetById(id);
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
        public async Task<IActionResult> Create([Bind("IdFamiliaProducto,NombreFamiliaProducto,CodigoCabys")] Models.FamiliaProducto familiaProducto)
        {
            if (ModelState.IsValid)
            {
                if (servicios.Create(familiaProducto))
                {
                    return RedirectToAction(nameof(Index));
                }
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

            var familiaProducto = servicios.GetById(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("IdFamiliaProducto,NombreFamiliaProducto,CodigoCabys")] Models.FamiliaProducto familiaProducto)
        {
            if (id != familiaProducto.IdFamiliaProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (servicios.Updated(id, familiaProducto))
                    {
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception)
                {
                    var aux2 = servicios.GetById(id);
                    if (aux2 == null)
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

            var familiaProducto = servicios.GetById(id);

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
            if (await servicios.DeleteByIdAsync(id))
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction(nameof(Index));
        }
    }

        //private bool FamiliaProductoExists(int id)
        //{
        //    return _context.FamiliaProducto.Any(e => e.IdFamiliaProducto == id);
        //}
}

