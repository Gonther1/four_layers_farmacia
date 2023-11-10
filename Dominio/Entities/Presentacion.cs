using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

public class Presentacion : BaseEntityInt
{
    public string Nombre { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }
}