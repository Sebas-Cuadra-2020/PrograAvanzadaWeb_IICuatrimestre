using DAL.DO.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;
using DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class RepositoryHistorialFactura : Repository<data.HistorialFactura>, IRepositoryHistorialFactura
    {
        public RepositoryHistorialFactura(SolutionDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<HistorialFactura>> GetAllWithAsAsync()
        {
            return await _db.HistorialFactura
                .Include(m => m.IdClienteNavigation)
                .Include(m => m.IdEmpleadoNavigation)
                .ToListAsync();
        }

        public async Task<HistorialFactura> GetOneByIdAsAsync(int id)
        {
            return await _db.HistorialFactura
            .Include(m => m.IdClienteNavigation)
                .Include(m => m.IdEmpleadoNavigation)
               .SingleOrDefaultAsync(m => m.IdFactura == id);
        }

        private SolutionDbContext _db
        {
            get { return dbContext as SolutionDbContext; }
        }
    }
}
