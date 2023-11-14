using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFarmacia.Helpers
{
    public class Authorization
    {
        public enum Roles
        {
            Administrator,
            Manager,
            Employed,
            Person
        }
        public const Roles rol_default = Roles.Employed;
    }
}