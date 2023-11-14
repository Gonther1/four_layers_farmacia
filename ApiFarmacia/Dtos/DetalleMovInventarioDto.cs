using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFarmacia.Dtos;

public class DetalleMovInventarioDto
{
    public int Id { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public string IdInventario { get; set; }
    public string IdMovInv { get; set; }
}
