using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;

public class Rol : BaseEntityInt
{
    public string Name { get; set; }
    public ICollection<User> Users { get; set; }
    public ICollection<UserRol> UsersRols { get; set; }
}
