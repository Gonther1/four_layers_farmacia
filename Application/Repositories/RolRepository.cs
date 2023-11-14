using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Infrastructure.Repositories;
using Persistencia.Data;

namespace Application.Repositories;

public class RolRepository : GenericRepository<Rol>, IRolRepository
{
    private readonly ApiFarmaciaContext _context;
    public RolRepository(ApiFarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
