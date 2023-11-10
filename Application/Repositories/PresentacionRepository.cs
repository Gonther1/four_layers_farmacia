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
public class PresentacionRepository : GenericRepository<Presentacion>, IPresentacionRepository
{
    private readonly ApiFarmaciaContext _context;

    public PresentacionRepository(ApiFarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
}