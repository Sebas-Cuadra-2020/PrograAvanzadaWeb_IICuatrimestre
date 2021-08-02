using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataModels
{
    public class Empleado
    {
        //public Empleado()
        //{
        //    HistorialFactura = new HashSet<HistorialFactura>();
        //}

        public int IdEmpleado { get; set; }
        public int CedulaEmpleado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string CorreoEmpleado { get; set; }
        public string PasswordEmpleado { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string TelefonoEmpleado { get; set; }
        public int IdRol { get; set; }

        public RolEmpleado IdRolNavigation { get; set; }
        //public virtual ICollection<HistorialFactura> HistorialFactura { get; set; }
    }
}
