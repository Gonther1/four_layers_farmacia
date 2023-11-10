using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Infrastructure.Data;
using Persistencia.Data;

namespace Infrastructure.Repositories
{
public class RoPersonaRepository : GenericRepository<RolPersona>, IRoPersonaRepository
{
    private readonly ApiFarmaciaContext _context;

    public RoPersonaRepository(ApiFarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
}