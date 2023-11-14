using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFarmacia.Dtos;
using AutoMapper;
using Dominio.Entities;

namespace ApiFarmacia.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Ciudad, CiudadDto>().ReverseMap(); 
        CreateMap<ContactoPersona, ContactoPersonaDto>().ReverseMap(); 
        CreateMap<Departamento, DepartamentoDto>().ReverseMap(); 
        CreateMap<DetalleMovInventario, DetalleMovInventarioDto>().ReverseMap(); 
        CreateMap<Factura, FacturaDto>().ReverseMap(); 
        CreateMap<FormaPago, FormaPagoDto>().ReverseMap(); 
        CreateMap<Inventario, InventarioDto>().ReverseMap(); 
        CreateMap<Marca, MarcaDto>().ReverseMap(); 
        CreateMap<MovimientoInventario, MovimientoInventarioDto>().ReverseMap(); 
        CreateMap<Pais, PaisDto>().ReverseMap(); 
        CreateMap<Persona, PersonaDto>().ReverseMap(); 
        CreateMap<Presentacion, PresentacionDto>().ReverseMap(); 
        CreateMap<Producto, ProductoDto>().ReverseMap(); 
        CreateMap<RolPersona, RolPersonaDto>().ReverseMap(); 
        CreateMap<TipoContacto, TipoContactoDto>().ReverseMap(); 
        CreateMap<TipoDocumento, TipoDocumentoDto>().ReverseMap(); 
        CreateMap<TipoMovInventario, TipoMovInventarioDto>().ReverseMap(); 
        CreateMap<TipoPersona, TipoPersonaDto>().ReverseMap(); 
        CreateMap<UbicacionPersona, UbicacionPersonaDto>().ReverseMap(); 
    }
}
