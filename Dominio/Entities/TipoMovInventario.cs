using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

public class TipoMovInventario : BaseEntityInt
{
    public string Nombre { get; set; }
    public ICollection<MovimientoInventario> MovimientosInventarios { get; set; }
}