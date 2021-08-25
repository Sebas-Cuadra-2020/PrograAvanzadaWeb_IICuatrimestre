using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DO.Objects
{
    public class HistorialFactura
    {
            public int IdFactura { get; set; }
            public string CodigoFactura { get; set; }
            public int IdCliente { get; set; }
            public int IdEmpleado { get; set; }
            public DateTime FechaFactura { get; set; }
            public int TotalFactura { get; set; }

            public virtual Cliente IdClienteNavigation { get; set; }
            public virtual Empleado IdEmpleadoNavigation { get; set; }
        }
}
