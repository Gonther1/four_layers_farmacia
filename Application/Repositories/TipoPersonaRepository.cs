using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Infrastructure.Data;
using Persistencia.Data;

namespace Infrastructure.Repositories;

public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersonaRepository
{
    private readonly ApiFarmaciaContext _context;

    public TipoPersonaRepository(ApiFarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
