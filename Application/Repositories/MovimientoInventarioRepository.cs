using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Dominio.Entities;
using Infrastructure.Data;
using Persistencia.Data;

namespace Infrastructure.Repositories
{
public class MovimientoInventarioRepository : GenericRepositoryStr<MovimientoInventario>, IMovimientoInventarioRepository
{
    private readonly ApiFarmaciaContext _context;

    public MovimientoInventarioRepository(ApiFarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
}