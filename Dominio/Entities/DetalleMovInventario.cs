using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

public class DetalleMovInventario : BaseEntityInt
{
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public string IdInventario { get; set; }
    public Inventario Inventarios { get; set; }
    public string IdMovInv { get; set; }
    public MovimientoInventario MovimientosInventarios { get; set; }
    public ICollection<Factura> Facturas { get; set; }
    
}
