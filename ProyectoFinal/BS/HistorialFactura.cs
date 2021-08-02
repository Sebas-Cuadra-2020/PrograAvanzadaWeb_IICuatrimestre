using DAL.DO.Interfaces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;
namespace BS
{
    public class HistorialFactura : ICRUD<data.HistorialFactura>
    {
        private SolutionDbContext context;

        public HistorialFactura(SolutionDbContext _context)
        {
            context = _context;
        }

        public void Delete(data.HistorialFactura t)
        {
            new DAL.HistorialFactura(context).Delete(t);
        }

        public IEnumerable<data.HistorialFactura> GetAll()
        {
            return new DAL.HistorialFactura(context).GetAll();
        }

        public async Task<IEnumerable<data.HistorialFactura>> GetAllWithAsync()
        {
            return await new DAL.HistorialFactura(context).GetAllWithAsync();
        }

        public data.HistorialFactura GetOneByID(int id)
        {
            return new DAL.HistorialFactura(context).GetOneByID(id);
        }

        public async Task<data.HistorialFactura> GetOneByIdWithAsync(int id)
        {
            return await new DAL.HistorialFactura(context).GetOneByIdWithAsync(id);
        }

        public void Insert(data.HistorialFactura t)
        {
            new DAL.HistorialFactura(context).Insert(t);
        }

        public void Update(data.HistorialFactura t)
        {
            new DAL.HistorialFactura(context).Update(t);
        }
    }
}
