using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFarmacia.Dtos;

public class FacturaDto
{
    public int Id { get; set; }
    public int FacturaInicial { get; set; }
    public int FacturaFinal { get; set; }
    public int FacturaActual { get; set; }
    public string NroResolucion { get; set; }
    public string IdPersona { get; set; }
    public string IdDetalleMovimiento { get; set; }
}
