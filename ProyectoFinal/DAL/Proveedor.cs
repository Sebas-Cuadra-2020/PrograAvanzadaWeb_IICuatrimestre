using DAL.DO.Interfaces;
using DAL.EF;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace DAL
{
    public class Proveedor : ICRUD<data.Proveedor>
    {
        private Repository<data.Proveedor> _repo = null;

        public Proveedor(SolutionDbContext solutionDbContext)
        {
            _repo = new Repository<data.Proveedor>(solutionDbContext);
        }

        public void Delete(data.Proveedor t)
        {
            _repo.Delete(t);
            _repo.Commit();
        }

        public IEnumerable<data.Proveedor> GetAll()
        {
            return _repo.GetAll();
        }

        public Task<IEnumerable<data.Proveedor>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public data.Proveedor GetOneByID(int id)
        {
            return _repo.GetOneById(id);
        }

        public Task<data.Proveedor> GetOneByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Proveedor t)
        {
            _repo.Insert(t);
            _repo.Commit();
        }

        public void Update(data.Proveedor t)
        {
            _repo.Update(t);
            _repo.Commit();
        }
    }
}
