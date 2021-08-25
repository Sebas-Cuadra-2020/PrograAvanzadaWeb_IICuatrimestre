using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataModels
{
    public class Proveedor
    {
    //    public Proveedor()
    //    {
    //        Producto = new HashSet<Producto>();
    //    }

        public int IdProveedor { get; set; }
        public int CedulaProveedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NombreProveedor { get; set; }
        public string CorreoProveedor { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string TelefonoProveedor { get; set; }
        public string CuentaBancariaProveedor { get; set; }

        //public virtual ICollection<Producto> Producto { get; set; }
    }
}
