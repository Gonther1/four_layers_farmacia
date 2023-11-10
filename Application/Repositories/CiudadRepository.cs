using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Infrastructure.Repositories;
using Persistencia.Data;

namespace Application.Repositories;

public class CiudadRepository : GenericRepository<Ciudad>, ICiudadRepository
{
    private readonly ApiFarmaciaContext _context;

    public CiudadRepository(ApiFarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
