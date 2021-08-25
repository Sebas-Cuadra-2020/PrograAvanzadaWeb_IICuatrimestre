using FronEnd.API.Servicios;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FronEnd.API.Controllers
{
    public class RolEmpleadoController : Controller
    {
        RolEmpleadoServices rolEmpleados = new RolEmpleadoServices();

        // GET: RolEmpleadoes
        public async Task<IActionResult> Index()
        {
            List<Models.RolEmpleado> aux = new List<Models.RolEmpleado>();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(Program.baseurl);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/RolEmpleado");

                if (res.IsSuccessStatusCode)
                {
                    var auxres = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<List<Models.RolEmpleado>>(auxres);
                }
            }
            return View(aux);
        }

        // GET: RolEmpleadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rolEmpleado = rolEmpleados.GetById(id);
            if (rolEmpleado == null)
            {
                return NotFound();
            }

            return View(rolEmpleado);
        }

        // GET: RolEmpleadoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RolEmpleadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRol,NombreRol")] Models.RolEmpleado rolEmpleado)
        {
            if (ModelState.IsValid)
            {
                if (rolEmpleados.Create(rolEmpleado))
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(rolEmpleado);
        }

        // GET: RolEmpleadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rolEmpleado = rolEmpleados.GetById(id);
            if (rolEmpleado == null)
            {
                return NotFound();
            }
            return View(rolEmpleado);
        }

        // POST: RolEmpleadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRol,NombreRol")] Models.RolEmpleado rolEmpleado)
        {
            if (id != rolEmpleado.IdRol)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (rolEmpleados.Updated(id, rolEmpleado))
                    {
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception)
                {
                    var aux2 = rolEmpleados.GetById(id);
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
            return View(rolEmpleado);
        }

        // GET: RolEmpleadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rolEmpleado = rolEmpleados.GetById(id);
            if (rolEmpleado == null)
            {
                return NotFound();
            }

            return View(rolEmpleado);
        }

        // POST: RolEmpleadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await rolEmpleados.DeleteByIdAsync(id))
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction(nameof(Index));
        }

        //private bool RolEmpleadoExists(int id)
        //{
        //    return _context.RolEmpleado.Any(e => e.IdRol == id);
        //}
    }
}
