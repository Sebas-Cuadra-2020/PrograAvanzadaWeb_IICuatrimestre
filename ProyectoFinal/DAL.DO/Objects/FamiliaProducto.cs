using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DO.Objects
{
    public class FamiliaProducto
    {
        public FamiliaProducto()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdFamiliaProducto { get; set; }
        public string NombreFamiliaProducto { get; set; }
        public int CodigoCabys { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
