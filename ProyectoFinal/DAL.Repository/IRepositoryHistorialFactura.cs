using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = DAL.DO.Objects;

namespace DAL.Repository
{
    public interface IRepositoryHistorialFactura : IRepository<data.HistorialFactura>
    {
        Task<IEnumerable<data.HistorialFactura>> GetAllWithAsAsync();
        Task<data.HistorialFactura> GetOneByIdAsAsync(int id);
    }
}
