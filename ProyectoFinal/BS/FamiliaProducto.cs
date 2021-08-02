using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace BS
{
    public class FamiliaProducto : ICRUD<data.FamiliaProducto>
    {
        private SolutionDbContext context;

        public FamiliaProducto(SolutionDbContext _context)
        {
            context = _context;
        }

        public void Delete(data.FamiliaProducto t)
        {
            new DAL.FamiliaProducto(context).Delete(t);
        }

        public IEnumerable<data.FamiliaProducto> GetAll()
        {
            return new DAL.FamiliaProducto(context).GetAll();
        }

        public async Task<IEnumerable<data.FamiliaProducto>> GetAllWithAsync()
        {
            return await new DAL.FamiliaProducto(context).GetAllWithAsync();
        }

        public data.FamiliaProducto GetOneByID(int id)
        {
            return new DAL.FamiliaProducto(context).GetOneByID(id);
        }

        public Task<data.FamiliaProducto> GetOneByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.FamiliaProducto t)
        {
            new DAL.FamiliaProducto(context).Insert(t);
        }

        public void Update(data.FamiliaProducto t)
        {
            new DAL.FamiliaProducto(context).Update(t);
        }
    }
}
