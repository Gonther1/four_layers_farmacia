using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Dominio.Interfaces;

public interface IUserRepository : IGenericRepository<User>
{
    Task<User> GetByUserNameAsync(string username);
    Task<User> GetByRefreshTokenAsync(string username);
}
