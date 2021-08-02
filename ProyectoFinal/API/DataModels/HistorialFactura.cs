using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataModels
{
    public class HistorialFactura
    {
        public int IdFactura { get; set; }
        public string CodigoFactura { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaFactura { get; set; }
        public int TotalFactura { get; set; }

        public  Cliente IdClienteNavigation { get; set; }
        public  Empleado IdEmpleadoNavigation { get; set; }
    }
}
