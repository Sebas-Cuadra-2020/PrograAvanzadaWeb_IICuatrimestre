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
    public class FamiliaProducto : ICRUD<data.FamiliaProducto>
    {
        private Repository<data.FamiliaProducto> _repo = null;

        public FamiliaProducto(SolutionDbContext solutionDbContext)
        {
            _repo = new Repository<data.FamiliaProducto>(solutionDbContext);
        }
        public void Delete(data.FamiliaProducto t)
        {
            _repo.Delete(t);
            _repo.Commit();
        }

        public IEnumerable<data.FamiliaProducto> GetAll()
        {
            return _repo.GetAll();
        }

        public Task<IEnumerable<data.FamiliaProducto>> GetAllWithAsync()
        {
            throw new NotImplementedException();
        }

        public data.FamiliaProducto GetOneByID(int id)
        {
            return _repo.GetOneById(id);
        }

        public Task<data.FamiliaProducto> GetOneByIdWithAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.FamiliaProducto t)
        {
            _repo.Insert(t);
            _repo.Commit();
        }

        public void Update(data.FamiliaProducto t)
        {
            _repo.Update(t);
            _repo.Commit();
        }
    }
}
