using FronEnd.API.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FronEnd.API.Controllers
{
    public class HistorialFacturaController : Controller
    {
        ClienteServices clienteS = new ClienteServices();
        EmpleadoServices empleadoS = new EmpleadoServices();

        // GET: HistorialFacturas
        public async Task<IActionResult> Index()
        {
            List<Models.HistorialFactura> aux = new List<Models.HistorialFactura>();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(Program.baseurl);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/HistorialFactura");

                if (res.IsSuccessStatusCode)
                {
                    var auxres = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<List<Models.HistorialFactura>>(auxres);
                }
            }
            return View(aux);
        }

        // GET: HistorialFacturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialFactura = GetById(id);

            if (historialFactura == null)
            {
                return NotFound();
            }

            return View(historialFactura);
        }

        // GET: HistorialFacturas/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(clienteS.GetAll(), "IdCliente", "NombreCliente");
            ViewData["IdEmpleado"] = new SelectList(empleadoS.GetAll(), "IdEmpleado", "NombreEmpleado");
            return View();
        }

        // POST: HistorialFacturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFactura,CodigoFactura,IdCliente,IdEmpleado,FechaFactura,TotalFactura")] Models.HistorialFactura historialFactura)
        {
            if (ModelState.IsValid)
            {
                using (var cl = new HttpClient())
                {
                    cl.BaseAddress = new Uri(Program.baseurl);
                    var content = JsonConvert.SerializeObject(historialFactura);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    var postTask = cl.PostAsync("api/historialFactura", byteContent).Result;

                    if (postTask.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            ViewData["IdCliente"] = new SelectList(GetAll(), "IdCliente", "Canton", historialFactura.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(GetAll(), "IdEmpleado", "ApellidoEmpleado", historialFactura.IdEmpleado);
            return View(historialFactura);
        }

        // GET: HistorialFacturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialFactura = GetById(id);
            if (historialFactura == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(clienteS.GetAll(), "IdCliente", "NombreCliente", historialFactura.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(empleadoS.GetAll(), "IdEmpleado", "NombreEmpleado", historialFactura.IdEmpleado);
            return View(historialFactura);
        }

        // POST: HistorialFacturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFactura,CodigoFactura,IdCliente,IdEmpleado,FechaFactura,TotalFactura")] Models.HistorialFactura historialFactura)
        {
            if (id != historialFactura.IdFactura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    using (var cl = new HttpClient())
                    {
                        cl.BaseAddress = new Uri(Program.baseurl);
                        var content = JsonConvert.SerializeObject(historialFactura);
                        var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                        var byteContent = new ByteArrayContent(buffer);
                        byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                        var postTask = cl.PutAsync("api/historialFactura/" + id, byteContent).Result;

                        if (postTask.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index");
                        }
                    }
                }
                catch (Exception)
                {
                    var aux2 = GetById(id);
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
            ViewData["IdCliente"] = new SelectList(GetAll(), "IdCliente", "Canton", historialFactura.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(GetAll(), "IdEmpleado", "ApellidoEmpleado", historialFactura.IdEmpleado);
            return View(historialFactura);
        }

        // GET: HistorialFacturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historialFactura = GetById(id);
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
            var producto = GetById(id);
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(Program.baseurl);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.DeleteAsync("api/historialFactura/" + id);

                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction(nameof(Index));
        }

        //private bool HistorialFacturaExists(int id)
        //{
        //    return _context.HistorialFactura.Any(e => e.IdFactura == id);
        //}
        public Models.HistorialFactura GetById(int? id)
        {
            Models.HistorialFactura aux = new Models.HistorialFactura();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(Program.baseurl);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                //HttpResponseMessage res = await cl.GetAsync("api/Pais/5?"+id);
                HttpResponseMessage res = cl.GetAsync("api/HistorialFactura/" + id).Result;

                if (res.IsSuccessStatusCode)
                {
                    var auxres = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<Models.HistorialFactura>(auxres);
                }
            }
            return aux;
        }

        public List<Models.HistorialFactura> GetAll()
        {
            List<Models.HistorialFactura> aux = new List<Models.HistorialFactura>();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(Program.baseurl);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = cl.GetAsync("api/GroupInvitations").Result;

                if (res.IsSuccessStatusCode)
                {
                    var auxres = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<List<Models.HistorialFactura>>(auxres);
                }
            }
            return aux;
        }

        public async Task<List<Models.HistorialFactura>> GetAllAsync()
        {
            List<Models.HistorialFactura> aux = new List<Models.HistorialFactura>();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(Program.baseurl);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/HistorialFactura");

                if (res.IsSuccessStatusCode)
                {
                    var auxres = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<List<Models.HistorialFactura>>(auxres);
                }
            }
            return aux;
        }
    }
}
