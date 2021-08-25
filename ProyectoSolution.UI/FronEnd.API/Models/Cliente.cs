using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FronEnd.API.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            HistorialFactura = new HashSet<HistorialFactura>();
        }

        

        public int IdCliente { get; set; }
        public int CedulaCliente { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NombreCliente { get; set; }
        public string CorreoEmpleado { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string TelefonoEmpleado { get; set; }

        public virtual ICollection<HistorialFactura> HistorialFactura { get; set; }
    }
}
