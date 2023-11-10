using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

public class Ciudad : BaseEntityInt
{
    public string Nombre { get; set; }
    public int IdDepartamentoFk { get; set; }
    public Departamento Departamentos { get; set; }
    public ICollection<UbicacionPersona> UbicacionesPersonas { get; set; }
}