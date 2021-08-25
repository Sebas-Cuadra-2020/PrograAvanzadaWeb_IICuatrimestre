using DAL.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data = DAL.DO.Objects;
using DAL.EF;
using AutoMapper;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialFacturaController : ControllerBase
    {
        private readonly SolutionDbContext _context;

        private readonly IMapper _mapper;

        public HistorialFacturaController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/HistorialFacturas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.HistorialFactura>>> GetHistorialFactura()
        {
            var res = await new BS.HistorialFactura(_context).GetAllWithAsync();

            var mapaux = _mapper.Map<IEnumerable<data.HistorialFactura>, IEnumerable<DataModels.HistorialFactura>>(res).ToList(); //izquierda dato que viene, derecha el dato que va a terminar siendo

            return mapaux;
        }

        // GET: api/HistorialFacturas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.HistorialFactura>> GetHistorialFactura(int id)
        {
            var historialFactura = new BS.HistorialFactura(_context).GetOneByID(id);

            var mapaux = _mapper.Map<data.HistorialFactura, DataModels.HistorialFactura>(historialFactura);

            if (historialFactura == null)
            {
                return NotFound();
            }

            return mapaux;
        }

        // PUT: api/HistorialFacturas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistorialFactura(int id, DataModels.HistorialFactura historialFactura)
        {
            if (id != historialFactura.IdFactura)
            {
                return BadRequest();
            }

            try
            {
                var mapaux = _mapper.Map<DataModels.HistorialFactura, data.HistorialFactura>(historialFactura);
                new BS.HistorialFactura(_context).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!HistorialFacturaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/HistorialFacturas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DataModels.HistorialFactura>> PostHistorialFactura(DataModels.HistorialFactura historialFactura)
        {
            var mapaux = _mapper.Map<DataModels.HistorialFactura, data.HistorialFactura>(historialFactura);
            new BS.HistorialFactura(_context).Insert(mapaux);

            return CreatedAtAction("GetHistorialFactura", new { id = historialFactura.IdFactura }, historialFactura);
        }

        // DELETE: api/HistorialFacturas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.HistorialFactura>> DeleteHistorialFactura(int id)
        {
            var historialFactura = new BS.HistorialFactura(_context).GetOneByID(id);
            if (historialFactura == null)
            {
                return NotFound();
            }


            new BS.HistorialFactura(_context).Delete(historialFactura);
            var mapaux = _mapper.Map<data.HistorialFactura, DataModels.HistorialFactura>(historialFactura);

            return mapaux;
        }

        private bool HistorialFacturaExists(int id)
        {
            return _context.HistorialFactura.Any(e => e.IdFactura == id);
        }
    }
}
