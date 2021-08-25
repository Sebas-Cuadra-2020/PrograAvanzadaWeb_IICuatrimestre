using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataModels
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int CodigoBarras { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NombreProducto { get; set; }

        //public byte[] ImagenProducto { get; set; }
        public int CantidadProducto { get; set; }
        public int PrecioUnitario { get; set; }
        public int PrecioVenta { get; set; }
        public int IdFamiliaProducto { get; set; }
        public int IdProveedor { get; set; }

        public  FamiliaProducto IdFamiliaProductoNavigation { get; set; }
        public  Proveedor IdProveedorNavigation { get; set; }
    }
}
