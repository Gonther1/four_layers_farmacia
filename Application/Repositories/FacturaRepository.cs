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
public class FacturaRepository : GenericRepository<Factura>, IFacturaRepository
{
    private readonly ApiFarmaciaContext _context;

    public FacturaRepository(ApiFarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
}