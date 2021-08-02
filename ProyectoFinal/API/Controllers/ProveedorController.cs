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
    public class ProveedorController : ControllerBase
    {
        private readonly SolutionDbContext _context;

        private readonly IMapper _mapper;

        public ProveedorController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Proveedors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.Proveedor>>> GetProveedor()
        {
            var res =  new BS.Proveedor(_context).GetAll();

            var mapaux = _mapper.Map<IEnumerable<data.Proveedor>, IEnumerable<DataModels.Proveedor>>(res).ToList(); 


            return mapaux;
        }

        // GET: api/Proveedors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.Proveedor>> GetProveedor(int id)
        {
            var proveedor = new BS.Proveedor(_context).GetOneByID(id);

            var mapaux = _mapper.Map<data.Proveedor, DataModels.Proveedor>(proveedor);

            if (proveedor == null)
            {
                return NotFound();
            }

            return mapaux;
        }

        // PUT: api/Proveedors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProveedor(int id, DataModels.Proveedor proveedor)
        {
            if (id != proveedor.IdProveedor)
            {
                return BadRequest();
            }

            try
            {
                var mapaux = _mapper.Map<DataModels.Proveedor, data.Proveedor>(proveedor);
                new BS.Proveedor(_context).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!ProveedorExists(id))
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

        // POST: api/Proveedors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DataModels.Proveedor>> PostProveedor(DataModels.Proveedor proveedor)
        {
            var mapaux = _mapper.Map<DataModels.Proveedor, data.Proveedor>(proveedor);
            new BS.Proveedor(_context).Insert(mapaux);

            return CreatedAtAction("GetProveedor", new { id = proveedor.IdProveedor }, proveedor);
        }

        // DELETE: api/Proveedors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.Proveedor>> DeleteProveedor(int id)
        {
            var proveedor = new BS.Proveedor(_context).GetOneByID(id);
            if (proveedor == null)
            {
                return NotFound();
            }


            new BS.Proveedor(_context).Delete(proveedor);
            var mapaux = _mapper.Map<data.Proveedor, DataModels.Proveedor>(proveedor);

            return mapaux;
        }

        private bool ProveedorExists(int id)
        {
            return _context.Proveedor.Any(e => e.IdProveedor == id);
        }
    }
}
