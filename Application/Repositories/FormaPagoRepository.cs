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
public class FormaPagoRepository : GenericRepository<FormaPago>, IFormaPagoRepository
{
    private readonly ApiFarmaciaContext _context;

    public FormaPagoRepository(ApiFarmaciaContext context) : base(context)
    {
        _context = context;
    }
}
}