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
   public class HistorialFactura : ICRUD<data.HistorialFactura>
    {
        private RepositoryHistorialFactura _repo = null;

        public HistorialFactura(SolutionDbContext solutionDbContext)
        {
            _repo = new RepositoryHistorialFactura(solutionDbContext);
        }

        public void Delete(data.HistorialFactura t)
        {
            _repo.Delete(t);
            _repo.Commit();
        }

        public IEnumerable<data.HistorialFactura> GetAll()
        {
            return _repo.GetAll();
        }

        public async Task<IEnumerable<data.HistorialFactura>> GetAllWithAsync()
        {
            return await _repo.GetAllWithAsAsync();
        }

        public data.HistorialFactura GetOneByID(int id)
        {
            return _repo.GetOneById(id);
        }

        public async Task<data.HistorialFactura> GetOneByIdWithAsync(int id)
        {
            return await _repo.GetOneByIdAsAsync(id);
        }

        public void Insert(data.HistorialFactura t)
        {
            _repo.Insert(t);
            _repo.Commit();
        }

        public void Update(data.HistorialFactura t)
        {
            _repo.Update(t);
            _repo.Commit();
        }
    }
}
