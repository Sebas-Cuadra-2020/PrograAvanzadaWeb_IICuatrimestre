using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace BS
{
    public class Proveedor : ICRUD<data.Proveedor>
    {
        
        private SolutionDbContext context;

        public Proveedor(SolutionDbContext _context)
        {
            context = _context;
        }

        public void Delete(data.Proveedor t)
        {
            new DAL.Proveedor(context).Delete(t);
        }

        public IEnumerable<data.Proveedor> GetAll()
        {
            return new DAL.Proveedor(context).GetAll();
        }

        public async Task<IEnumerable<data.Proveedor>> GetAllWithAsync()
        {
            return await new DAL.Proveedor(context).GetAllWithAsync();
        }

        public data.Proveedor GetOneByID(int id)
        {
            return new DAL.Proveedor(context).GetOneByID(id);
        }

        public Task<data.Proveedor> GetOneByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Proveedor t)
        {
            new DAL.Proveedor(context).Insert(t);
        }

        public void Update(data.Proveedor t)
        {
            new DAL.Proveedor(context).Update(t);
        }
    }
}
