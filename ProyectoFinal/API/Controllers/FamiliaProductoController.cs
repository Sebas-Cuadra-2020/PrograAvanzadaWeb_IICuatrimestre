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
    public class FamiliaProductoController : ControllerBase
    {

        private readonly SolutionDbContext _context;

        private readonly IMapper _mapper;

        public FamiliaProductoController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/FamiliaProductoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataModels.FamiliaProducto>>> GetFamiliaProducto()
        {
            var res =  new BS.FamiliaProducto(_context).GetAll();

            var mapaux = _mapper.Map<IEnumerable<data.FamiliaProducto>, IEnumerable<DataModels.FamiliaProducto>>(res).ToList(); 

            return mapaux;
        }

        // GET: api/FamiliaProductoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataModels.FamiliaProducto>> GetFamiliaProducto(int id)
        {
            var familiaProducto = new BS.FamiliaProducto(_context).GetOneByID(id);


            var mapaux = _mapper.Map<data.FamiliaProducto, DataModels.FamiliaProducto>(familiaProducto);


            if (familiaProducto == null)
            {
                return NotFound();
            }

            return mapaux;
        }

        // PUT: api/FamiliaProductoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFamiliaProducto(int id, DataModels.FamiliaProducto familiaProducto)
        {
            if (id != familiaProducto.IdFamiliaProducto)
            {
                return BadRequest();
            }


            try
            {
                var mapaux = _mapper.Map<DataModels.FamiliaProducto, data.FamiliaProducto>(familiaProducto);
                new BS.FamiliaProducto(_context).Update(mapaux);
            }
            catch (Exception ee)
            {
                if (!FamiliaProductoExists(id))
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

        // POST: api/FamiliaProductoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DataModels.FamiliaProducto>> PostFamiliaProducto(DataModels.FamiliaProducto familiaProducto)
        {
            var mapaux = _mapper.Map<DataModels.FamiliaProducto, data.FamiliaProducto>(familiaProducto);
            new BS.FamiliaProducto(_context).Insert(mapaux);

            return CreatedAtAction("GetFamiliaProducto", new { id = familiaProducto.IdFamiliaProducto }, familiaProducto);
        }

        // DELETE: api/FamiliaProductoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataModels.FamiliaProducto>> DeleteFamiliaProducto(int id)
        {
            var familiaProducto = new BS.FamiliaProducto(_context).GetOneByID(id);

            if (familiaProducto == null)
            {
                return NotFound();
            }

            new BS.FamiliaProducto(_context).Delete(familiaProducto);
            var mapaux = _mapper.Map<data.FamiliaProducto, DataModels.FamiliaProducto>(familiaProducto);

            return mapaux;
        }

        private bool FamiliaProductoExists(int id)
        {
            return _context.FamiliaProducto.Any(e => e.IdFamiliaProducto == id);
        }
    }
}
