using FronEnd.API.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FronEnd.API.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            HistorialFactura = new HashSet<HistorialFactura>();
        }

        public int IdEmpleado { get; set; }
        public int CedulaEmpleado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "{0} es un campo requerido")]
        [EmailAddress(ErrorMessage = "{0} no es un campo valido")]
        public string CorreoEmpleado { get; set; }
        [Required(ErrorMessage = "{0} es un campo requerido")]
        [DisplayName("Contraseña")]

        [ContrasenaValidate(ErrorMessage = "Contraseña no valida")]
        public string PasswordEmpleado { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string TelefonoEmpleado { get; set; }
        public int IdRol { get; set; }

        public virtual RolEmpleado IdRolNavigation { get; set; }
        public virtual ICollection<HistorialFactura> HistorialFactura { get; set; }
    }
}
