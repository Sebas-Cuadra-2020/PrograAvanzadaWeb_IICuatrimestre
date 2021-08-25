using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using data = DAL.DO.Objects;


namespace API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<data.Proveedor, DataModels.Proveedor>().ReverseMap();
            CreateMap<data.Producto, DataModels.Producto>().ReverseMap();
            CreateMap<data.FamiliaProducto, DataModels.FamiliaProducto>().ReverseMap();
            CreateMap<data.Cliente, DataModels.Cliente>().ReverseMap();
            CreateMap<data.Empleado, DataModels.Empleado>().ReverseMap();
            CreateMap<data.HistorialFactura, DataModels.HistorialFactura>().ReverseMap();
            CreateMap<data.RolEmpleado, DataModels.RolEmpleado>().ReverseMap();
        }
    }
}
