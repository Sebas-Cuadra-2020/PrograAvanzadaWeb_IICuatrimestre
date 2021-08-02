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
    public class RepositoryProducto : Repository<data.Producto>, IRepositoryProducto
    {
        public RepositoryProducto(SolutionDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Producto>> GetAllWithAsAsync()
        {
            return await _db.Producto
                .Include(m => m.IdFamiliaProductoNavigation)
                .Include(m => m.IdProveedorNavigation)
                .ToListAsync();
        }

        public async Task<Producto> GetOneByIdAsAsync(int id)
        {
            return await _db.Producto
               .Include(m => m.IdFamiliaProductoNavigation)
               .Include(m => m.IdProveedorNavigation)
               .SingleOrDefaultAsync(m => m.IdProducto == id);
        }

        private SolutionDbContext _db
        {
            get { return dbContext as SolutionDbContext; }
        }
    }
}
