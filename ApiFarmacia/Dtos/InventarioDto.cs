using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFarmacia.Dtos;

public class InventarioDto
{
    public string Id { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
    public int IdPresentacion { get; set; }
    public string CodProducto { get; set; }
}
