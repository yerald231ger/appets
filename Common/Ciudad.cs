using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApPets.Common
{
    public class Ciudad : Base<int>
    {
        public int IdEstado { get; set; }

        public Estado Estado { get; set; }
    }
}
