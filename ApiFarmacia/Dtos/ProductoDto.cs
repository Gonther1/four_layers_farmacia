using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFarmacia.Dtos;

public class ProductoDto
{
    public string Id { get; set; }
    public string NombreProducto { get; set; }
    public int IdMarca { get; set; }
}
